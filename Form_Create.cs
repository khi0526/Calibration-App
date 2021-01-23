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
    public partial class Form_Create : Form
    {
        public bool[] Using { get; private set; }
        public bool Creating { get; private set; }

        public Form_Create(string fileName, int version, int usingSize, string[] DeviceNames)
        {
            InitializeComponent();

            this.ControlBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            StartPosition = FormStartPosition.CenterParent;
            this.Text = $"{fileName} Ver.{version + 1}";

            chkListBox_Device.Items.Clear();

            for (var i = 0; i < usingSize; i++)
            {
                chkListBox_Device.Items.Add(DeviceNames[i]);
                chkListBox_Device.SetItemChecked(i, true);
            }
            chkListBox_Device.SelectedIndexChanged += (s, e) => { Using[chkListBox_Device.SelectedIndex] = true; };

            Using = new bool[usingSize];
            Creating = false;
        }

        private void button_Apply_Click(object sender, EventArgs e)
        {
            for (var i = 0; i < chkListBox_Device.CheckedItems.Count; i++)
            {
                Using[chkListBox_Device.CheckedIndices[i]] = true;
            }
            
            Creating = true;
            Close();
        }

        private void button_Cancel_Click(object sender, EventArgs e) => Close();
    }
}
