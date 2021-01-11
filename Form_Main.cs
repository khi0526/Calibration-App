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

        public static string filePath;
        public static string fileName;
        public static int usingDevices;
        private int version;

        private int distanceCheckIndex = -1;
        private int doseCheckIndex = -1;

        private bool connectButtonState = true;    // Button.Text = true : Connect, false : Disconnect

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

        private void ValueTextChanged(int index)
        {
            User[index].Value = Convert.ToDouble(Value[index].Text);
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            bool flag = true;

            for(var i = 0; i < usingDevices; i++)
            {
                if (User[i].Address.Length < 12)
                {
                    Address[i].Focus();
                    flag = false;
                    break;
                }
                if (User[i].Value == 0)
                {
                    Value[i].Focus();
                    flag = false;
                    break;
                }
            }

            if (flag)
            {
                for (var i = 0; i < usingDevices; i++)
                {
                    if (User[i].Name == "")
                        User[i].Name = $"Device{i + 1}";
                }
                SaveClickUI();
            }
        }

        private void button_Connect_Click(object sender, EventArgs e)
        {
            if (connectButtonState)
            {
                connectButtonState = false;
                ConnectStartUI();
                for(var i = 0; i < usingDevices; i++)
                {
                    if (ConnectCheck[i].Checked)
                        User[i].Connecting = true;
                }
                ConnectFinishUI();
            }
            else
            {
                connectButtonState = true;
                DisconnectStartUI();
                for (var i = 0; i < usingDevices; i++)
                {
                    User[i].Connecting = false;
                }
                DisconnectFinishUI();
            }
        }

        private void button_Apply_Click(object sender, EventArgs e)
        {
            ApplyClickUI();
        }

        private void button_Start_Click(object sender, EventArgs e)
        {

        }
    }
}
