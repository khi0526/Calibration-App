using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calibration
{
    partial class Form_Main : Form
    {
        private List<CheckBox> ConnectCheck = new List<CheckBox>();
        private List<TextBox> DeviceName = new List<TextBox>();
        private List<ComboBox> MacAddr = new List<ComboBox>();
        private List<ComboBox> Port = new List<ComboBox>();

        private void InitUI()
        {
            ConnectCheck.Add(checkBox_Connect1);
            ConnectCheck.Add(checkBox_Connect2);
            ConnectCheck.Add(checkBox_Connect3);
            ConnectCheck.Add(checkBox_Connect4);
            ConnectCheck.Add(checkBox_Connect5);
            ConnectCheck.Add(checkBox_Connect6);
            ConnectCheck.Add(checkBox_Connect7);
            ConnectCheck.Add(checkBox_Connect8);
            ConnectCheck.Add(checkBox_Connect9);
            ConnectCheck.Add(checkBox_Connect10);

            for (var i = 0; i < USER_SIZE; i++)
            {
                tableLayoutPanel2.Controls.Add(ConnectCheck[i], 0, i + 1);
                ConnectCheck[i].CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
                ConnectCheck[i].Dock = System.Windows.Forms.DockStyle.Fill;
                ConnectCheck[i].Location = new System.Drawing.Point(2, 32 + i * 30);
                ConnectCheck[i].Margin = new System.Windows.Forms.Padding(0);
                ConnectCheck[i].Name = $"checkBox_Connect{i + 1}";
                ConnectCheck[i].Size = new System.Drawing.Size(40, 30);
            }
        }
    }
}
