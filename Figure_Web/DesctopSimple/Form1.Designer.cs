namespace DesctopSimple
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.hubPictureBox = new System.Windows.Forms.PictureBox();
            this.drawingContextStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.startDrawingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.endDrawingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetDrawingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lairsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.lairsContextStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeCheckedLairsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveDownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.figureColorDialog = new System.Windows.Forms.ColorDialog();
            this.outputTextBox = new System.Windows.Forms.RichTextBox();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.hubPictureBox)).BeginInit();
            this.drawingContextStrip.SuspendLayout();
            this.mainMenuStrip.SuspendLayout();
            this.lairsContextStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // hubPictureBox
            // 
            this.hubPictureBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.hubPictureBox.ContextMenuStrip = this.drawingContextStrip;
            this.hubPictureBox.Location = new System.Drawing.Point(50, 50);
            this.hubPictureBox.Name = "hubPictureBox";
            this.hubPictureBox.Size = new System.Drawing.Size(1000, 500);
            this.hubPictureBox.TabIndex = 0;
            this.hubPictureBox.TabStop = false;
            this.hubPictureBox.Click += new System.EventHandler(this.hubPictureBox_Click);
            this.hubPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.hubPictureBox_Paint);
            // 
            // drawingContextStrip
            // 
            this.drawingContextStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startDrawingToolStripMenuItem,
            this.endDrawingToolStripMenuItem,
            this.resetDrawingToolStripMenuItem,
            this.selectColorToolStripMenuItem});
            this.drawingContextStrip.Name = "contextMenuStrip1";
            this.drawingContextStrip.Size = new System.Drawing.Size(149, 92);
            // 
            // startDrawingToolStripMenuItem
            // 
            this.startDrawingToolStripMenuItem.Name = "startDrawingToolStripMenuItem";
            this.startDrawingToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.startDrawingToolStripMenuItem.Text = "Start drawing";
            this.startDrawingToolStripMenuItem.Click += new System.EventHandler(this.startDrawingToolStripMenuItem_Click);
            // 
            // endDrawingToolStripMenuItem
            // 
            this.endDrawingToolStripMenuItem.Name = "endDrawingToolStripMenuItem";
            this.endDrawingToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.endDrawingToolStripMenuItem.Text = "End drawing";
            this.endDrawingToolStripMenuItem.Click += new System.EventHandler(this.endDrawingToolStripMenuItem_Click);
            // 
            // resetDrawingToolStripMenuItem
            // 
            this.resetDrawingToolStripMenuItem.Name = "resetDrawingToolStripMenuItem";
            this.resetDrawingToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.resetDrawingToolStripMenuItem.Text = "Reset drawing";
            this.resetDrawingToolStripMenuItem.Click += new System.EventHandler(this.resetDrawingToolStripMenuItem_Click);
            // 
            // selectColorToolStripMenuItem
            // 
            this.selectColorToolStripMenuItem.Name = "selectColorToolStripMenuItem";
            this.selectColorToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.selectColorToolStripMenuItem.Text = "Select color";
            this.selectColorToolStripMenuItem.Click += new System.EventHandler(this.selectColorToolStripMenuItem_Click);
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(1284, 24);
            this.mainMenuStrip.TabIndex = 1;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // lairsCheckedListBox
            // 
            this.lairsCheckedListBox.ContextMenuStrip = this.lairsContextStrip;
            this.lairsCheckedListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lairsCheckedListBox.FormattingEnabled = true;
            this.lairsCheckedListBox.Location = new System.Drawing.Point(1078, 93);
            this.lairsCheckedListBox.Name = "lairsCheckedListBox";
            this.lairsCheckedListBox.Size = new System.Drawing.Size(184, 112);
            this.lairsCheckedListBox.TabIndex = 2;
            // 
            // lairsContextStrip
            // 
            this.lairsContextStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeCheckedLairsToolStripMenuItem,
            this.moveUpToolStripMenuItem,
            this.moveDownToolStripMenuItem});
            this.lairsContextStrip.Name = "lairsContextStrip";
            this.lairsContextStrip.Size = new System.Drawing.Size(138, 70);
            // 
            // removeCheckedLairsToolStripMenuItem
            // 
            this.removeCheckedLairsToolStripMenuItem.Name = "removeCheckedLairsToolStripMenuItem";
            this.removeCheckedLairsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.removeCheckedLairsToolStripMenuItem.Text = "Remove";
            this.removeCheckedLairsToolStripMenuItem.Click += new System.EventHandler(this.removeCheckedLairsToolStripMenuItem_Click);
            // 
            // moveUpToolStripMenuItem
            // 
            this.moveUpToolStripMenuItem.Name = "moveUpToolStripMenuItem";
            this.moveUpToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.moveUpToolStripMenuItem.Text = "Move up";
            this.moveUpToolStripMenuItem.Click += new System.EventHandler(this.moveUpToolStripMenuItem_Click);
            // 
            // moveDownToolStripMenuItem
            // 
            this.moveDownToolStripMenuItem.Name = "moveDownToolStripMenuItem";
            this.moveDownToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.moveDownToolStripMenuItem.Text = "Move down";
            this.moveDownToolStripMenuItem.Click += new System.EventHandler(this.moveDownToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(1138, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lairs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(1138, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Output";
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(1078, 261);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(184, 289);
            this.outputTextBox.TabIndex = 7;
            this.outputTextBox.Text = "";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 591);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lairsCheckedListBox);
            this.Controls.Add(this.hubPictureBox);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "Form1";
            this.Text = "Figures drawer and analiser";
            ((System.ComponentModel.ISupportInitialize)(this.hubPictureBox)).EndInit();
            this.drawingContextStrip.ResumeLayout(false);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.lairsContextStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox hubPictureBox;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.CheckedListBox lairsCheckedListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip drawingContextStrip;
        private System.Windows.Forms.ToolStripMenuItem endDrawingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetDrawingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startDrawingToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip lairsContextStrip;
        private System.Windows.Forms.ToolStripMenuItem moveUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeCheckedLairsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectColorToolStripMenuItem;
        private System.Windows.Forms.ColorDialog figureColorDialog;
        private System.Windows.Forms.RichTextBox outputTextBox;
        private System.Windows.Forms.ToolStripMenuItem moveDownToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
    }
}

