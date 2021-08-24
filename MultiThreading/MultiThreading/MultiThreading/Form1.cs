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

namespace MultiThreading
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            SendMessageAsync();
            SendMessageAsync();
            // label1.Text =  await DoworkAsync();
        }

        private async Task<string> Dowork()
        {
            return await Task.Run(() =>
            {
                Thread.Sleep(10000);
                return "Hello Async ... ";
            });
        }

        private async Task<string> DoworkAsync()
        {
            return await Task.Run(() =>
            {
                Thread.Sleep(2000);
                MessageBox.Show("Hello Async");
                return "Hello Async ... ";
            });

        }

        public async Task SendMessageAsync()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(5000);
                MessageBox.Show("Send Message");
            });

        }
    }
}
