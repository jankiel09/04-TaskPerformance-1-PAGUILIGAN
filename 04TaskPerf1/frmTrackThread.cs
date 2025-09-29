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
            // greyed out the run button to isolate the process. prevent multiple clicks.
            btnStart.Enabled = false;
            lblStatus.Text = "-Thread Starts-";

            Debug.WriteLine("-Thread Starts-");
            System.Diagnostics.Trace.WriteLine("-Thread Starts-");

            ThreadStart threadStart1 = new ThreadStart(MyThreadClass.Thread1);
            ThreadStart threadStart2 = new ThreadStart(MyThreadClass.Thread2);
            ThreadStart threadStart3 = new ThreadStart(MyThreadClass.Thread1);
            ThreadStart threadStart4 = new ThreadStart(MyThreadClass.Thread2);


            // create 4 threads named ThreadA and ThreadB
            ThreadA = new Thread(threadStart1);
            ThreadB = new Thread(threadStart2);
            ThreadC = new Thread(threadStart3);
            ThreadD = new Thread(threadStart4);

            // set thread names
            ThreadA.Name = "ThreadA";
            ThreadB.Name = "ThreadB";
            ThreadC.Name = "ThreadC";
            ThreadD.Name = "ThreadD";

            Console.WriteLine("Starting ThreadA, ThreadB, ThreadC, ThreadD");
            Console.WriteLine("================================");

            ThreadA.Start();
            ThreadB.Start();
            ThreadC.Start();
            ThreadD.Start();

            ThreadA.Join();
            ThreadB.Join();
            ThreadC.Join();
            ThreadD.Join();

            string endMessage = "-End of Thread-";
            Debug.WriteLine(endMessage);
            System.Diagnostics.Trace.WriteLine(endMessage);
            Console.WriteLine(endMessage);

            Console.WriteLine("================================");
            Console.WriteLine("Both threads have completed.");

            // update the label to show threads have ended
            lblStatus.Text = "-End Of Thread-";
            btnStart.Enabled = true; // un-grey the run button.
        }
    }
}