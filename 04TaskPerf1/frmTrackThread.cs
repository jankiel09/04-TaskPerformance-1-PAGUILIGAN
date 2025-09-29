using System.Diagnostics;

namespace _04TaskPerf1
{
    public partial class frmTrackThread : Form
    {
        private Thread ThreadA;
        private Thread ThreadB;
        private Thread ThreadC;
        private Thread ThreadD;

        public frmTrackThread()
        {
            InitializeComponent();

            ThreadA = new Thread(threadA);
            ThreadB = new Thread(threadB);
            ThreadC = new Thread(threadC);
            ThreadD = new Thread(threadD);

            ThreadA.Priority = ThreadPriority.Highest;
            ThreadB.Priority = ThreadPriority.Normal;
            ThreadC.Priority = ThreadPriority.AboveNormal;
            ThreadD.Priority = ThreadPriority.BelowNormal;

        }
        // 
        private void threadA() { }
        private void threadB() { }
        private void threadC() { }
        private void threadD() { }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}