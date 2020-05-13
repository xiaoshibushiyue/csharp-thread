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

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //会卡UI
            Task task = new Task(() =>
            {
                try
                {
                    Thread.Sleep(1000 * 10);
                    label1.Text = "你好";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            });

            ////下面这个语句可以跨线程更新UI
            //task.Start(TaskScheduler.FromCurrentSynchronizationContext());
            var task1 = Task.Factory.StartNew(() =>
            {
                //默认耗时操作
                Thread.Sleep(1000 * 10);
            });

            task1.ContinueWith(t =>
            {
                label1.Text = "你好";
            }, TaskScheduler.FromCurrentSynchronizationContext());
        }
    }
}
