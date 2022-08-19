using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BotBrowser
{
    public partial class Form1 : Form
    {
        ActionController ac = new ActionController();
        
        public static String rawComputerName;
        public static String computerName;
        public static String path;
        public static String txtPath;
        public static String folderPath;
        public static String proxy;
        public static bool proxyEnabled = false;
        public static String profile;
        public static bool profileEnabled = false;
        public static bool headlessEnabled = false;
        public static String url;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rawComputerName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            computerName = rawComputerName.Substring(rawComputerName.LastIndexOf('\\') + 1).ToLower();

            path = (String.Format("C:\\Users\\{0}\\AppData\\Local\\Google\\Chrome\\User Data", computerName));
            lblTemporaryPath.Text = path;

            txtPath = (String.Format("C:\\Users\\{0}\\Desktop", computerName));

            try
            {
                byte[] bytes1 = Properties.Resources.chromedriver;
                File.WriteAllBytes(path + "\\chromedriver.exe", bytes1);

                byte[] bytes2 = Properties.Resources.SeleniumExtras_WaitHelpers;
                File.WriteAllBytes(path + "\\SeleniumExtras.WaitHelpers.dll", bytes2);

                byte[] bytes3 = Properties.Resources.WebDriver;
                File.WriteAllBytes(path + "\\WebDriver.dll", bytes3);

                lblDriverState.Text = "Succes";
                lblDriverState.ForeColor = System.Drawing.Color.Green;
            }
            catch (Exception ex)
            {
                lblDriverState.Text = "Failed";
                lblDriverState.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            File.Delete(path + "\\chromedriver.exe");
            File.Delete(path + "\\SeleniumExtras.WaitHelpers.dll");
            File.Delete(path + "\\WebDriver.dll");
        }

        private void chBoxHeadless_CheckedChanged(object sender, EventArgs e)
        {
            txtProfile.Enabled = chBoxHeadless.CheckState == CheckState.Unchecked;
            if (txtProfile.Text != String.Empty)
            {
                txtProfile.Clear();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (chBoxHeadless.Checked)
            {
                headlessEnabled = true;
            }
            if(txtProxy.Text != String.Empty)
            {
                proxy = txtProxy.Text;
                proxyEnabled = true;
            }
            if(txtProfile.Text != String.Empty)
            {
                profile = txtProfile.Text;
                profileEnabled = true;
            }
            if(txtUrl.Text != String.Empty)
            {
                url = txtUrl.Text;
                ac.RunningBrowser();
            }            
            else
            {
                url = "google.com";
                ac.RunningBrowser();
            }
        }

        private void btnScreenshot_Click(object sender, EventArgs e)
        {
            ac.Screenshot();
        }

        public String GetProxy()
        {
            return proxy;
        }
        public bool ProxyEnabled()
        {
            return proxyEnabled;
        }
        public String GetProfile()
        {
            return profile;
        }
        public bool ProfileEnabled()
        {
            return profileEnabled;
        }
        public bool HeadlessEnabled()
        {
            return headlessEnabled;
        }
        public String GetUrl()
        {
            return url;
        }
        public String GetComputerName()
        {
            return computerName;
        }

        
    }
}
