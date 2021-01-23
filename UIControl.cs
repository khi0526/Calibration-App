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
        private readonly List<TextBox> Convertrate = new List<TextBox>();
        private readonly List<RadioButton> Distance = new List<RadioButton>();
        private readonly List<RadioButton> Dose = new List<RadioButton>();

        private readonly string[] DistanceText = new string[3] { "3cm", "4cm", "5cm" };
        private readonly string[] DoseText = new string[3] { "10μCi", "34μCi", "51μCi" };

        private void InitUI()
        {
            /////////////////////////////////////////////////////////////////////////////
            // Main Form
            /////////////////////////////////////////////////////////////////////////////
            Size = new Size(525, 700);
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

            for (var i = 0; i < TOTAL_SIZE; i++)
            {
                ConnectCheck[i].CheckAlign = ContentAlignment.MiddleCenter;
                ConnectCheck[i].Dock = DockStyle.Fill;
                ConnectCheck[i].Enabled = false;

                int EventIndex = i;
                ConnectCheck[i].CheckedChanged += (s, e) => ConnectCheck_ClickChanged(EventIndex);
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

            for (var i = 0; i < TOTAL_SIZE; i++)
            {
                DeviceName[i].Dock = DockStyle.Fill;
                DeviceName[i].Enabled = false;
                DeviceName[i].ForeColor = SystemColors.ScrollBar;
                DeviceName[i].Text = "";

                int EventIndex = i;
                DeviceName[i].Enter += (s, e) => DeviceNameEnter(EventIndex);
                DeviceName[i].Leave += (s, e) => DeviceNameLeave(EventIndex);
            }
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
                Address[i].Name = $"maskedTextBox_Address{i+1}";    //임시
                Address[i].Text = "";

                int EventIndex = i;
                Address[i].Enter += (s, e) => AddressEnter(EventIndex);
                Address[i].Leave += (s, e) => AddressLeave(EventIndex);
                Address[i].KeyPress += (s, e) => AddressKeyDown(e, EventIndex);
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
            Convertrate.Add(textBox_Convertrate1);
            Convertrate.Add(textBox_Convertrate2);
            Convertrate.Add(textBox_Convertrate3);
            Convertrate.Add(textBox_Convertrate4);
            Convertrate.Add(textBox_Convertrate5);
            Convertrate.Add(textBox_Convertrate6);
            Convertrate.Add(textBox_Convertrate7);
            Convertrate.Add(textBox_Convertrate8);
            Convertrate.Add(textBox_Convertrate9);
            Convertrate.Add(textBox_Convertrate10);

            for (var i = 0; i < TOTAL_SIZE; i++)
            {
                Convertrate[i].Dock = DockStyle.Fill;
                Convertrate[i].Enabled = false;
                Convertrate[i].Text = "";
                Convertrate[i].TextAlign = HorizontalAlignment.Right;

                int EventIndex = i;
                Convertrate[i].KeyPress += (s, e) => ValueKeyDown(e, EventIndex);
            }
            /////////////////////////////////////////////////////////////////////////////
            // Distance RadioButton
            /////////////////////////////////////////////////////////////////////////////
            Distance.Add(radioButton_3cm);
            Distance.Add(radioButton_4cm);
            Distance.Add(radioButton_5cm);

            for (var i = 0; i < 3; i++)
            {
                int EventIndex = i;
                Distance[i].CheckedChanged += (s, e) => { distanceCheckIndex = EventIndex; ConfigCheck_ClickChanged(); };
            }
            /////////////////////////////////////////////////////////////////////////////
            // Dose RadioButton
            /////////////////////////////////////////////////////////////////////////////
            Dose.Add(radioButton_10μCi);
            Dose.Add(radioButton_34μCi);
            Dose.Add(radioButton_51μCi);

            for (var i = 0; i < 3; i++)
            {
                int EventIndex = i;
                Dose[i].CheckedChanged += (s, e) => { doseCheckIndex = EventIndex; ConfigCheck_ClickChanged(); };
            }
        }

        private void UpdateForm(MethodInvoker method)
        {
            if(InvokeRequired)
                BeginInvoke(method);
            else
                method.Invoke();
        }

        private void NewFileUI()
        {
            groupBox_FileData.Focus();
            groupBox_FileData.Enabled = true;
            groupBox_Config.Enabled = false;
            linkLabel_FileName.Text = $"{FileName} Ver.{version}";
            button_Create.Enabled = false;
            button_Save.Enabled = true;
            button_Save.Text = "Save";
            button_Connect.Enabled = false;
            button_Connect.Text = "Connect";
            button_Apply.Enabled = false;
            button_Start.Enabled = false;
            button_Start.Text = "Calibration Start";

            for (var i = 0; i < TOTAL_SIZE; i++)
            {
                if (i < USING_SIZE)
                {
                    ConnectCheck[i].Checked = false;
                    ConnectCheck[i].Enabled = false;
                    DeviceName[i].Enabled = true;
                    DeviceName[i].ForeColor = SystemColors.ScrollBar;
                    DeviceName[i].ReadOnly = false;
                    DeviceName[i].Text = $"Device{i + 1}";
                    Address[i].Enabled = true;
                    Address[i].ForeColor = SystemColors.ScrollBar;
                    Address[i].Mask = "AA:AA:AA:AA:AA:AA";
                    Address[i].ReadOnly = false;
                    Address[i].Text = "AA:BB:CC:DD:EE:FF";
                    Port[i].Enabled = true;
                    Port[i].Text = "";
                    Convertrate[i].Enabled = true;
                    Convertrate[i].ReadOnly = false;
                    Convertrate[i].Text = "";
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
                    Convertrate[i].Enabled = false;
                    Convertrate[i].Text = "";
                }
            }
        }

        private void CreateClickUI()
        {
            groupBox_FileData.Focus();
            groupBox_FileData.Enabled = true;
            groupBox_Config.Enabled = false;
            linkLabel_FileName.Text = $"{FileName} Ver.{version}";
            button_Create.Enabled = false;
            button_Save.Enabled = true;
            button_Save.Text = "Save";
            button_Connect.Enabled = false;
            button_Connect.Text = "Connect";
            button_Apply.Enabled = false;
            button_Start.Enabled = false;
            button_Start.Text = "Calibration Start";

            for (var i = 0; i < USING_SIZE; i++)
            {
                ConnectCheck[i].Checked = false;
                ConnectCheck[i].Enabled = false;

                if (Device[i].Using)
                {
                    Convertrate[i].ReadOnly = false;
                }
            }
        }

        private void DeviceNameEnter(int index)
        {
            if (DeviceName[index].Text == $"Device{index + 1}" && button_Save.Text == "Save")
            {
                DeviceName[index].ForeColor = SystemColors.ControlText;
                DeviceName[index].Text = "";
            }
        }

        private void DeviceNameLeave(int index)
        {
            if (DeviceName[index].Text == "")
            {
                DeviceName[index].ForeColor = SystemColors.ScrollBar;
                DeviceName[index].Text = $"Device{index + 1}";
            }
        }

        private void AddressEnter(int index)
        {
            if (button_Save.Text == "Save")
            {
                Address[index].Mask = "";
            }

            if (Address[index].Text == "AABBCCDDEEFF")
            {
                Address[index].ForeColor = SystemColors.ControlText;
                Address[index].Text = "";
            }
        }

        private void AddressLeave(int index)
        {
            if (Address[index].Text == "")
            {
                Address[index].ForeColor = SystemColors.ScrollBar;
                Address[index].Text = "AA:BB:CC:DD:EE:FF";
            }

            Address[index].Mask = "AA:AA:AA:AA:AA:AA";
        }

        private void AddressKeyDown(KeyPressEventArgs e, int index)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar)) && e.KeyChar != 8)
                e.Handled = true;

            if (char.IsLower(e.KeyChar))
                e.KeyChar = char.ToUpper(e.KeyChar);

            if ((char.IsDigit(e.KeyChar) || char.IsLetter(e.KeyChar)) && Address[index].TextLength == 12)
                e.Handled = true;
        }

        private void ValueKeyDown(KeyPressEventArgs e, int index)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 46 && e.KeyChar != 8)
                e.Handled = true;

            if ((Convertrate[index].TextLength == 0 || Convertrate[index].Text.Contains(".")) && e.KeyChar == 46)
                e.Handled = true;
        }

        private void SaveClickUI()
        {
            for (var i = 0; i < USING_SIZE; i++)
            {
                ConnectCheck[i].Enabled = true;
                DeviceName[i].ReadOnly = true;
                DeviceName[i].ForeColor = SystemColors.ControlText;
                Address[i].ReadOnly = true;
                Address[i].ForeColor = SystemColors.ControlText;
                Convertrate[i].ReadOnly = true;
            }
            button_Save.Text = "Edit";
            button_Create.Enabled = true;
            ConnectCheckClickUI();
        }

        private void EditClickUI()
        {
            for (var i = 0; i < USING_SIZE; i++)
            {
                ConnectCheck[i].Enabled = false;
                DeviceName[i].ReadOnly = false;
                Address[i].ReadOnly = false;
                Convertrate[i].ReadOnly = false;
            }
            button_Save.Text = "Save";
            button_Create.Enabled = false;
            button_Connect.Enabled = false;
        }

        private void ConnectCheckClickUI()
        {
            int Check = 0;

            for (var i = 0; i < USING_SIZE; i++)
                if (ConnectCheck[i].Checked)
                    Check++;

            switch(Check)
            {
                case 0:
                    button_Connect.Enabled = false;
                    for (var i = 0; i < USING_SIZE; i++)
                        if (!ConnectCheck[i].Checked)
                            ConnectCheck[i].Enabled = true;
                    break;

                case 1:
                    button_Connect.Enabled = true;
                    for (var i = 0; i < USING_SIZE; i++)
                        if (!ConnectCheck[i].Checked)
                            ConnectCheck[i].Enabled = true;
                    break;

                case 2:
                    button_Connect.Enabled = true;
                    for (var j = 0; j < USING_SIZE; j++)
                        if (!ConnectCheck[j].Checked)
                            ConnectCheck[j].Enabled = false;
                    break;
            }
        }

        private void ConnectStartUI()
        {
            this.Text = "Connecting...";
            this.UseWaitCursor = true;
            groupBox_FileData.Enabled = false;
            button_Connect.Text = "Connecting...";

            for (var i = 0; i < USING_SIZE; i++)
            {
                ConnectCheck[i].Enabled = false;
            }

            for (var i = 0; i < 3; i++)
            {
                Distance[i].Checked = false;
                if (Device[i].Complete[0, i] && Device[i].Complete[1, i] && Device[i].Complete[2, i])
                    Distance[i].Text = DistanceText[i];
                else
                    Distance[i].Text = "*" + DistanceText[i];
                Dose[i].Checked = false;
                if (Device[i].Complete[i, 0] && Device[i].Complete[i, 1] && Device[i].Complete[i, 2])
                    Dose[i].Text = DoseText[i];
                else
                    Dose[i].Text = "*" + DoseText[i];
            }
        }

        private void ConnectFinishUI()
        {
            this.Text = "Calibration App";
            this.UseWaitCursor = false;
            groupBox_FileData.Enabled = true;
            button_Create.Enabled = false;
            button_Connect.Text = "Disconnect";
            groupBox_Config.Enabled = true;
            Distance[0].Checked = true;
            Dose[0].Checked = true;
        }

        private void DisconnectStartUI()
        {
            this.Text = "Disconnecting...";
            this.UseWaitCursor = true;
            groupBox_FileData.Enabled = false;
            button_Connect.Text = "Disconnecting...";
            groupBox_Config.Enabled = false;

            for(var i = 0; i < 3; i++)
            {
                Distance[i].Checked = false;
                Dose[i].Checked = false;
            }

            for (var i = 0; i < 3; i++)
            {
                Distance[i].Text = DistanceText[i];
                Dose[i].Text = DoseText[i];
            }
        }

        private void DisconnectFinishUI()
        {
            this.Text = "Calibration App";
            this.UseWaitCursor = false;
            button_Create.Enabled = true;
            groupBox_FileData.Enabled = true;
            button_Connect.Text = "Connect";

            for (var i = 0; i < USING_SIZE; i++)
            {
                ConnectCheck[i].Enabled = true;
            }
        }

        private void ConfigCheck_ClickChanged()
        {
            for (var i = 0; i < USING_SIZE; i++)
            {
                if (!Device[i].Connecting)
                    continue;

                for (var j = 0; j < 3; j++)
                {
                    if (Device[i].Complete[distanceCheckIndex, j])
                        Dose[j].Text = DoseText[j];
                    else
                        Dose[j].Text = "*" + DoseText[j];

                    if (Device[i].Complete[j, doseCheckIndex])
                        Distance[j].Text = DistanceText[j];
                    else
                        Distance[j].Text = "*" + DistanceText[j];
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
            button_Start.Text = "Calibration Start";
            button_Start.Enabled = true;
        }

        private void CalibrationStartUI()
        {
            groupBox_Config.Enabled = false;
            button_Start.Text = "Calibrating...";
            button_Start.Enabled = false;
        }

        private void CalibrationFinishUI()
        {
            groupBox_Config.Enabled = true;
            button_Start.Text = "Calibration Finish";

            ConfigCheck_ClickChanged();
        }
    }
}
