
using RegawMOD.Android;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIA3TOOLKIT
{
    public partial class MIFlash : Form
    {

        Device device; AndroidController android = null; string serial;

        public MIFlash()
        {
            InitializeComponent();
            groupBoxReboot.Hide();
            buttonRebootBootloader.Hide();        
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

        private async void MIFlash_Load(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                cAppend("Checking device connection...");
                android = AndroidController.Instance;
            });
            groupBoxReboot.Show();
            buttonRebootBootloader.Show();
            if (isConnected())
            {
                cAppend("Checking device connection... {online}");
            }
            else
            {
                cAppend("Checking device connection... {offline}");
            }
        }

        private void MIFlash_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }
    }
}
