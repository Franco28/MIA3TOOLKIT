
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegawMOD.Android;

namespace MIA3TOOLKIT
{
    public partial class Form1 : Form
    {
        Device device; AndroidController android = null; string serial;
        string exePath = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);

        public Form1()
        {
            InitializeComponent();
            menuStrip1.Renderer = new MyRenderer();
            menuStrip1.Cursor = Cursors.Hand;
            labelDeviceStatus.BackColor = aboutToolStripMenuItem.BackColor = mIFLASHToolStripMenuItem.BackColor = menuStrip1.BackColor = Color.FromArgb(38, 38, 38);
            labelDeviceStatus.ForeColor = aboutToolStripMenuItem.ForeColor = mIFLASHToolStripMenuItem.ForeColor = groupBoxReboot.ForeColor = groupBoxTWRPBOOT.ForeColor = groupBoxSlot.ForeColor = groupBoxBootloader.ForeColor = Color.FromArgb(250, 232, 232);
            groupBoxSlot.Hide();
            groupBoxBootloader.Hide();
            groupBoxReboot.Hide();
            groupBoxTWRPBOOT.Hide();
            mIFLASHToolStripMenuItem.Enabled = false;
            aboutToolStripMenuItem.Enabled = false;
        }

        private class MyRenderer : ToolStripProfessionalRenderer
        {
            public MyRenderer() : base(new MyColors()) { }
        }

        private class MyColors : ProfessionalColorTable
        {
            public override Color MenuItemSelected
            {
                get { return Color.FromArgb(38,38,38); }
            }
            public override Color MenuItemSelectedGradientBegin
            {
                get { return Color.FromArgb(38, 38, 38); }
            }
            public override Color MenuItemSelectedGradientEnd
            {
                get { return Color.FromArgb(38, 38, 38); }
            }
        }

        public void cAppend(string message)
        {
            this.Invoke((Action)delegate
            {
                console.AppendText(string.Format("\n{0} : {1}", DateTime.Now, message));
                console.ScrollToCaret();
            });
        }

