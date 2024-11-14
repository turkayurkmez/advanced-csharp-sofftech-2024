using System.Threading;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ThreadBasics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        Thread thread;
        private void button1_Click(object sender, EventArgs e)
        {

            List<string> strings = new List<string>() { "a", "b" };



            thread = new Thread(new ParameterizedThreadStart(counter));
            thread.Start(10000);
            thread.Join();
            MessageBox.Show("İşlem tamamlandı");


        }
        Task t;
        private async void button3_Click(object sender, EventArgs e)
        {
            t = Task.Run(countWithTask);

          
            await t;
            MessageBox.Show("bitti");
        }

        void counter(object number)
        {
            for (int i = 0; i <= (int)number; i++)
            {
                label1.Text = i.ToString();
                progressBar1.Value = i / 100;
            }
        }

        Task countWithTask()
        {

            for (int i = 0; i <= 10000; i++)
            {
                label2.Text = i.ToString();
                progressBar2.Value = i / 100;
            }

            return Task.CompletedTask;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Naber?");
        }
        CancellationTokenSource tokenSource2 = new CancellationTokenSource();
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            tokenSource2.Cancel();
            // thread = null;
        
        }


    }
}
