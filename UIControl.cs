using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Calibration
{
    partial class Form_Main : Form
    {
        private readonly List<CheckBox> ConnectCheck = new List<CheckBox>();
        private readonly List<TextBox> DeviceName = new List<TextBox>();
        private readonly List<MaskedTextBox> Address = new List<MaskedTextBox>();
        private readonly List<ComboBox> Port = new List<ComboBox>();
        private readonly List<TextBox> Value = new List<TextBox>();
        private readonly List<RadioButton> Distance = new List<RadioButton>();
        private readonly List<RadioButton> Dose = new List<RadioButton>();

        private readonly string[] DistanceText = new string[3] { "3cm", "4cm", "5cm" };
        private readonly string[] DoseText = new string[3] { "10μCi", "34μCi", "51μCi" };

        private bool connectCheckEnable = true;

        private void InitUI()
        {
            /////////////////////////////////////////////////////////////////////////////
            // Main Form
            /////////////////////////////////////////////////////////////////////////////
            Size = new Size(520, 700);
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            /////////////////////////////////////////////////////////////////////////////
            // GroupBoxs
            /////////////////////////////////////////////////////////////////////////////
            groupBox_FileData.Enabled = false;
            groupBox_Config.Enabled = false;
            /////////////////////////////////////////////////////////////////////////////
            // Labels
            /////////////////////////////////////////////////////////////////////////////
            label_FileName.Text = "File Name :";
            linkLabel_FileName.Text = "";
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
            button_Apply.Enabled = false;
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

            for (var i = 0; i < TOTAL_SIZE; i++)
            {
                ConnectCheck[i].CheckAlign = ContentAlignment.MiddleCenter;
                ConnectCheck[i].Dock = DockStyle.Fill;
                ConnectCheck[i].Enabled = false;
            }

            ConnectCheck[0].CheckedChanged += (s, e) => ConnectCheck_ClickChanged(0);
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

            for (var i = 0; i < TOTAL_SIZE; i++)
            {
                DeviceName[i].Dock = DockStyle.Fill;
                DeviceName[i].Enabled = false;
                DeviceName[i].ForeColor = SystemColors.ScrollBar;
                DeviceName[i].Text = "";
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
            // MacAddress MaskedTextBox
            /////////////////////////////////////////////////////////////////////////////
            Address.Add(maskedTextBox1);
            Address.Add(maskedTextBox2);
            Address.Add(maskedTextBox3);
            Address.Add(maskedTextBox4);
            Address.Add(maskedTextBox5);
            Address.Add(maskedTextBox6);
            Address.Add(maskedTextBox7);
            Address.Add(maskedTextBox8);
            Address.Add(maskedTextBox9);
            Address.Add(maskedTextBox10);
            
            for (var i = 0; i < TOTAL_SIZE; i++)
            {
                Address[i].Dock = DockStyle.Fill;
                Address[i].Enabled = false;
                Address[i].Mask = "";
                Address[i].Name = $"maskedTextBox_Address{i}";    //임시
                Address[i].Text = "";
            }

            Address[0].Enter += (s, e) => AddressEnter(0);
            Address[1].Enter += (s, e) => AddressEnter(1);
            Address[2].Enter += (s, e) => AddressEnter(2);
            Address[3].Enter += (s, e) => AddressEnter(3);
            Address[4].Enter += (s, e) => AddressEnter(4);
            Address[5].Enter += (s, e) => AddressEnter(5);
            Address[6].Enter += (s, e) => AddressEnter(6);
            Address[7].Enter += (s, e) => AddressEnter(7);
            Address[8].Enter += (s, e) => AddressEnter(8);
            Address[9].Enter += (s, e) => AddressEnter(9);

            Address[0].Leave += (s, e) => AddressLeave(0);
            Address[1].Leave += (s, e) => AddressLeave(1);
            Address[2].Leave += (s, e) => AddressLeave(2);
            Address[3].Leave += (s, e) => AddressLeave(3);
            Address[4].Leave += (s, e) => AddressLeave(4);
            Address[5].Leave += (s, e) => AddressLeave(5);
            Address[6].Leave += (s, e) => AddressLeave(6);
            Address[7].Leave += (s, e) => AddressLeave(7);
            Address[8].Leave += (s, e) => AddressLeave(8);
            Address[9].Leave += (s, e) => AddressLeave(9);
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

            for (var i = 0; i < TOTAL_SIZE; i++)
            {
                Port[i].Dock = DockStyle.Fill;
                Port[i].DropDownStyle = ComboBoxStyle.DropDownList;
                Port[i].Enabled = false;
                Port[i].Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
                Port[i].Text = "";
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

            for (var i = 0; i < TOTAL_SIZE; i++)
            {
                Value[i].Dock = DockStyle.Fill;
                Value[i].Enabled = false;
                Value[i].Text = "";
                Value[i].TextAlign = HorizontalAlignment.Right;
            }

            Value[0].KeyPress += (s, e) => ValueKeyDown(e, 0);
            Value[1].KeyPress += (s, e) => ValueKeyDown(e, 1);
            Value[2].KeyPress += (s, e) => ValueKeyDown(e, 2);
            Value[3].KeyPress += (s, e) => ValueKeyDown(e, 3);
            Value[4].KeyPress += (s, e) => ValueKeyDown(e, 4);
            Value[5].KeyPress += (s, e) => ValueKeyDown(e, 5);
            Value[6].KeyPress += (s, e) => ValueKeyDown(e, 6);
            Value[7].KeyPress += (s, e) => ValueKeyDown(e, 7);
            Value[8].KeyPress += (s, e) => ValueKeyDown(e, 8);
            Value[9].KeyPress += (s, e) => ValueKeyDown(e, 9);

            Value[0].TextChanged += (s, e) => ValueTextChanged(0);
            Value[1].TextChanged += (s, e) => ValueTextChanged(1);
            Value[2].TextChanged += (s, e) => ValueTextChanged(2);
            Value[3].TextChanged += (s, e) => ValueTextChanged(3);
            Value[4].TextChanged += (s, e) => ValueTextChanged(4);
            Value[5].TextChanged += (s, e) => ValueTextChanged(5);
            Value[6].TextChanged += (s, e) => ValueTextChanged(6);
            Value[7].TextChanged += (s, e) => ValueTextChanged(7);
            Value[8].TextChanged += (s, e) => ValueTextChanged(8);
            Value[9].TextChanged += (s, e) => ValueTextChanged(9);
            /////////////////////////////////////////////////////////////////////////////
            // Distance RadioButton
            /////////////////////////////////////////////////////////////////////////////
            Distance.Add(radioButton_3cm);
            Distance.Add(radioButton_4cm);
            Distance.Add(radioButton_5cm);

            Distance[0].CheckedChanged += (s, e) => DistanceCheck_ClickChanged(0);
            Distance[1].CheckedChanged += (s, e) => DistanceCheck_ClickChanged(1);
            Distance[2].CheckedChanged += (s, e) => DistanceCheck_ClickChanged(2);
            /////////////////////////////////////////////////////////////////////////////
            // Dose RadioButton
            /////////////////////////////////////////////////////////////////////////////
            Dose.Add(radioButton_10μCi);
            Dose.Add(radioButton_34μCi);
            Dose.Add(radioButton_51μCi);

            Dose[0].CheckedChanged += (s, e) => DoseCheck_ClickChanged(0);
            Dose[1].CheckedChanged += (s, e) => DoseCheck_ClickChanged(1);
            Dose[2].CheckedChanged += (s, e) => DoseCheck_ClickChanged(2);
        }

        private void UpdateForm(MethodInvoker method)
        {
            if(InvokeRequired)
            {
                method.Invoke();
            }
            else
                BeginInvoke(method);
        }

        private void NewFileUI()
        {
            groupBox_FileData.Enabled = true;
            button_Save.Enabled = true;
            linkLabel_FileName.Text = $"{fileName}{version}";

            for (var i = 0; i < TOTAL_SIZE; i++)
            {
                if (i < usingDevices)
                {
                    ConnectCheck[i].Checked = false;
                    ConnectCheck[i].Enabled = false;
                    DeviceName[i].Enabled = true;
                    DeviceName[i].ForeColor = SystemColors.ScrollBar;
                    DeviceName[i].ReadOnly = false;
                    DeviceName[i].Text = $"Device{i + 1}";
                    Address[i].Enabled = true;
                    Address[i].Mask = "AA:AA:AA:AA:AA:AA";
                    Address[i].ReadOnly = false;
                    if (Address[i].Focused)
                    {
                        Address[i].ForeColor = SystemColors.ControlText;
                        Address[i].Text = "";
                    }
                    else
                    {
                        Address[i].ForeColor = SystemColors.ScrollBar;
                        Address[i].Text = "AA:BB:CC:DD:EE:FF";
                    }
                    Port[i].Enabled = true;
                    Port[i].Text = "";
                    Value[i].Enabled = true;
                    Value[i].ReadOnly = false;
                    Value[i].Text = "";
                }
                else
                {
                    ConnectCheck[i].Enabled = false;
                    DeviceName[i].Enabled = false;
                    DeviceName[i].Text = "";
                    Address[i].Enabled = false;
                    Address[i].Mask = "";
                    Address[i].Text = "";
                    Port[i].Enabled = false;
                    Port[i].Text = "";
                    Value[i].Enabled = false;
                    Value[i].Text = "";
                }
            }
        }

        private void CreateClickUI()
        {
            linkLabel_FileName.Text = $"{fileName}{version}";
            button_Save.Enabled = true;
            button_Connect.Enabled = false;

            for (var i = 0; i < usingDevices; i++)
            {
                if (User[i].Using)
                {
                    ConnectCheck[i].Checked = false;
                    ConnectCheck[i].Enabled = false;
                    Value[i].ReadOnly = false;
                }
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
                DeviceName[index].Text = $"Device{index + 1}";
            }
        }

        private void AddressEnter(int index)
        {
            if (User[index].Address == "")
            {
                Address[index].ForeColor = SystemColors.ControlText;
                Address[index].Text = "";
            }
        }

        private void AddressLeave(int index)
        {
            if (Address[index].Text == "  :  :  :  :  :")
            {
                User[index].Address = "";
                Address[index].ForeColor = SystemColors.ScrollBar;
                Address[index].Text = "AA:BB:CC:DD:EE:FF";
            }
            else
                User[index].Address = Address[index].Text;
        }

        private void ValueKeyDown(KeyPressEventArgs e, int index)
        {
            if (!char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Decimal))
                e.Handled = true;
        }

        private void SaveClickUI()
        {
            for (var i = 0; i < usingDevices; i++)
            {
                ConnectCheck[i].Enabled = true;
                DeviceName[i].ReadOnly = true;
                Address[i].ReadOnly = true;
                Value[i].ReadOnly = true;
            }

            button_Save.Enabled = false;
            button_Create.Enabled = true;
        }

        private void ConnectCheckClickUI()
        {
            int Check = 0;

            for (var i = 0; i < usingDevices; i++)
            {
                if (User[i].Connecting)
                {
                    Check++;

                    if (Check == 2)
                    {
                        for (var j = 0; j < usingDevices; j++)
                            if (!ConnectCheck[j].Checked)
                                ConnectCheck[j].Enabled = false;
                        break;
                    }
                }
            }

            if (Check < 2)
            {
                for (var i = 0; i < usingDevices; i++)
                    if (!ConnectCheck[i].Checked)
                        ConnectCheck[i].Enabled = true;
            }

            if (Check == 0)
                button_Connect.Enabled = false;
            else
                button_Connect.Enabled = true;
        }

        private void ConnectStartUI()
        {
            this.Text = "Connecting...";
            button_Connect.Enabled = false;
            button_Connect.Text = "Connecting...";

            for (var i = 0; i < usingDevices; i++)
            {
                ConnectCheck[i].Enabled = false;
            }
        }

        private void ConnectFinishUI()
        {
            this.Text = "Calibration App";
            button_Connect.Enabled = true;
            button_Connect.Text = "Disconnect";
            groupBox_Config.Enabled = true;
        }

        private void DisconnectStartUI()
        {
            this.Text = "Disconnecting...";
            button_Connect.Enabled = false;
            button_Connect.Text = "Disconnecting...";
            groupBox_Config.Enabled = false;

            for(var i = 0; i < 3; i++)
            {
                Distance[i].Checked = false;
                Distance[i].Text = DistanceText[i];
                Dose[i].Checked = false;
                Dose[i].Text = DoseText[i];
            }
        }

        private void DisconnectFinishUI()
        {
            this.Text = "Calibration App";
            button_Connect.Enabled = true;
            button_Connect.Text = "Connect";

            for (var i = 0; i < usingDevices; i++)
            {
                ConnectCheck[i].Enabled = true;
            }
        }

        private void DistanceCheck_ClickChanged(int index)
        {
            distanceCheckIndex = index;
            if(Distance[index].Checked)
                for(var i = 0; i < usingDevices; i++)
                {
                    if (!User[i].Connecting)
                        continue;

                    for (var j = 0; j < 3; j++)
                    {
                        Dose[j].Text = DoseText[j];
                        if (!User[i].CalibrationComplete[index, j])
                            Dose[j].Text = "*" + Dose[j].Text;
                    }
                }

            if (distanceCheckIndex >= 0 && doseCheckIndex >= 0)
                button_Apply.Enabled = true;
            else
                button_Apply.Enabled = false;

            button_Start.Enabled = false;
        }

        private void DoseCheck_ClickChanged(int index)
        {
            doseCheckIndex = index;
            if (Dose[index].Checked)
                for (var i = 0; i < usingDevices; i++)
                {
                    if (!User[i].Connecting)
                        continue;

                    for (var j = 0; j < 3; j++)
                    {
                        Distance[j].Text = DistanceText[j];

                        if (!User[i].CalibrationComplete[j, index])
                            Distance[j].Text = "*" + Distance[j].Text;
                    }
                }

            if (distanceCheckIndex >= 0 && doseCheckIndex >= 0)
                button_Apply.Enabled = true;
            else
                button_Apply.Enabled = false;

            button_Start.Enabled = false;
        }

        private void ApplyClickUI()
        {
            button_Apply.Enabled = false;
            button_Start.Enabled = true;
        }
    }
}
