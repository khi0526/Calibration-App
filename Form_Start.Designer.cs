
namespace Calibration
{
    partial class Form_Start
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
            this.label_Device1Name = new System.Windows.Forms.Label();
            this.label_Device2Name = new System.Windows.Forms.Label();
            this.label_Device1CPS = new System.Windows.Forms.Label();
            this.label_Device2CPS = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.button_Abort = new System.Windows.Forms.Button();
            this.label_Time = new System.Windows.Forms.Label();
            this.label_Config = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_Device1Name
            // 
            this.label_Device1Name.AutoSize = true;
            this.label_Device1Name.Location = new System.Drawing.Point(12, 56);
            this.label_Device1Name.Name = "label_Device1Name";
            this.label_Device1Name.Size = new System.Drawing.Size(97, 12);
            this.label_Device1Name.TabIndex = 0;
            this.label_Device1Name.Text = "Device1\'s CPS :";
            // 
            // label_Device2Name
            // 
            this.label_Device2Name.AutoSize = true;
            this.label_Device2Name.Location = new System.Drawing.Point(12, 88);
            this.label_Device2Name.Name = "label_Device2Name";
            this.label_Device2Name.Size = new System.Drawing.Size(97, 12);
            this.label_Device2Name.TabIndex = 1;
            this.label_Device2Name.Text = "Device2\'s CPS :";
            // 
            // label_Device1CPS
            // 
            this.label_Device1CPS.AutoSize = true;
            this.label_Device1CPS.Location = new System.Drawing.Point(149, 56);
            this.label_Device1CPS.Name = "label_Device1CPS";
            this.label_Device1CPS.Size = new System.Drawing.Size(23, 12);
            this.label_Device1CPS.TabIndex = 4;
            this.label_Device1CPS.Text = "163";
            this.label_Device1CPS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_Device2CPS
            // 
            this.label_Device2CPS.AutoSize = true;
            this.label_Device2CPS.Location = new System.Drawing.Point(149, 88);
            this.label_Device2CPS.Name = "label_Device2CPS";
            this.label_Device2CPS.Size = new System.Drawing.Size(23, 12);
            this.label_Device2CPS.TabIndex = 5;
            this.label_Device2CPS.Text = "125";
            this.label_Device2CPS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 12);
            this.progressBar.Maximum = 110;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(396, 23);
            this.progressBar.Step = 1;
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 6;
            // 
            // button_Abort
            // 
            this.button_Abort.Location = new System.Drawing.Point(298, 83);
            this.button_Abort.Name = "button_Abort";
            this.button_Abort.Size = new System.Drawing.Size(110, 23);
            this.button_Abort.TabIndex = 8;
            this.button_Abort.TabStop = false;
            this.button_Abort.Text = "Abort";
            this.button_Abort.UseVisualStyleBackColor = true;
            this.button_Abort.Click += new System.EventHandler(this.Button_Abort_Click);
            // 
            // label_Time
            // 
            this.label_Time.AutoSize = true;
            this.label_Time.Location = new System.Drawing.Point(298, 56);
            this.label_Time.Name = "label_Time";
            this.label_Time.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_Time.Size = new System.Drawing.Size(110, 12);
            this.label_Time.TabIndex = 9;
            this.label_Time.Text = "13:05:11 ~ 13:05:49";
            this.label_Time.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_Config
            // 
            this.label_Config.AutoSize = true;
            this.label_Config.Location = new System.Drawing.Point(226, 56);
            this.label_Config.Name = "label_Config";
            this.label_Config.Size = new System.Drawing.Size(66, 12);
            this.label_Config.TabIndex = 10;
            this.label_Config.Text = "3cm/10μCi";
            // 
            // Form_Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 118);
            this.ControlBox = false;
            this.Controls.Add(this.label_Config);
            this.Controls.Add(this.label_Time);
            this.Controls.Add(this.button_Abort);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.label_Device2CPS);
            this.Controls.Add(this.label_Device1CPS);
            this.Controls.Add(this.label_Device2Name);
            this.Controls.Add(this.label_Device1Name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_Start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form_Start";
            this.Shown += new System.EventHandler(this.Form_Start_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Device1Name;
        private System.Windows.Forms.Label label_Device2Name;
        private System.Windows.Forms.Label label_Device1CPS;
        private System.Windows.Forms.Label label_Device2CPS;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button button_Abort;
        private System.Windows.Forms.Label label_Time;
        private System.Windows.Forms.Label label_Config;
    }
}