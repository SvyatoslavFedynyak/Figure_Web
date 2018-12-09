using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models_and_Functions.Models;

namespace DesctopSimple
{
    public partial class Form1 : Form
    {
        // 50:50
        // 1000:500
        // coord in start from left down corner
        #region Config
        int fieldStartX;
        int fieldStartY;
        int fieldWidth;
        int fieldHeigh;
        #endregion

        #region State
        bool isDrawing;
        Color drawingColor;
        #endregion

        #region Data
        Hub appHub;
        List<Models_and_Functions.Models.Point> drawingPoints;
        #endregion
        public Form1()
        {
            InitializeComponent();
            fieldStartX = hubPictureBox.Location.X;
            fieldStartY = hubPictureBox.Location.Y;
            fieldWidth = hubPictureBox.Size.Width;
            fieldHeigh = hubPictureBox.Size.Height;
            drawingColor = Color.Black;
            isDrawing = false;
            drawingPoints = new List<Models_and_Functions.Models.Point>();
            hubPictureBox.Refresh();
            appHub = new Hub(fieldWidth, fieldHeigh);
            ((ListBox)lairsCheckedListBox).DataSource = appHub.Lairs;
            ((ListBox)lairsCheckedListBox).DisplayMember = "Name";
            ((ListBox)lairsCheckedListBox).ValueMember = "Visible";
            lairsCheckedListBox.ItemCheck += Form1_SelectedValueChanged;
        }

        private void Form1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (lairsCheckedListBox.SelectedIndex != -1)
            {
                appHub[lairsCheckedListBox.SelectedIndex].Visible = !appHub[lairsCheckedListBox.SelectedIndex].Visible;
            }
            hubPictureBox.Refresh();
        }

        private int ConvertXToDraw(double x)
        {
            return (int)(x);
        }
        private int ConvertYToDraw(double y)
        {
            return (int)(fieldHeigh - y);
        }
        private double ConvertXToHub(int x)
        {
            return x;
        }
        private double ConvertYToHub(int y)
        {
            return fieldHeigh - y;
        }

        private void hubPictureBox_Click(object sender, EventArgs e)
        {
            MouseEventArgs temp = (MouseEventArgs)e;
            if (isDrawing)
            {
                drawingPoints.Add(new Models_and_Functions.Models.Point(ConvertXToHub(temp.X), ConvertYToHub(temp.Y)));
                hubPictureBox.Refresh();
            }
            else
            {
                Models_and_Functions.Models.Point targetPoint = new Models_and_Functions.Models.Point(ConvertXToHub(temp.X), ConvertYToHub(temp.Y));
                StringBuilder analyseSb = new StringBuilder();
                analyseSb.AppendLine("Finded figures, which contain this point:");
                for (int i = appHub.Lairs.Count - 1; i >= 0; i--)
                {
                    analyseSb.AppendLine($"{appHub[i].ToString()}:");
                    if (appHub[i].Figures.Count != 0)
                    {
                        if (Models_and_Functions.Functions.GeometricCalculations.IsPointOnFigure(targetPoint, appHub[i].Figures[0])) 
                        {
                            analyseSb.AppendLine(appHub[i].Figures[0].ToString());
                        }
                        else
                        {
                            analyseSb.AppendLine("Empty!");
                        }
                    }
                    else
                    {
                        analyseSb.AppendLine("Empty!");
                    }
                    analyseSb.AppendLine();
                }
                outputTextBox.Text = analyseSb.ToString();
            }


        }

        private void hubPictureBox_Paint(object sender, PaintEventArgs e)
        {
            #region Draw Hub;
            for (int i = 0; i < appHub.Lairs.Count; i++)
            {
                if (appHub.Lairs[i].Visible)
                {
                    for (int j = 0; j < appHub.Lairs[i].Figures.Count; j++)
                    {
                        e.Graphics.DrawPolygon(new Pen(appHub.Lairs[i].Figures[j].Color), GetPoints(appHub.Lairs[i].Figures[j]));
                        e.Graphics.FillPolygon(new SolidBrush(appHub.Lairs[i].Figures[j].Color), GetPoints(appHub.Lairs[i].Figures[j]));
                    }


                }
            }

            #endregion

            #region Draw temp figure
            int x1, x2, y1, y2;
            for (int i = 0; i < drawingPoints.Count - 1; i++)
            {
                x1 = ConvertXToDraw(drawingPoints[i].X);
                y1 = ConvertYToDraw(drawingPoints[i].Y);
                x2 = ConvertXToDraw(drawingPoints[i + 1].X);
                y2 = ConvertYToDraw(drawingPoints[i + 1].Y);
                e.Graphics.DrawLine(new Pen(drawingColor), x1, y1, x2, y2);
            }

            #endregion
        }

        private PointF[] GetPoints(Figure figure)
        {
            int count = figure.Edges.Count;
            PointF[] res = new PointF[count];
            for (int i = 0; i < count; i++)
            {
                res[i].X = ConvertXToDraw(figure.Edges[i].X);
                res[i].Y = ConvertYToDraw(figure.Edges[i].Y);
            }
            return res;
        }

        private void startDrawingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isDrawing = true;
        }

        private void endDrawingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            appHub.AddLair();
            appHub[appHub.Lairs.Count - 1].Add(new Figure() { Edges = drawingPoints, Color = drawingColor });
            appHub[appHub.Lairs.Count - 1].Visible = true;
            drawingPoints = new List<Models_and_Functions.Models.Point>();
            drawingPoints.Clear();
            isDrawing = false;
            hubPictureBox.Refresh();
            RebuildLairList();
        }

        private void RebuildLairList()
        {
            ((ListBox)lairsCheckedListBox).DataSource = null;
            ((ListBox)lairsCheckedListBox).DataSource = appHub.Lairs;
            for (int i = 0; i < lairsCheckedListBox.Items.Count; i++)
            {
                lairsCheckedListBox.SetItemChecked(i, ((Lair)lairsCheckedListBox.Items[i]).Visible);
            }
        }

        private void resetDrawingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drawingPoints.Clear();
            isDrawing = false;
            hubPictureBox.Refresh();
        }

        private void selectColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (figureColorDialog.ShowDialog() == DialogResult.OK)
            {
                drawingColor = figureColorDialog.Color;
            }
        }
    }
}
