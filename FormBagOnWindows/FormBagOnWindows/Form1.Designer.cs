namespace FormBagOnWindows
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            buttonGonder = new Button();
            textBoxProductName = new TextBox();
            textBoxPrice = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(86, 65);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(287, 430);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // buttonGonder
            // 
            buttonGonder.Location = new Point(491, 472);
            buttonGonder.Name = "buttonGonder";
            buttonGonder.Size = new Size(75, 23);
            buttonGonder.TabIndex = 1;
            buttonGonder.Text = "Gönder";
            buttonGonder.UseVisualStyleBackColor = true;
            buttonGonder.Click += buttonGonder_Click;
            // 
            // textBoxProductName
            // 
            textBoxProductName.Location = new Point(491, 79);
            textBoxProductName.Name = "textBoxProductName";
            textBoxProductName.Size = new Size(164, 23);
            textBoxProductName.TabIndex = 2;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(491, 108);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(164, 23);
            textBoxPrice.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(779, 528);
            Controls.Add(textBoxPrice);
            Controls.Add(textBoxProductName);
            Controls.Add(buttonGonder);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button buttonGonder;
        private TextBox textBoxProductName;
        private TextBox textBoxPrice;
    }
}
