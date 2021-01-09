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
            InitUI();

            this.Size = new Size(469, 693);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;

            User = new UserInfo[USER_SIZE];
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {

        }

    }
}
