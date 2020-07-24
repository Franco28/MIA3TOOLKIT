namespace MIA3TOOLKIT
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.console = new System.Windows.Forms.RichTextBox();
            this.groupBoxSlot = new System.Windows.Forms.GroupBox();
            this.labelSlotStatus = new System.Windows.Forms.Label();
            this.buttonChangeSlot = new System.Windows.Forms.Button();
            this.radioButtonSlotB = new System.Windows.Forms.RadioButton();
            this.radioButtonSlotA = new System.Windows.Forms.RadioButton();
            this.groupBoxBootloader = new System.Windows.Forms.GroupBox();
            this.buttonUnlockCritical = new System.Windows.Forms.Button();
            this.buttonUnlockBootloader = new System.Windows.Forms.Button();
            this.buttonLockBootloader = new System.Windows.Forms.Button();
            this.groupBoxTWRPBOOT = new System.Windows.Forms.GroupBox();
            this.buttonBOOTTWRP = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBoxReboot = new System.Windows.Forms.GroupBox();
            this.buttonRebootRecovery = new System.Windows.Forms.Button();
            this.buttonRebootBootloader = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mIFLASHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxSlot.SuspendLayout();
            this.groupBoxBootloader.SuspendLayout();
            this.groupBoxTWRPBOOT.SuspendLayout();
            this.groupBoxReboot.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // console
            // 
            this.console.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.console.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.console.Dock = System.Windows.Forms.DockStyle.Top;
            this.console.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.console.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.console.Location = new System.Drawing.Point(0, 24);
            this.console.Name = "console";
            this.console.ReadOnly = true;
            this.console.Size = new System.Drawing.Size(750, 164);
            this.console.TabIndex = 2;
            this.console.Text = "";
            this.console.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.console_MouseDoubleClick);
            // 
            // groupBoxSlot
            // 
            this.groupBoxSlot.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxSlot.Controls.Add(this.labelSlotStatus);
            this.groupBoxSlot.Controls.Add(this.buttonChangeSlot);
            this.groupBoxSlot.Controls.Add(this.radioButtonSlotB);
            this.groupBoxSlot.Controls.Add(this.radioButtonSlotA);
            this.groupBoxSlot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxSlot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSlot.Location = new System.Drawing.Point(12, 194);
            this.groupBoxSlot.Name = "groupBoxSlot";
            this.groupBoxSlot.Size = new System.Drawing.Size(156, 95);
            this.groupBoxSlot.TabIndex = 7;
            this.groupBoxSlot.TabStop = false;
            this.groupBoxSlot.Text = "Change device slot";
            // 
            // labelSlotStatus
            // 
            this.labelSlotStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelSlotStatus.Location = new System.Drawing.Point(6, 39);
            this.labelSlotStatus.Name = "labelSlotStatus";
            this.labelSlotStatus.Size = new System.Drawing.Size(144, 20);
            this.labelSlotStatus.TabIndex = 10;
            this.labelSlotStatus.Text = "---";
            this.labelSlotStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonChangeSlot
            // 
            this.buttonChangeSlot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonChangeSlot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChangeSlot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChangeSlot.Location = new System.Drawing.Point(6, 65);
            this.buttonChangeSlot.Name = "buttonChangeSlot";
            this.buttonChangeSlot.Size = new System.Drawing.Size(144, 23);
            this.buttonChangeSlot.TabIndex = 6;
            this.buttonChangeSlot.Text = "Change";
            this.buttonChangeSlot.UseVisualStyleBackColor = true;
            this.buttonChangeSlot.Click += new System.EventHandler(this.buttonChangeSlot_Click);
            // 
            // radioButtonSlotB
            // 
            this.radioButtonSlotB.AutoSize = true;
            this.radioButtonSlotB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonSlotB.Location = new System.Drawing.Point(115, 15);
            this.radioButtonSlotB.Name = "radioButtonSlotB";
            this.radioButtonSlotB.Size = new System.Drawing.Size(35, 20);
            this.radioButtonSlotB.TabIndex = 5;
            this.radioButtonSlotB.TabStop = true;
            this.radioButtonSlotB.Text = "B";
            this.radioButtonSlotB.UseVisualStyleBackColor = true;
            this.radioButtonSlotB.CheckedChanged += new System.EventHandler(this.radioButtonSlotB_CheckedChanged);
            // 
            // radioButtonSlotA
            // 
            this.radioButtonSlotA.AutoSize = true;
            this.radioButtonSlotA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonSlotA.Location = new System.Drawing.Point(6, 15);
            this.radioButtonSlotA.Name = "radioButtonSlotA";
            this.radioButtonSlotA.Size = new System.Drawing.Size(35, 20);
            this.radioButtonSlotA.TabIndex = 4;
            this.radioButtonSlotA.TabStop = true;
            this.radioButtonSlotA.Text = "A";
            this.radioButtonSlotA.UseVisualStyleBackColor = true;
            this.radioButtonSlotA.CheckedChanged += new System.EventHandler(this.radioButtonSlotA_CheckedChanged);
            // 
            // groupBoxBootloader
            // 
            this.groupBoxBootloader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxBootloader.Controls.Add(this.buttonUnlockCritical);
            this.groupBoxBootloader.Controls.Add(this.buttonUnlockBootloader);
            this.groupBoxBootloader.Controls.Add(this.buttonLockBootloader);
            this.groupBoxBootloader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxBootloader.Location = new System.Drawing.Point(174, 244);
            this.groupBoxBootloader.Name = "groupBoxBootloader";
            this.groupBoxBootloader.Size = new System.Drawing.Size(296, 45);
            this.groupBoxBootloader.TabIndex = 8;
            this.groupBoxBootloader.TabStop = false;
            this.groupBoxBootloader.Text = "Bootloader";
            // 
            // buttonUnlockCritical
            // 
            this.buttonUnlockCritical.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUnlockCritical.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUnlockCritical.Location = new System.Drawing.Point(72, 15);
            this.buttonUnlockCritical.Name = "buttonUnlockCritical";
            this.buttonUnlockCritical.Size = new System.Drawing.Size(112, 23);
            this.buttonUnlockCritical.TabIndex = 6;
            this.buttonUnlockCritical.Text = "Unlock Critical";
            this.buttonUnlockCritical.UseVisualStyleBackColor = true;
            this.buttonUnlockCritical.Click += new System.EventHandler(this.buttonUnlockCritical_Click);
            // 
            // buttonUnlockBootloader
            // 
            this.buttonUnlockBootloader.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUnlockBootloader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUnlockBootloader.Location = new System.Drawing.Point(6, 15);
            this.buttonUnlockBootloader.Name = "buttonUnlockBootloader";
            this.buttonUnlockBootloader.Size = new System.Drawing.Size(60, 23);
            this.buttonUnlockBootloader.TabIndex = 4;
            this.buttonUnlockBootloader.Text = "Unlock";
            this.buttonUnlockBootloader.UseVisualStyleBackColor = true;
            this.buttonUnlockBootloader.Click += new System.EventHandler(this.buttonUnlockBootloader_Click);
            // 
            // buttonLockBootloader
            // 
            this.buttonLockBootloader.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLockBootloader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLockBootloader.Location = new System.Drawing.Point(190, 15);
            this.buttonLockBootloader.Name = "buttonLockBootloader";
            this.buttonLockBootloader.Size = new System.Drawing.Size(100, 23);
            this.buttonLockBootloader.TabIndex = 5;
            this.buttonLockBootloader.Text = "Lock";
            this.buttonLockBootloader.UseVisualStyleBackColor = true;
            this.buttonLockBootloader.Click += new System.EventHandler(this.buttonLockBootloader_Click);
            // 
            // groupBoxTWRPBOOT
            // 
            this.groupBoxTWRPBOOT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxTWRPBOOT.Controls.Add(this.buttonBOOTTWRP);
            this.groupBoxTWRPBOOT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxTWRPBOOT.Location = new System.Drawing.Point(361, 194);
            this.groupBoxTWRPBOOT.Name = "groupBoxTWRPBOOT";
            this.groupBoxTWRPBOOT.Size = new System.Drawing.Size(109, 44);
            this.groupBoxTWRPBOOT.TabIndex = 9;
            this.groupBoxTWRPBOOT.TabStop = false;
            this.groupBoxTWRPBOOT.Text = "TWRP";
            // 
            // buttonBOOTTWRP
            // 
            this.buttonBOOTTWRP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBOOTTWRP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBOOTTWRP.Location = new System.Drawing.Point(6, 15);
            this.buttonBOOTTWRP.Name = "buttonBOOTTWRP";
            this.buttonBOOTTWRP.Size = new System.Drawing.Size(94, 23);
            this.buttonBOOTTWRP.TabIndex = 4;
            this.buttonBOOTTWRP.Text = "Boot";
            this.buttonBOOTTWRP.UseVisualStyleBackColor = true;
            this.buttonBOOTTWRP.Click += new System.EventHandler(this.buttonBOOTTWRP_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "TWRP";
            // 
            // groupBoxReboot
            // 
            this.groupBoxReboot.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxReboot.Controls.Add(this.buttonRebootRecovery);
            this.groupBoxReboot.Controls.Add(this.buttonRebootBootloader);
            this.groupBoxReboot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxReboot.Location = new System.Drawing.Point(174, 194);
            this.groupBoxReboot.Name = "groupBoxReboot";
            this.groupBoxReboot.Size = new System.Drawing.Size(181, 44);
            this.groupBoxReboot.TabIndex = 10;
            this.groupBoxReboot.TabStop = false;
            this.groupBoxReboot.Text = "Reboot";
            // 
            // buttonRebootRecovery
            // 
            this.buttonRebootRecovery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRebootRecovery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRebootRecovery.Location = new System.Drawing.Point(106, 14);
            this.buttonRebootRecovery.Name = "buttonRebootRecovery";
            this.buttonRebootRecovery.Size = new System.Drawing.Size(69, 23);
            this.buttonRebootRecovery.TabIndex = 5;
            this.buttonRebootRecovery.Text = "Recovery";
            this.buttonRebootRecovery.UseVisualStyleBackColor = true;
            this.buttonRebootRecovery.Click += new System.EventHandler(this.buttonRebootRecovery_Click);
            // 
            // buttonRebootBootloader
            // 
            this.buttonRebootBootloader.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRebootBootloader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRebootBootloader.Location = new System.Drawing.Point(6, 15);
            this.buttonRebootBootloader.Name = "buttonRebootBootloader";
            this.buttonRebootBootloader.Size = new System.Drawing.Size(69, 23);
            this.buttonRebootBootloader.TabIndex = 4;
            this.buttonRebootBootloader.Text = "Bootloader";
            this.buttonRebootBootloader.UseVisualStyleBackColor = true;
            this.buttonRebootBootloader.Click += new System.EventHandler(this.buttonRebootBootloader_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip1.BackgroundImage")));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mIFLASHToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(750, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mIFLASHToolStripMenuItem
            // 
            this.mIFLASHToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mIFLASHToolStripMenuItem.BackgroundImage")));
            this.mIFLASHToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.mIFLASHToolStripMenuItem.Name = "mIFLASHToolStripMenuItem";
            this.mIFLASHToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.mIFLASHToolStripMenuItem.Text = "MI FLASH";
            this.mIFLASHToolStripMenuItem.Click += new System.EventHandler(this.mIFLASHToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.aboutToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("aboutToolStripMenuItem.BackgroundImage")));
            this.aboutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.aboutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripMenuItem.Image")));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(28, 20);
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(750, 410);
            this.Controls.Add(this.groupBoxReboot);
            this.Controls.Add(this.groupBoxTWRPBOOT);
            this.Controls.Add(this.groupBoxSlot);
            this.Controls.Add(this.groupBoxBootloader);
            this.Controls.Add(this.console);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MI A3 TOOLKIT";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxSlot.ResumeLayout(false);
            this.groupBoxSlot.PerformLayout();
            this.groupBoxBootloader.ResumeLayout(false);
            this.groupBoxTWRPBOOT.ResumeLayout(false);
            this.groupBoxReboot.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox console;
        private System.Windows.Forms.GroupBox groupBoxSlot;
        private System.Windows.Forms.RadioButton radioButtonSlotB;
        private System.Windows.Forms.RadioButton radioButtonSlotA;
        private System.Windows.Forms.GroupBox groupBoxBootloader;
        private System.Windows.Forms.Button buttonUnlockBootloader;
        private System.Windows.Forms.Button buttonLockBootloader;
        private System.Windows.Forms.Button buttonChangeSlot;
        private System.Windows.Forms.Label labelSlotStatus;
        private System.Windows.Forms.GroupBox groupBoxTWRPBOOT;
        private System.Windows.Forms.Button buttonBOOTTWRP;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonUnlockCritical;
        private System.Windows.Forms.GroupBox groupBoxReboot;
        private System.Windows.Forms.Button buttonRebootBootloader;
        private System.Windows.Forms.Button buttonRebootRecovery;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mIFLASHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

