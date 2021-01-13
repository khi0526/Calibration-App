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
        //private Form_Create FormCreate;
        //private Form_Calibration FormCalibration;

        private UserInfo[] User;

        private const int TOTAL_SIZE = 10;

        private string FilePath;
        private string FileName;
        private int USING_SIZE;
        private int version;

        private bool connectButtonState = true;    // Button.Text = true : Connect, false : Disconnect
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

                User = new UserInfo[TOTAL_SIZE];
                for (var i = 0; i < TOTAL_SIZE; i++)
                {
                    User[i] = new UserInfo();
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
            version++;
            CreateClickUI();
        }

        private void ConnectCheck_ClickChanged(int index)
        {
            User[index].Connecting = !User[index].Connecting;
            ConnectCheckClickUI();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            bool flag = true;
            groupBox_FileData.Focus();

            for(var i = 0; i < USING_SIZE; i++)
            {
                if (Address[i].TextLength < 12)
                {
                    Address[i].Focus();
                    flag = false;
                    break;
                }
                if (Convertrate[i].Text == "")
                {
                    Convertrate[i].Focus();
                    flag = false;
                    break;
                }
            }

            if (flag)
            {
                for (var i = 0; i < USING_SIZE; i++)
                {
                    User[i].Name = DeviceName[i].Text;
                    User[i].Address = Address[i].Text;
                    User[i].Port = Port[i].Text;
                    User[i].Value = Convert.ToDouble(Convertrate[i].Text);
                }
                SaveClickUI();
            }
        }

        private void button_Connect_Click(object sender, EventArgs e)
        {
            if (connectButtonState)
            {
                ConnectStartUI();
                for(var i = 0; i < USING_SIZE; i++)
                {
                    if (ConnectCheck[i].Checked)
                        User[i].Connecting = true;
                }
                connectButtonState = false;
                distanceCheckIndex = 0;
                doseCheckIndex = 0;
                ConnectFinishUI();
            }
            else
            {
                DisconnectStartUI();
                for (var i = 0; i < USING_SIZE; i++)
                {
                    User[i].Connecting = false;
                }
                connectButtonState = true;
                DisconnectFinishUI();
            }
        }

        private void button_Apply_Click(object sender, EventArgs e)
        {
            User[0].Complete[0, 0] = true;
            for (var i = 0; i < USING_SIZE; i++)
            {
                if (User[i].Connecting)
                    if (User[i].Complete[distanceCheckIndex, doseCheckIndex])
                    {
                        string msg = "This environment has already been calibrated.\nDo you want to recalibrate?";
                        if (MessageBox.Show(msg,"Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            ApplyClickUI();
                        break;
                    }
            }
            
        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            CalibrationStartUI();
            //FormStart = new Form_Start();
            //FormStart.ShowDialog();
            for (var i = 0; i < USING_SIZE; i++)
            {
                if (User[i].Connecting)
                {

                    User[i].Complete[distanceCheckIndex, doseCheckIndex] = true;
                }
            }
            CalibrationFinishUI();
        }
    }
}
