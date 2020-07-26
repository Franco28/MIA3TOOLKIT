namespace MIA3TOOLKIT
{
    partial class MIFlash
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
            this.console = new System.Windows.Forms.RichTextBox();
            this.groupBoxReboot = new System.Windows.Forms.GroupBox();
            this.buttonRebootBootloader = new System.Windows.Forms.Button();
            this.radioButtonSlotA = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.labelDeviceStatus = new System.Windows.Forms.Label();
            this.groupBoxReboot.SuspendLayout();
            this.SuspendLayout();
            // 
            // console
            // 
            this.console.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.console.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.console.Dock = System.Windows.Forms.DockStyle.Top;
            this.console.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.console.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.console.Location = new System.Drawing.Point(0, 0);
            this.console.Name = "console";
            this.console.ReadOnly = true;
            this.console.Size = new System.Drawing.Size(439, 155);
            this.console.TabIndex = 3;
            this.console.Text = "";
            // 
            // groupBoxReboot
            // 
            this.groupBoxReboot.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxReboot.Controls.Add(this.radioButton1);
            this.groupBoxReboot.Controls.Add(this.radioButtonSlotA);
            this.groupBoxReboot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxReboot.Location = new System.Drawing.Point(12, 189);
            this.groupBoxReboot.Name = "groupBoxReboot";
            this.groupBoxReboot.Size = new System.Drawing.Size(415, 44);
            this.groupBoxReboot.TabIndex = 11;
            this.groupBoxReboot.TabStop = false;
            this.groupBoxReboot.Text = "MI FLASH OPTIONS";
            // 
            // buttonRebootBootloader
            // 
            this.buttonRebootBootloader.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRebootBootloader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRebootBootloader.Location = new System.Drawing.Point(12, 251);
            this.buttonRebootBootloader.Name = "buttonRebootBootloader";
            this.buttonRebootBootloader.Size = new System.Drawing.Size(415, 23);
            this.buttonRebootBootloader.TabIndex = 4;
            this.buttonRebootBootloader.Text = "Start Flash";
            this.buttonRebootBootloader.UseVisualStyleBackColor = true;
            // 
            // radioButtonSlotA
            // 
            this.radioButtonSlotA.AutoSize = true;
            this.radioButtonSlotA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonSlotA.Location = new System.Drawing.Point(6, 19);
            this.radioButtonSlotA.Name = "radioButtonSlotA";
            this.radioButtonSlotA.Size = new System.Drawing.Size(86, 17);
            this.radioButtonSlotA.TabIndex = 5;
            this.radioButtonSlotA.TabStop = true;
            this.radioButtonSlotA.Text = "STOCK A10 ";
            this.radioButtonSlotA.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton1.Location = new System.Drawing.Point(149, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(63, 17);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "MIUI 12";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // labelDeviceStatus
            // 
            this.labelDeviceStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDeviceStatus.AutoSize = true;
            this.labelDeviceStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeviceStatus.Location = new System.Drawing.Point(12, 158);
            this.labelDeviceStatus.Name = "labelDeviceStatus";
            this.labelDeviceStatus.Size = new System.Drawing.Size(109, 16);
            this.labelDeviceStatus.TabIndex = 13;
            this.labelDeviceStatus.Text = "Device Status: ---";
            // 
            // MIFlash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(439, 286);
            this.Controls.Add(this.labelDeviceStatus);
            this.Controls.Add(this.groupBoxReboot);
            this.Controls.Add(this.buttonRebootBootloader);
            this.Controls.Add(this.console);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.MaximizeBox = false;
            this.Name = "MIFlash";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MIFlash";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MIFlash_FormClosing);
            this.Load += new System.EventHandler(this.MIFlash_Load);
            this.groupBoxReboot.ResumeLayout(false);
            this.groupBoxReboot.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox console;
        private System.Windows.Forms.GroupBox groupBoxReboot;
        private System.Windows.Forms.Button buttonRebootBootloader;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButtonSlotA;
        private System.Windows.Forms.Label labelDeviceStatus;
    }
}