namespace EventsAndDelegates
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Common_click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Red;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        CategoryService categoryService = new CategoryService();
        private void Form1_Load(object sender, EventArgs e)
        {
            categoryService.CategoryCreated += CategoryService_CategoryCreated;

            categoryService.CreateNewCategory(new Category { Name ="Tekstil" });
          //  categoryService.CategoryCreated += CategoryService_CategoryCreated1;
        }

        //private void CategoryService_CategoryCreated1(object arg1, CategoryCreatedEventArgs arg2)
        //{
        //    throw new NotImplementedException();
        //}

        private void CategoryService_CategoryCreated(object sender, CategoryCreatedEventArgs e)
        {
            MessageBox.Show($"{e.Category.Name} isimli kategori, {e.User} tarafından {e.When.ToLongDateString()} tarihinde eklendi");
        }
    }
}
