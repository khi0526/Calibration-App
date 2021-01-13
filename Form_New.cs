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
    public partial class Form_New : Form
    {
        public string FileDirectory { get; private set; }
        public string FilePath { get; private set; }
        public string FileName { get; private set; }
        public int SIZE { get; private set; }
        public bool Making { get; private set; }

        public Form_New()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            this.ControlBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            StartPosition = FormStartPosition.CenterParent;

            label_Name.Text = "File Name : " + DateTime.Now.ToString("yyyy-MM-dd");

            textBox_Name.Enter += NameEnter;
            textBox_Name.Leave += NameLeave;

            numericUpDown_Devices.Value = 1;
            numericUpDown_Devices.Minimum = 1;
            numericUpDown_Devices.Maximum = 10;

            Making = false;
        }

        private void NameEnter(object sender, EventArgs e)
        {
            if (textBox_Name.Text == "Calibration")
            {
                textBox_Name.ForeColor = SystemColors.ControlText;
                textBox_Name.Text = "";
            }
        }

        private void NameLeave(object sender, EventArgs e)
        {
            if (textBox_Name.Text == "")
            {
                textBox_Name.ForeColor = SystemColors.ScrollBar;
                textBox_Name.Text = "Calibration";
            }
        }

        private void button_Make_Click(object sender, EventArgs e)
        {
            string time = DateTime.Now.ToString("yyyy-MM-dd");

            FileDirectory = $"./File/{time} {textBox_Name.Text}/";
            FilePath = $"{FileDirectory}{textBox_Name.Text} Ver.1";
            FileName = $"{time} {textBox_Name.Text}";
            SIZE = (int)numericUpDown_Devices.Value;

            Making = true;
            this.Hide();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
