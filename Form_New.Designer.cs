
namespace Calibration
{
    partial class Form_New
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.button_Make = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.label_Name = new System.Windows.Forms.Label();
            this.label_Device = new System.Windows.Forms.Label();
            this.numericUpDown_Devices = new System.Windows.Forms.NumericUpDown();
            this.label_Ver = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Devices)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(154, 12);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(90, 21);
            this.textBox_Name.TabIndex = 0;
            // 
            // button_Make
            // 
            this.button_Make.Location = new System.Drawing.Point(104, 78);
            this.button_Make.Name = "button_Make";
            this.button_Make.Size = new System.Drawing.Size(90, 23);
            this.button_Make.TabIndex = 1;
            this.button_Make.Text = "Make";
            this.button_Make.UseVisualStyleBackColor = true;
            this.button_Make.Click += new System.EventHandler(this.button_Make_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(200, 78);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(90, 23);
            this.button_Cancel.TabIndex = 2;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(12, 17);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(135, 12);
            this.label_Name.TabIndex = 3;
            this.label_Name.Text = "FIle Name : 2021-01-09";
            // 
            // label_Device
            // 
            this.label_Device.AutoSize = true;
            this.label_Device.Location = new System.Drawing.Point(12, 43);
            this.label_Device.Name = "label_Device";
            this.label_Device.Size = new System.Drawing.Size(94, 12);
            this.label_Device.TabIndex = 4;
            this.label_Device.Text = "Using Devices :";
            // 
            // numericUpDown_Devices
            // 
            this.numericUpDown_Devices.Location = new System.Drawing.Point(154, 39);
            this.numericUpDown_Devices.Name = "numericUpDown_Devices";
            this.numericUpDown_Devices.Size = new System.Drawing.Size(90, 21);
            this.numericUpDown_Devices.TabIndex = 5;
            this.numericUpDown_Devices.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label_Ver
            // 
            this.label_Ver.AutoSize = true;
            this.label_Ver.Location = new System.Drawing.Point(250, 17);
            this.label_Ver.Name = "label_Ver";
            this.label_Ver.Size = new System.Drawing.Size(34, 12);
            this.label_Ver.TabIndex = 6;
            this.label_Ver.Text = "Ver.1";
            // 
            // Form_New
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 113);
            this.Controls.Add(this.label_Ver);
            this.Controls.Add(this.numericUpDown_Devices);
            this.Controls.Add(this.label_Device);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Make);
            this.Controls.Add(this.textBox_Name);
            this.Name = "Form_New";
            this.Text = "New File";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Devices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Button button_Make;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_Device;
        private System.Windows.Forms.NumericUpDown numericUpDown_Devices;
        private System.Windows.Forms.Label label_Ver;
    }
}