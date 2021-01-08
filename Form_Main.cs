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
        private string Text1 = "COM1";
        public Form_Main()
        {
            InitializeComponent();

            this.Size = new Size(600, 800);
            checkBox1.Dock = DockStyle.Fill;
            checkBox1.BackColor = Color.FromArgb(255, 0, 0);

            textBox1.Enter += (s, e) => EnterTextBox();

            Debug(textBox1.GetType());
        }

        public void EnterTextBox()
        {

        }

        public void Debug(object text)
        {
            ToDebug.Text += $"{text}\n";
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            Debug(sender);
            Debug(e);
        }
    }
}
