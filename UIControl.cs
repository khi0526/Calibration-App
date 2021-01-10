using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Calibration
{
    partial class Form_Main : Form
    {
        private List<CheckBox> ConnectCheck = new List<CheckBox>();
        private List<TextBox> DeviceName = new List<TextBox>();
        private List<TextBox> Address = new List<TextBox>();
        private List<ComboBox> Port = new List<ComboBox>();
        private List<TextBox> Value = new List<TextBox>();

        private bool ConnectCheckEnable = true;

        private void InitUI()
        {
            /////////////////////////////////////////////////////////////////////////////
            // Main Form
            /////////////////////////////////////////////////////////////////////////////
            Size = new Size(520, 700);
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            /////////////////////////////////////////////////////////////////////////////
            // GroupBoxs
            /////////////////////////////////////////////////////////////////////////////
            groupBox_FileData.Enabled = false;
            groupBox_Config.Enabled = false;
            /////////////////////////////////////////////////////////////////////////////
            // Labels
            /////////////////////////////////////////////////////////////////////////////
            label_FileName.Text = "File Name :";
            label_Use.Dock = DockStyle.Fill;
            label_DeviceName.Dock = DockStyle.Fill;
            label_Address.Dock = DockStyle.Fill;
            label_Port.Dock = DockStyle.Fill;
            label_Value.Dock = DockStyle.Fill;
            /////////////////////////////////////////////////////////////////////////////
            // Buttons
            /////////////////////////////////////////////////////////////////////////////
            button_Create.Text = "Create New Ver.";
            button_Create.Enabled = false;
            button_Save.Text = "Save";
            button_Connect.Text = "Connect";
            button_Connect.Enabled = false;
            button_Apply.Text = "Apply";
            button_Start.Text = "Calibration Start";
            button_Start.Enabled = false;
            /////////////////////////////////////////////////////////////////////////////
            // Connect CheckBox
            /////////////////////////////////////////////////////////////////////////////
            ConnectCheck.Add(checkBox_Use1);
            ConnectCheck.Add(checkBox_Use2);
            ConnectCheck.Add(checkBox_Use3);
            ConnectCheck.Add(checkBox_Use4);
            ConnectCheck.Add(checkBox_Use5);
            ConnectCheck.Add(checkBox_Use6);
            ConnectCheck.Add(checkBox_Use7);
            ConnectCheck.Add(checkBox_Use8);
            ConnectCheck.Add(checkBox_Use9);
            ConnectCheck.Add(checkBox_Use10);

            for (var i = 0; i < USER_SIZE; i++)
            {
                ConnectCheck[i].CheckAlign = ContentAlignment.MiddleCenter;
                ConnectCheck[i].CheckedChanged += ConnectCheck_ClickChanged;
                ConnectCheck[i].Dock = DockStyle.Fill;
                ConnectCheck[i].Enabled = false;
            }
            /////////////////////////////////////////////////////////////////////////////
            // DeviceName TextBox
            /////////////////////////////////////////////////////////////////////////////
            DeviceName.Add(textBox_DeviceName1);
            DeviceName.Add(textBox_DeviceName2);
            DeviceName.Add(textBox_DeviceName3);
            DeviceName.Add(textBox_DeviceName4);
            DeviceName.Add(textBox_DeviceName5);
            DeviceName.Add(textBox_DeviceName6);
            DeviceName.Add(textBox_DeviceName7);
            DeviceName.Add(textBox_DeviceName8);
            DeviceName.Add(textBox_DeviceName9);
            DeviceName.Add(textBox_DeviceName10);

            for (var i = 0; i < USER_SIZE; i++)
            {
                DeviceName[i].Dock = DockStyle.Fill;
                DeviceName[i].ForeColor = SystemColors.ScrollBar;
                DeviceName[i].Text = "";
                //DeviceName[i].Enabled = false;
            }

            DeviceName[0].Enter += (s, e) => DeviceNameEnter(0);
            DeviceName[1].Enter += (s, e) => DeviceNameEnter(1);
            DeviceName[2].Enter += (s, e) => DeviceNameEnter(2);
            DeviceName[3].Enter += (s, e) => DeviceNameEnter(3);
            DeviceName[4].Enter += (s, e) => DeviceNameEnter(4);
            DeviceName[5].Enter += (s, e) => DeviceNameEnter(5);
            DeviceName[6].Enter += (s, e) => DeviceNameEnter(6);
            DeviceName[7].Enter += (s, e) => DeviceNameEnter(7);
            DeviceName[8].Enter += (s, e) => DeviceNameEnter(8);
            DeviceName[9].Enter += (s, e) => DeviceNameEnter(9);

            DeviceName[0].Leave += (s, e) => DeviceNameLeave(0);
            DeviceName[1].Leave += (s, e) => DeviceNameLeave(1);
            DeviceName[2].Leave += (s, e) => DeviceNameLeave(2);
            DeviceName[3].Leave += (s, e) => DeviceNameLeave(3);
            DeviceName[4].Leave += (s, e) => DeviceNameLeave(4);
            DeviceName[5].Leave += (s, e) => DeviceNameLeave(5);
            DeviceName[6].Leave += (s, e) => DeviceNameLeave(6);
            DeviceName[7].Leave += (s, e) => DeviceNameLeave(7);
            DeviceName[8].Leave += (s, e) => DeviceNameLeave(8);
            DeviceName[9].Leave += (s, e) => DeviceNameLeave(9);
            /////////////////////////////////////////////////////////////////////////////
            // MacAddress TextBox
            /////////////////////////////////////////////////////////////////////////////
            Address.Add(textBox1);
            Address.Add(textBox2);
            Address.Add(textBox3);
            Address.Add(textBox4);
            Address.Add(textBox5);
            Address.Add(textBox6);
            Address.Add(textBox7);
            Address.Add(textBox8);
            Address.Add(textBox9);
            Address.Add(textBox10);

            for (var i = 0; i < USER_SIZE; i++)
            {
                Address[i].Dock = DockStyle.Fill;
                Address[i].Name = $"textBox_Address{i}";    //임시
                Address[i].Text = "";
                //Address[i].Enabled = false;
            }
            /////////////////////////////////////////////////////////////////////////////
            // Port ComboBox
            /////////////////////////////////////////////////////////////////////////////
            Port.Add(comboBox_Port1);
            Port.Add(comboBox_Port2);
            Port.Add(comboBox_Port3);
            Port.Add(comboBox_Port4);
            Port.Add(comboBox_Port5);
            Port.Add(comboBox_Port6);
            Port.Add(comboBox_Port7);
            Port.Add(comboBox_Port8);
            Port.Add(comboBox_Port9);
            Port.Add(comboBox_Port10);

            for (var i = 0; i < USER_SIZE; i++)
            {
                Port[i].Dock = DockStyle.Fill;
                Port[i].DropDownStyle = ComboBoxStyle.DropDownList;
                Port[i].Text = "";
                //Port[i].Enabled = false;
            }
            /////////////////////////////////////////////////////////////////////////////
            // CalibrationValue TextBox
            /////////////////////////////////////////////////////////////////////////////
            Value.Add(textBox_Value1);
            Value.Add(textBox_Value2);
            Value.Add(textBox_Value3);
            Value.Add(textBox_Value4);
            Value.Add(textBox_Value5);
            Value.Add(textBox_Value6);
            Value.Add(textBox_Value7);
            Value.Add(textBox_Value8);
            Value.Add(textBox_Value9);
            Value.Add(textBox_Value10);

            for (var i = 0; i < USER_SIZE; i++)
            {
                Value[i].Dock = DockStyle.Fill;
                Value[i].Text = "";
                Value[i].TextAlign = HorizontalAlignment.Right;
            }
        }

        private void NewFileUI()
        {
            groupBox_FileData.Focus();

            groupBox_FileData.Enabled = true;
            button_Save.Enabled = true;

            for (var i = 0; i < USER_SIZE; i++)
            {
                ConnectCheck[i].Checked = false;
                ConnectCheck[i].Enabled = false;
                DeviceName[i].Enabled = true;
                DeviceName[i].ForeColor = SystemColors.ScrollBar;
                DeviceName[i].ReadOnly = false;
                DeviceName[i].Text = "Device";
                Address[i].Enabled = true;
                Address[i].ReadOnly = false;
                Address[i].Text = "";
                Port[i].Enabled = true;
                Port[i].Text = "";
                Value[i].Enabled = true;
                Value[i].ReadOnly = false;
                Value[i].Text = "";
            }
        }

        private void CreateClickUI()
        {
            for (var i = 0; i < USER_SIZE; i++)
            {
                if (User[i].Name == "")
                    continue;

                Value[i].ReadOnly = false;
            }
        }

        private void DeviceNameEnter(int index)
        {
            if (User[index].Name == "")
            {
                DeviceName[index].ForeColor = SystemColors.ControlText;
                DeviceName[index].Text = "";
            }
        }

        private void DeviceNameLeave(int index)
        {
            User[index].Name = DeviceName[index].Text;

            if (DeviceName[index].TextLength == 0)
            {
                DeviceName[index].ForeColor = SystemColors.ScrollBar;
                DeviceName[index].Text = "Device";
            }
        }

        private void SaveClickUI()
        {
            //this.ActiveControl = groupBox_FileData;
            //Address[9].Focus();

            for (var i = 0; i < USER_SIZE; i++)
            {
                if (User[i].Name == "")
                {
                    DeviceName[i].Text = "";
                    Address[i].Text = "";
                    Port[i].Text = "";
                    Value[i].Text = "";
                }
                else
                {
                    ConnectCheck[i].Enabled = true;
                    DeviceName[i].ReadOnly = true;
                    Address[i].ReadOnly = true;
                    Value[i].ReadOnly = true;
                }
            }

            button_Save.Enabled = false;
            button_Create.Enabled = true;
        }

        private void ConnectCheck_ClickChanged(object sender, EventArgs e)
        {
            if (!ConnectCheckEnable)
            {
                for (var i = 0; i < USER_SIZE; i++)
                {
                    if (!User[i].Using)
                        continue;
                    ConnectCheck[i].Enabled = true;
                }
                ConnectCheckEnable = true;
            }
            else
            {
                int Check = 0;


                for (var i = 0; i < USER_SIZE; i++)
                {
                    if (ConnectCheck[i].Checked)
                    {
                        Check++;

                        if (Check == 2)
                        {
                            for (var j = 0; j < USER_SIZE; j++)
                                if (!ConnectCheck[j].Checked)
                                    ConnectCheck[j].Enabled = false;
                            ConnectCheckEnable = false;
                            break;
                        }
                    }
                }

                if (Check == 0)
                    button_Connect.Enabled = false;
                else
                    button_Connect.Enabled = true;
            }
        }

    }
}
