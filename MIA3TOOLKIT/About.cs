
using AutoUpdaterDotNET;
using System;
using System.Reflection;
using System.Windows.Forms;

namespace MIA3TOOLKIT
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void About_Load(object sender, EventArgs e)
        {
            this.Text = "About: " + AssemblyProduct + " - v" + Application.ProductVersion;
            label.Text = "Tool: " + AssemblyProduct;
            label1.Text = "Version: v" + Application.ProductVersion;
            label3.Text = "A open source Tool to manipulate with adb and fastboot your Xiaomi MI A3 device, by @Franco28";
            CheckForUpdates();
        }

        public void CheckForUpdates()
        {
            if (InternetCheck.ConnectToInternet() == true)
            {
                AutoUpdater.CheckForUpdateEvent += AutoUpdaterOnCheckForUpdateEvent;
                label2.Text = "Updates: checking for updates...";
                timer1.Interval = (1 * 1 * 100);
                timer1.Tick += new EventHandler(toolupdates);
                About SynchronizingObject = this;
                timer1.Start();
            }
            else
            {
                label2.Text = "Updates: no internet connection...";
                timer1.Stop();
                return;
            }
        }

        private void toolupdates(object sender, EventArgs e)
        {
            try
            {
                AutoUpdater.Start("https://raw.githubusercontent.com/Franco28/MIA3TOOLKIT/master/OTAS/updates.xml");
            }
            catch (Exception)
            {
                label2.Text = "Updates: error on checking updates...";
            }
        }

        private void AutoUpdaterOnCheckForUpdateEvent(UpdateInfoEventArgs args)
        {
            if (args != null)
            {
                if (args.IsUpdateAvailable)
                {
                    if (args.Mandatory.Value)
                    {
                        label2.Text = "Updates: There is new version " + $@" {args.CurrentVersion} " + " available. You are using version " + $@" {args.InstalledVersion}. " + " This is required update. Press Ok to begin updating the application.";
                        return;
                    }
                }
                else
                {
                    label2.Text = "Updates: There is no update available.";
                    timer1.Stop();
                    return;
                }
            }
        }

        public string AssemblyProduct
        {
            get
            {
                var attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                return attributes.Length == 0 ? "" : ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }
    }
}
