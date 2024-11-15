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

            MessageBox.Show("İşlem tamamlandı");


        }
        Task t;
        CancellationTokenSource cancellationTokenSource = new CancellationTokenSource(TimeSpan.FromSeconds(10));
        private async void button3_Click(object sender, EventArgs e)
        {
            var token = cancellationTokenSource.Token;
            // try
            // {
            await Task.Run(() => countWithTask(token), token);



            //}
            // catch (OperationCanceledException)
            // {

            // MessageBox.Show("askenkron task iptal edildi");
            // }        


            // await t;
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

        async Task countWithTask(CancellationToken token)
        {

            for (int i = 0; i <= 10000; i++)
            {
                //try
                //{
                //    token.ThrowIfCancellationRequested();
                //}
                //catch (OperationCanceledException)
                //{

                //    MessageBox.Show("İşlem iptal edildi");
                //    return Task.CompletedTask;
                //}

                if (token.IsCancellationRequested)
                {
                    MessageBox.Show("İşlem iptal edildi");
                    return;

                }

                label2.Text = i.ToString();
                progressBar2.Value = i / 100;

            }



            // return Task.CompletedTask;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Naber?");
        }
        CancellationTokenSource tokenSource2 = new CancellationTokenSource();
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // tokenSource2.Cancel();
            // thread = null;
            cancellationTokenSource.Cancel(true);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            cancellationTokenSource.Cancel(true);
        }

        private async void button5_Click(object sender, EventArgs e)
        {
            string htmlOutput = await GetHtmlResponseFromUrl("https://jsonplaceholder.typicode.com/todos/1");
           
            richTextBox1.Text = htmlOutput;
        }

        async Task<string> GetHtmlResponseFromUrl(string url)
        {
            using HttpClient client = new HttpClient();
            HttpResponseMessage httpResponse = await client.GetAsync(url);
            httpResponse.EnsureSuccessStatusCode();

            return await httpResponse.Content.ReadAsStringAsync();

        }
    }
}
