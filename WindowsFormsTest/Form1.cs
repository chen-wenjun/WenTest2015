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

namespace WindowsFormsTest
{
    public partial class Form1 : Form
    {
        private string _name = "my name";
        public Form1()
        {
            InitializeComponent();
        }

        private void DoTimeConsumingWorkBtn_Click(object sender, EventArgs e)
        {
            DoingWork work = new DoingWork($"this is input data:{DateTime.Now.ToLongTimeString()}", 
                data =>
                {
                    _name = data;
                    //MessageBox.Show(data);
                    //if(listBox1.InvokeRequired)
                    //listBox1.Invoke(new Action<string>((d) => listBox1.Items.Add(d)), new object[] { data });
                    //listBox1.Invoke(new Action<string>((d) => listBox1.Items.Add(d)), data);
                    this.BeginInvoke(new Action<string>(
                        (d) => { listBox1.Items.Add(d); timeLbl.Text = d; }
                        ), data);



                    //listBox1.Items.Add(data);
                });

            Thread thread1 = new Thread(work.DoWork);
            thread1.Start();

        }

        private void DoWork()
        {
            Thread.Sleep(5000);
            MessageBox.Show($"sleep done {_name}");
        }

        public delegate void CallBack(string data);
        public class DoingWork
        {
            private CallBack _callback;
            private string _input;

            public DoingWork(string input, CallBack callback)
            {
                _input = input;
                _callback = callback;
            }

            public void DoWork()
            {
                
                Thread.Sleep(5000);
                if(_callback != null)
                {
                    _callback($"data from callback {_input}");
                }
            }
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_name);
        }

        private void asyncBtn_Click(object sender, EventArgs e)
        {
            AsyncProcess();
        }

        private async void AsyncProcess()
        {
            Thread.Sleep(5000);
        }
    }
}
