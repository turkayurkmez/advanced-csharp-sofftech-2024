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
                addMenuItemForPlugs(plugs);
            }
        }

        private void addMenuItemForPlugs(List<Plug> plugs)
        {
            plugs.ForEach(p =>
            {
                ToolStripMenuItem menuItem = new ToolStripMenuItem(p.Name);
                pluginsToolStripMenuItem.DropDownItems.Add(menuItem);
                menuItem.Click += MenuItem_Click;
                loadedPlugins.Add(p.Name, p);
            });
        }

        Dictionary<string, Plug> loadedPlugins = new Dictionary<string, Plug>();
        private void MenuItem_Click(object? sender, EventArgs e)
        {
            string name = (sender as ToolStripMenuItem).Text;

            int x = (int)numericUpDownX.Value;
            int y = (int)numericUpDownY.Value;
            int width = (int)numericUpDownWith.Value;
            int height = (int)numericUpDownHeight.Value;

            Plug plug = loadedPlugins[name];
            var plugin = PluginHelper.CreateInstance(plug);
            plugin.Draw(splitContainer1.Panel2.CreateGraphics(), new SolidBrush(buttonSelectColor.BackColor), x, y, width, height);

        }

        private void buttonSelectColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                buttonSelectColor.BackColor = colorDialog.Color;
            }
        }
    }
}
