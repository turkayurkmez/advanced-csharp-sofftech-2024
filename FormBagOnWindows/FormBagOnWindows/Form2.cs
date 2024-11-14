using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormBagOnWindows
{
    public partial class Form2 : Form, IAttachFormBag
    {
        public Form2()
        {
            InitializeComponent();
        }

        public dynamic FormBag { get; set; } = new ExpandoObject();

        private void Form2_Load(object sender, EventArgs e)
        {
            //Label labelName = new Label() { Top = 10, Left=10};
            //labelName.Text = FormBag.Name;

            //ListBox listBox = new ListBox() { Top= 50,Left =10 };
            //foreach (dynamic day in FormBag.Days)
            //{
            //    listBox.Items.Add(day);
            //};

            //Label labelAge = new Label() { Top=listBox.Height+50, Left=10};
            //labelAge.Text = FormBag.Age.ToString();


            //Controls.Add(labelName);
            //this.Controls.Add(labelAge);
            //this.Controls.Add(listBox);

            pictureBox1.Image = FormBag.Image;
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            label1.Text = FormBag.Name;
            label2.Text = FormBag.Price.ToString("C2");
            FormBag.Show(label1.Text);
        }
    }
}
