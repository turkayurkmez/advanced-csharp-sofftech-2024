namespace Display.Main
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            pluginsToolStripMenuItem = new ToolStripMenuItem();
            pluginEkleToolStripMenuItem = new ToolStripMenuItem();
            splitContainer1 = new SplitContainer();
            buttonSelectColor = new Button();
            numericUpDownHeight = new NumericUpDown();
            numericUpDownWith = new NumericUpDown();
            numericUpDownY = new NumericUpDown();
            numericUpDownX = new NumericUpDown();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownWith).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownX).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { pluginsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // pluginsToolStripMenuItem
            // 
            pluginsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pluginEkleToolStripMenuItem });
            pluginsToolStripMenuItem.Name = "pluginsToolStripMenuItem";
            pluginsToolStripMenuItem.Size = new Size(58, 20);
            pluginsToolStripMenuItem.Text = "Plugins";
            // 
            // pluginEkleToolStripMenuItem
            // 
            pluginEkleToolStripMenuItem.Name = "pluginEkleToolStripMenuItem";
            pluginEkleToolStripMenuItem.Size = new Size(132, 22);
            pluginEkleToolStripMenuItem.Text = "Plugin Ekle";
            pluginEkleToolStripMenuItem.Click += pluginEkleToolStripMenuItem_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.BorderStyle = BorderStyle.Fixed3D;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 24);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(buttonSelectColor);
            splitContainer1.Panel1.Controls.Add(numericUpDownHeight);
            splitContainer1.Panel1.Controls.Add(numericUpDownWith);
            splitContainer1.Panel1.Controls.Add(numericUpDownY);
            splitContainer1.Panel1.Controls.Add(numericUpDownX);
            splitContainer1.Size = new Size(800, 426);
            splitContainer1.SplitterDistance = 266;
            splitContainer1.TabIndex = 1;
            // 
            // buttonSelectColor
            // 
            buttonSelectColor.Location = new Point(23, 234);
            buttonSelectColor.Name = "buttonSelectColor";
            buttonSelectColor.Size = new Size(120, 31);
            buttonSelectColor.TabIndex = 6;
            buttonSelectColor.Text = "Renk Seçiniz";
            buttonSelectColor.UseVisualStyleBackColor = true;
            buttonSelectColor.Click += buttonSelectColor_Click;
            // 
            // numericUpDownHeight
            // 
            numericUpDownHeight.Location = new Point(23, 189);
            numericUpDownHeight.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownHeight.Name = "numericUpDownHeight";
            numericUpDownHeight.Size = new Size(120, 23);
            numericUpDownHeight.TabIndex = 4;
            // 
            // numericUpDownWith
            // 
            numericUpDownWith.Location = new Point(23, 146);
            numericUpDownWith.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownWith.Name = "numericUpDownWith";
            numericUpDownWith.Size = new Size(120, 23);
            numericUpDownWith.TabIndex = 5;
            // 
            // numericUpDownY
            // 
            numericUpDownY.Location = new Point(23, 104);
            numericUpDownY.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownY.Name = "numericUpDownY";
            numericUpDownY.Size = new Size(120, 23);
            numericUpDownY.TabIndex = 2;
            // 
            // numericUpDownX
            // 
            numericUpDownX.Location = new Point(23, 64);
            numericUpDownX.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownX.Name = "numericUpDownX";
            numericUpDownX.Size = new Size(120, 23);
            numericUpDownX.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDownHeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownWith).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownY).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownX).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem pluginsToolStripMenuItem;
        private ToolStripMenuItem pluginEkleToolStripMenuItem;
        private SplitContainer splitContainer1;
        private Button buttonSelectColor;
        private NumericUpDown numericUpDownHeight;
        private NumericUpDown numericUpDownWith;
        private NumericUpDown numericUpDownY;
        private NumericUpDown numericUpDownX;
    }
}
