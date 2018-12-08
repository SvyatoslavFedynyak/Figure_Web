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
            this.endDrawingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetDrawingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lairsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.startDrawingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lairsContextStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addLairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeCheckedLairsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.figureColorDialog = new System.Windows.Forms.ColorDialog();
            this.selectColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.hubPictureBox)).BeginInit();
            this.drawingContextStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
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
            // endDrawingToolStripMenuItem
            // 
            this.endDrawingToolStripMenuItem.Name = "endDrawingToolStripMenuItem";
            this.endDrawingToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.endDrawingToolStripMenuItem.Text = "End drawing";
            this.endDrawingToolStripMenuItem.Click += new System.EventHandler(this.endDrawingToolStripMenuItem_Click);
            // 
            // resetDrawingToolStripMenuItem
            // 
            this.resetDrawingToolStripMenuItem.Name = "resetDrawingToolStripMenuItem";
            this.resetDrawingToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.resetDrawingToolStripMenuItem.Text = "Reset drawing";
            this.resetDrawingToolStripMenuItem.Click += new System.EventHandler(this.resetDrawingToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1284, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loadToolStripMenuItem.Text = "Load...";
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
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(1078, 255);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(184, 295);
            this.outputTextBox.TabIndex = 4;
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
            // startDrawingToolStripMenuItem
            // 
            this.startDrawingToolStripMenuItem.Name = "startDrawingToolStripMenuItem";
            this.startDrawingToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.startDrawingToolStripMenuItem.Text = "Start drawing";
            this.startDrawingToolStripMenuItem.Click += new System.EventHandler(this.startDrawingToolStripMenuItem_Click);
            // 
            // lairsContextStrip
            // 
            this.lairsContextStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addLairToolStripMenuItem,
            this.removeCheckedLairsToolStripMenuItem});
            this.lairsContextStrip.Name = "lairsContextStrip";
            this.lairsContextStrip.Size = new System.Drawing.Size(189, 48);
            // 
            // addLairToolStripMenuItem
            // 
            this.addLairToolStripMenuItem.Name = "addLairToolStripMenuItem";
            this.addLairToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.addLairToolStripMenuItem.Text = "Add lair";
            // 
            // removeCheckedLairsToolStripMenuItem
            // 
            this.removeCheckedLairsToolStripMenuItem.Name = "removeCheckedLairsToolStripMenuItem";
            this.removeCheckedLairsToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.removeCheckedLairsToolStripMenuItem.Text = "Remove checked lairs";
            // 
            // selectColorToolStripMenuItem
            // 
            this.selectColorToolStripMenuItem.Name = "selectColorToolStripMenuItem";
            this.selectColorToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.selectColorToolStripMenuItem.Text = "Select color";
            this.selectColorToolStripMenuItem.Click += new System.EventHandler(this.selectColorToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 591);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lairsCheckedListBox);
            this.Controls.Add(this.hubPictureBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.hubPictureBox)).EndInit();
            this.drawingContextStrip.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.lairsContextStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox hubPictureBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.CheckedListBox lairsCheckedListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip drawingContextStrip;
        private System.Windows.Forms.ToolStripMenuItem endDrawingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetDrawingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startDrawingToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip lairsContextStrip;
        private System.Windows.Forms.ToolStripMenuItem addLairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeCheckedLairsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectColorToolStripMenuItem;
        private System.Windows.Forms.ColorDialog figureColorDialog;
    }
}

