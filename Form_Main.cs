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
        private const int USER_SIZE = 10;

        private UserInfo[] User;


        public Form_Main()
        {
            InitializeComponent();
            Init();

            User = new UserInfo[USER_SIZE];
            for(var i = 0; i < USER_SIZE; i++)
            {
                User[i] = new UserInfo();
            }
        }

        public void Test()
        {
            for (var i = 0; i < 3; i++)
            {
                DeviceName[i].Enter += (s, e) => DeviceNameEnter(i);
                DeviceName[i].Leave += (s, e) => DeviceNameLeave(i);
            }
        }

        private void Init()
        {
            InitUI();
        }

        private void ToolStripMenuItem_File_New_Click(object sender, EventArgs e)
        {
            NewFileUI();
        }

        private void button_Create_Click(object sender, EventArgs e)
        {

        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            SaveClickUI();
        }

        private void button_Connect_Click(object sender, EventArgs e)
        {

        }
    }
}
