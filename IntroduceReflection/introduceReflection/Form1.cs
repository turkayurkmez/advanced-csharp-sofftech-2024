using System.Reflection;

namespace introduceReflection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var types = Assembly.GetAssembly(this.GetType()).GetTypes();
            foreach (var item in types)
            {
                comboBoxTypes.Items.Add(item.AssemblyQualifiedName);
            }

            var strTypes = typeof(string).Assembly.GetTypes();
            foreach (var type in strTypes)
            {
                comboBoxTypes.Items.Add(type.AssemblyQualifiedName);

            }
            comboBoxTypes.Items.Insert(0, typeof(Button).AssemblyQualifiedName);


        }

        private void comboBoxTypes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            clearListboxes();

            try
            {

                Type type = Type.GetType(comboBoxTypes.SelectedItem.ToString());
                if (type != null) { 

                    fillMethods(type);
                    fillProperties(type);
                    fillEvents(type);
                
                }
                else
                {
                    MessageBox.Show("Tip bulunamadı");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Tip anlaşılamadı");
            }
        }

        private void fillEvents(Type type)
        {
           type.GetEvents().ToList().ForEach(e => listBoxEvents.Items.Add(e.Name));
        }

        private void fillProperties(Type type)
        {
            type.GetProperties().ToList().ForEach(p=>listBoxProperties.Items.Add($"{p.Name}"));
        }

        private void fillMethods(Type type)
        {
            type.GetMethods().DistinctBy(t=>t.Name).ToList().ForEach(m=>listBoxMethods.Items.Add($"{m.Name}"));

        }

        private void clearListboxes()
        {
            foreach (var item in this.Controls)
            {
                if (item is ListBox)
                {
                    (item as ListBox).Items.Clear();
                }
            }
        }
    }
}