        bool isConnected()
        {
            bool i = false;
            android.UpdateDeviceList();
            if (android.HasConnectedDevices)
            {
                serial = android.ConnectedDevices[0];
                device = android.GetConnectedDevice(serial);
                i = true;
                cAppend("Device: " + serial.ToString());
                labelDeviceStatus.Text = "Device Status: Online";
            }
            else
                i = false;
            labelDeviceStatus.Text = "Device Status: Offline";
            return i;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                cAppend("Loading adb services and Tool...");
                android = AndroidController.Instance;
                cAppend("Loading adb services and Tool... {OK}");
                Thread.Sleep(1000);
            });
            Thread.Sleep(500);
            groupBoxSlot.Show();
            Thread.Sleep(500);
            groupBoxBootloader.Show();
            Thread.Sleep(500);
            groupBoxTWRPBOOT.Show();
            Thread.Sleep(500);
            groupBoxReboot.Show();
            mIFLASHToolStripMenuItem.Enabled = true;
            aboutToolStripMenuItem.Enabled = true;
            Thread.Sleep(500);
            cAppend("Checking device connection...");
            if (isConnected())
            {
                cAppend("Checking device connection... {online}");
            }
            else
            {
                cAppend("Checking device connection... {offline}");
            }
            cAppend("---------------------------------------------------------");
            cAppend("Welcome to Xiaomi MI A3 ToolKit!");
        }

        private void buttonUnlockBootloader_Click(object sender, EventArgs e)
        {
            if (isConnected())
            {
                cAppend("Unlocking bootloader...");
                string unlock = Fastboot.ExecuteFastbootCommand(Fastboot.FormFastbootCommand(" flashing unlock"));
                cAppend(unlock.ToString());
                cAppend("Unlocking bootloader... {OK}");
            }
            else
            {
                cAppend("{UnlockBootloader} Please connect your device...");
                return;
            }
        }

        private void buttonUnlockCritical_Click(object sender, EventArgs e)
        {
            if (isConnected())
            {
                cAppend("Unlocking critical...");
                string unlock = Fastboot.ExecuteFastbootCommand(Fastboot.FormFastbootCommand(" flashing unlock_critical"));
                cAppend(unlock.ToString());
                cAppend("Unlocking critical... {OK}");
            }
            else
            {
                cAppend("{UnlockCriticalBootloader} Please connect your device...");
                return;
            }
        }

        private void buttonLockBootloader_Click(object sender, EventArgs e)
        {
            if (isConnected())
            {
                cAppend("Locking bootloader...");
                string locck = Fastboot.ExecuteFastbootCommand(Fastboot.FormFastbootCommand(" flashing lock"));
                cAppend(locck.ToString());
                cAppend("Locking bootloader... {OK}");
            }
            else
            {
                cAppend("{LockBootloader} Please connect your device...");
                return;
            }
        }

        private void buttonChangeSlot_Click(object sender, EventArgs e)
        {
            if (isConnected())
            {
                if (radioButtonSlotA.Checked == true)
                {
                    cAppend("Changing slot to: A");
                    labelSlotStatus.Text = "Current: A";
                    return;
                }
                if (radioButtonSlotB.Checked == true)
                {
                    cAppend("Changing slot to: B");
                    labelSlotStatus.Text = "Current: B";
                    return;
                }
            }
            else
            {
                cAppend("{ChangeSlot} Please connect your device...");
                return;
            }
        }

        private void buttonBOOTTWRP_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = exePath;
            openFileDialog1.Title = "Select your TWRP img!";
            openFileDialog1.Filter = @"img Files|*.img";
            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
            string twrp = openFileDialog1.FileName.ToString();
            if (isConnected())
            {
                cAppend("Booting " + twrp + "..."); 
                Fastboot.ExecuteFastbootCommand(Fastboot.FormFastbootCommand(" flash boot " + twrp));
                cAppend("Booting " + twrp + "... {OK}");
                Fastboot.ExecuteFastbootCommand(Fastboot.FormFastbootCommand(" reboot recovery"));
            }
            else
            {
                cAppend("{BootTWRP} Please connect your device...");
                return;
            }
        }

        private void console_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            console.SaveFile(exePath + @"\logs.txt", RichTextBoxStreamType.PlainText);
        }

        private void radioButtonSlotB_CheckedChanged(object sender, EventArgs e)
        {
            labelSlotStatus.Text = "Selected: B";
        }

        private void radioButtonSlotA_CheckedChanged(object sender, EventArgs e)
        {
            labelSlotStatus.Text = "Selected: A";
        }

        private void buttonRebootBootloader_Click(object sender, EventArgs e)
        {
            if (isConnected())
            {
                cAppend("Rebooting into bootloader...");
                Adb.ExecuteAdbCommand(Adb.FormAdbCommand(" reboot bootloader"));
                cAppend("Rebooting into bootloader... {OK}");
            }
            else
            {
                cAppend("{RebootBootloader} Please connect your device...");
                return;
            }
        }

        private void buttonRebootRecovery_Click(object sender, EventArgs e)
        {
            if (isConnected())
            {
                cAppend("Rebooting into recovery...");
                Adb.ExecuteAdbCommand(Adb.FormAdbCommand(" reboot recovery"));
                cAppend("Rebooting into recovery... {OK}");
            }
            else
            {
                cAppend("{RebootRecovery} Please connect your device...");
                return;
            }
        }

        private void mIFLASHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var miflash = new MIFlash();
            miflash.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var about = new About();
            about.Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                string taskname = "adb";
                foreach (var process in Process.GetProcessesByName(taskname))
                {
                    process.Kill();
                }
            }
            catch (Exception ex)
            {
                cAppend("ERROR TASK {KILLING ADB SERVICES}: " + ex.ToString());
            }
        }
    }
}