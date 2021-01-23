
namespace Calibration
{
    partial class Form_Create
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
            this.chkListBox_Device = new System.Windows.Forms.CheckedListBox();
            this.button_Apply = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.label_Device = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chkListBox_Device
            // 
            this.chkListBox_Device.FormattingEnabled = true;
            this.chkListBox_Device.Items.AddRange(new object[] {
            "Device1",
            "Device2",
            "Device3",
            "Device4",
            "Device5",
            "Device6",
            "Device7",
            "Device8",
            "Device9",
            "Device10"});
            this.chkListBox_Device.Location = new System.Drawing.Point(14, 24);
            this.chkListBox_Device.Name = "chkListBox_Device";
            this.chkListBox_Device.Size = new System.Drawing.Size(317, 164);
            this.chkListBox_Device.TabIndex = 0;
            // 
            // button_Apply
            // 
            this.button_Apply.Location = new System.Drawing.Point(145, 194);
            this.button_Apply.Name = "button_Apply";
            this.button_Apply.Size = new System.Drawing.Size(90, 23);
            this.button_Apply.TabIndex = 1;
            this.button_Apply.Text = "Apply";
            this.button_Apply.UseVisualStyleBackColor = true;
            this.button_Apply.Click += new System.EventHandler(this.button_Apply_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(241, 194);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(90, 23);
            this.button_Cancel.TabIndex = 2;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // label_Device
            // 
            this.label_Device.AutoSize = true;
            this.label_Device.Location = new System.Drawing.Point(12, 9);
            this.label_Device.Name = "label_Device";
            this.label_Device.Size = new System.Drawing.Size(154, 12);
            this.label_Device.TabIndex = 3;
            this.label_Device.Text = "Select devices to calibrate";
            // 
            // Form_Create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 222);
            this.Controls.Add(this.label_Device);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Apply);
            this.Controls.Add(this.chkListBox_Device);
            this.Name = "Form_Create";
            this.Text = "2021.01.13. Calibration Ver.2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chkListBox_Device;
        private System.Windows.Forms.Button button_Apply;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Label label_Device;
    }
}