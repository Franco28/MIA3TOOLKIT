
using RegawMOD.Android;
using System;
using System.Windows.Forms;

namespace MIA3TOOLKIT
{
    public partial class MIFlash : Form
    {

        Device device; AndroidController android = null; string serial;

        public MIFlash()
        {
            InitializeComponent();
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
            }
            else
                i = false;
            return i;
        }

        private void MIFlash_Load(object sender, EventArgs e)
        {

        }
    }
}
