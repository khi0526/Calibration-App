using System;
using System.Threading;
using System.Windows.Forms;

namespace Calibration
{
    public partial class Form_Start : Form
    {
        private readonly System.Threading.Timer stabilizeTimer;
        private readonly System.Threading.Timer secondTimer;

        public int[] CPS { get; private set; }

        public readonly string StartTime;
        public string FinishTime { get; private set; }

        public bool IsComplete { get; private set; }
        private bool IsCalibrate;
        private int secondCount;
        private int recordCount;

        public Form_Start()
        {
            InitializeComponent();
            Text = "Waiting for 10 seconds to stabilize...";
            StartTime = $"{DateTime.Now:HH:mm:ss}";

            label_Device1CPS.Text = "0";
            label_Device2CPS.Text = "0";
            label_Time.Text = "";

            IsComplete = false;
            IsCalibrate = false;
            secondCount = 0;
            recordCount = 0;
            stabilizeTimer = new System.Threading.Timer(StabilizeTimer);
            secondTimer = new System.Threading.Timer(SecondTimer);
        }

        private void Form_Start_Shown(object sender, EventArgs e)
        {
            stabilizeTimer.Change(9985, -1);
            secondTimer.Change(985, 985);
        }

        private void StabilizeTimer(object Context)
        {
            Text = "Calibrating...";
            Thread.Sleep(10);
            IsCalibrate = true;
            stabilizeTimer.Dispose();
        }

        private void UpdateDelegate(MethodInvoker method)
        {
            if (InvokeRequired)
                method.Invoke();
            else
                BeginInvoke(method);
        }

        private void SecondTimer(object Context)
        {
            progressBar.PerformStep();
            FinishTime = DateTime.Now.ToString("HH:mm:ss");
            label_Time.Text = $"{StartTime} ~ {FinishTime}";
            
            secondCount++;
            label_Device1CPS.Text = secondCount.ToString();
            if(secondCount == 10)
            {
                secondCount = 0;
                if (IsCalibrate)
                {
                    recordCount++;
                    label_Device2CPS.Text = recordCount.ToString();
                    if (recordCount == 10)
                    {
                        IsComplete = true;
                        secondTimer.Dispose();
                        Close();
                    }
                }
            }
        }

        private void DataRecieved()
        {
            int cps = 0;
            CPS[recordCount] += cps;
        }

        private void Button_Abort_Click(object sender, EventArgs e)
        {
            CPS = null;
            secondTimer.Dispose();
            Close();
        }

    }
}
