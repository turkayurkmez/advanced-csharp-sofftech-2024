using System.Dynamic;

namespace FormBagOnWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //dynamic formBag = new FormBag();
            //formBag.Name = "Türkay";
            //string name = formBag.Name;

            Form2 form2 = new Form2();
            form2.FormBag.Name = "Türkay";
            form2.FormBag.Days = new List<string> { "Pazartesi", "Çarşamba" };
            form2.FormBag.Age = 44;

            //form2.Show();
        }

        private void buttonGonder_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.FormBag.Image = pictureBox1.Image;
            form2.FormBag.Name = textBoxProductName.Text;
            form2.FormBag.Price = decimal.Parse(textBoxPrice.Text);
            ((IDictionary<string, object>)form2.FormBag).Add("Show", new Action<string>((info) => MessageBox.Show(info)));
            form2.Show();
        }
    }
}
