using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calibration
{
    public partial class Form_Main : Form
    {
        private Form_New FormNew;
        //private Form_Open FormOpen;
        private Form_Create FormCreate;
        private Form_Start FormStart;

        private DeviceInfo[] Device;

        private const int TOTAL_SIZE = 10;

        private string FilePath;
        private string FileName;
        private int USING_SIZE;
        private int version;

        private readonly List<int> connectingDeviceIndex = new List<int>();
        private int distanceCheckIndex = -1;
        private int doseCheckIndex = -1;


        public Form_Main()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            InitUI();
        }

        private void ToolStripMenuItem_File_New_Click(object sender, EventArgs e)
        {
            FormNew = new Form_New();
            FormNew.ShowDialog();

            if (FormNew.Making)
            {
                version = 1;
                FilePath = FormNew.FilePath;
                FileName = FormNew.FileName;
                USING_SIZE = FormNew.SIZE;

                Device = new DeviceInfo[TOTAL_SIZE];
                for (var i = 0; i < TOTAL_SIZE; i++)
                {
                    Device[i] = new DeviceInfo();
                    if (i < USING_SIZE)
                        Device[i].Using = true;
                }
                NewFileUI();
            }
        }

        private void ToolStripMenuItem_File_Open_Click(object sender, EventArgs e)
        {
            /*
            FromOpen = new Form_Open();
            FormNew.ShowDialog();

            if (FormOpen.Opning)
            {
                version = FormOpen.Version;
                FilePath = FormOpen.FilePath;
                FileName = FormOpen.FileName;
                USING_SIZE = FormOpen.SIZE;
            }
            */
        }

        private void button_Create_Click(object sender, EventArgs e)
        {
            string[] DeviceNames = new string[USING_SIZE];
            for (var i = 0; i < USING_SIZE; i++)
                DeviceNames[i] = Device[i].Name;

            FormCreate = new Form_Create(FileName, version, USING_SIZE, DeviceNames);
            FormCreate.ShowDialog();

            if (FormCreate.Creating)
            {
                version++;
                CreateClickUI();
            }
        }

        private void ConnectCheck_ClickChanged(int index)
        {
            Device[index].Connecting = !Device[index].Connecting;
            ConnectCheckClickUI();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            bool isDone = true;
            groupBox_FileData.Focus();

            switch (button_Save.Text)
            {
                case "Save":
                    {
                        for (var i = 0; i < USING_SIZE; i++)
                        {
                            if (!Address[i].MaskFull || Address[i].Text == "AA:BB:CC:DD:EE:FF")
                            {
                                Address[i].Focus();
                                isDone = false;
                                break;
                            }
                            if (Convertrate[i].Text == "")
                            {
                                Convertrate[i].Focus();
                                isDone = false;
                                break;
                            }
                        }

                        if (isDone)
                        {
                            for (var i = 0; i < USING_SIZE; i++)
                            {
                                Device[i].Name = DeviceName[i].Text;
                                Device[i].Address = Address[i].Text;
                                Device[i].Port = Port[i].Text;
                                Device[i].Value = Convert.ToDouble(Convertrate[i].Text);
                            }
                            SaveClickUI();
                        }
                        break;
                    }
                case "Edit":
                    {
                        EditClickUI();
                        break;
                    }
            }
        }

        private void button_Connect_Click(object sender, EventArgs e)
        {
            switch (button_Connect.Text)
            {
                case "Connect":
                    {
                        ConnectStartUI();
                        for (var i = 0; i < USING_SIZE; i++)
                        {
                            if (ConnectCheck[i].Checked)
                            {
                                connectingDeviceIndex.Add(i);
                                Device[i].Connecting = true;
                            }
                        }
                        distanceCheckIndex = 0;
                        doseCheckIndex = 0;
                        ConnectFinishUI();
                        break;
                    }
                case "Disconnect":
                    {
                        DisconnectStartUI();
                        for (var i = 0; i < USING_SIZE; i++)
                        {
                            connectingDeviceIndex.Clear();
                            Device[i].Connecting = false;
                        }
                        DisconnectFinishUI();
                        break;
                    }
            }
        }

        private void button_Apply_Click(object sender, EventArgs e)
        {
            for (var i = 0; i < connectingDeviceIndex.Count; i++)
            {
                if (Device[connectingDeviceIndex[i]].Complete[distanceCheckIndex, doseCheckIndex])
                {
                    string msg = $"{Device[i].Name} has already been measured\nin the selected environment.\nDo you want to recalibrate?";
                    if (MessageBox.Show(msg, "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        return;
                    break;
                }
            }
            
            ApplyClickUI();
        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            CalibrationStartUI();
            FormStart = new Form_Start();
            FormStart.ShowDialog();

            string startTime = FormStart.StartTime;
            string finishTime = FormStart.FinishTime;
            if (FormStart.IsComplete)
            {
                for (var i = 0; i < USING_SIZE; i++)
                {
                    if (Device[i].Connecting)
                    {
                        Device[i].Complete[distanceCheckIndex, doseCheckIndex] = true;
                    }
                }
                CalibrationFinishUI();
            }
        }
    }
}
