using Display.SDK;

namespace Display.Main
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pluginEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.SelectedPath = Environment.CurrentDirectory;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                //seçilen klasör içerisinde varsa bu uygulama için yazılmış olan puginleri oku ve menüye ekle.
                var plugs = PluginHelper.GetPlugins(dialog.SelectedPath);
                //1. Menüye ekleyeceksiniz. -> İsim
                //2. Referans ekleyeceksiniz -> Tam adres
                //3. Instance alıp kullanacaksınız -> FullName

            }
        }
    }
}
