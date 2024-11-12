namespace introduceReflection
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
            comboBoxTypes = new ComboBox();
            buttonSearch = new Button();
            listBoxMethods = new ListBox();
            listBoxEvents = new ListBox();
            listBoxProperties = new ListBox();
            SuspendLayout();
            // 
            // comboBoxTypes
            // 
            comboBoxTypes.FormattingEnabled = true;
            comboBoxTypes.Location = new Point(43, 35);
            comboBoxTypes.Name = "comboBoxTypes";
            comboBoxTypes.Size = new Size(649, 23);
            comboBoxTypes.TabIndex = 0;
            comboBoxTypes.SelectedIndexChanged += comboBoxTypes_SelectedIndexChanged;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(708, 35);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(75, 23);
            buttonSearch.TabIndex = 1;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // listBoxMethods
            // 
            listBoxMethods.FormattingEnabled = true;
            listBoxMethods.ItemHeight = 15;
            listBoxMethods.Location = new Point(46, 72);
            listBoxMethods.Name = "listBoxMethods";
            listBoxMethods.Size = new Size(217, 214);
            listBoxMethods.TabIndex = 2;
            // 
            // listBoxEvents
            // 
            listBoxEvents.FormattingEnabled = true;
            listBoxEvents.ItemHeight = 15;
            listBoxEvents.Location = new Point(278, 72);
            listBoxEvents.Name = "listBoxEvents";
            listBoxEvents.Size = new Size(217, 214);
            listBoxEvents.TabIndex = 3;
            // 
            // listBoxProperties
            // 
            listBoxProperties.FormattingEnabled = true;
            listBoxProperties.ItemHeight = 15;
            listBoxProperties.Location = new Point(515, 72);
            listBoxProperties.Name = "listBoxProperties";
            listBoxProperties.Size = new Size(217, 214);
            listBoxProperties.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 450);
            Controls.Add(listBoxProperties);
            Controls.Add(listBoxEvents);
            Controls.Add(listBoxMethods);
            Controls.Add(buttonSearch);
            Controls.Add(comboBoxTypes);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBoxTypes;
        private Button buttonSearch;
        private ListBox listBoxMethods;
        private ListBox listBoxEvents;
        private ListBox listBoxProperties;
    }
}
