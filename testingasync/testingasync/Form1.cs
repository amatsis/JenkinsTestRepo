using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestLib1;

namespace testingasync
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            callbigimportantmethod();
            label1.Text = "waiting....";
            //Task.Factory.StartNew(() => biglongimportantmethod("Sally")).ContinueWith(t => label1.Text = t.Result, TaskScheduler.FromCurrentSynchronizationContext());
        }
        private async void callbigimportantmethod()
        {
            var result = await BigLongImportantMethodAsync("Andrew");
            label1.Text = result;
        }

        private Task<string> BigLongImportantMethodAsync(string name)
        {
            return Task.Factory.StartNew(() => biglongimportantmethod(name));
        }

        private string biglongimportantmethod(string name)
        {
            Thread.Sleep(2000);
            return "Hello, " + name;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
