using System;
using System.Threading;
using System.Windows.Forms;

namespace ThreadPriority
{
    public partial class Form1 : Form
    {
        Thread threadA, threadB, threadC, threadD;

        private void button1_Click(object sender, EventArgs e)
        {
            {
                label1.Text = "-Thread Starts-";

                threadA = new Thread(MyThreadClass.Thread1) { Name = "Thread A" };
                threadB = new Thread(MyThreadClass.Thread2) { Name = "Thread B" };
                threadC = new Thread(MyThreadClass.Thread1) { Name = "Thread C" };
                threadD = new Thread(MyThreadClass.Thread2) { Name = "Thread D" };


                threadA.Priority = System.Threading.ThreadPriority.Highest;
                threadB.Priority = System.Threading.ThreadPriority.Normal;
                threadC.Priority = System.Threading.ThreadPriority.AboveNormal;
                threadD.Priority = System.Threading.ThreadPriority.BelowNormal;


                threadA.Start();
                threadB.Start();
                threadC.Start();
                threadD.Start();


                threadA.Join();
                threadB.Join();
                threadC.Join();
                threadD.Join();


                label1.Text = "-End Of Threads-";
            }
        
        }
        public Form1()
        {
            InitializeComponent();
        }
    }
}


