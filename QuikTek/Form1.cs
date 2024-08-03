using System.Diagnostics;
using System.Net;

namespace QuikTek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Calls for the system info application
        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("msinfo32.exe");
        }
        //Calls the control panel
        private void control_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("control.exe");
        }
        //Restarts computer. To shutdown PC remove the /r(restart) and replace with /s for shutdown
        private void restartbtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to restart the computer?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                // the /r stands for restart and /s will shutdown 
                var psi = new ProcessStartInfo("shutdown", "/r /t 0");
                psi.CreateNoWindow = true;
                psi.UseShellExecute = false;
                Process.Start(psi);
            }
        }
        // this uses the underlying method used in the ipconfig command. It finds its own IP that has been assigned via DHCP
        private void button1_Click_1(object sender, EventArgs e)
        {
            string textToCopy = "This ticket will remain open for 1 more day. If no reply this ticket will be considered reolved and closed";
            Clipboard.SetText(textToCopy);
            MessageBox.Show("Script copied");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string hostName = Dns.GetHostName();

            // Get the IP address
            IPAddress[] ipAddresses = Dns.GetHostAddresses(hostName);
            //must be null to accept that not having an IP may be an option
            IPAddress ipAddress = null;

            // Find the first IPv4 address
            foreach (IPAddress ip in ipAddresses)
            {
                if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    ipAddress = ip;
                    break;
                }
            }

            // Show the IP address in a message box
            if (ipAddress != null)
            {
                MessageBox.Show("IP Address: " + ipAddress.ToString());
            }
            else
            {
                MessageBox.Show("No IPv4 address found. You may not be online. Please check your internet connection or VPN connection.");
            }
            //copy IP to clipboard and let user know they can know paste it as a response
            string copymyIP = ipAddress.ToString();
            Clipboard.SetText(copymyIP);
            MessageBox.Show("Your IP is copied to clipboard.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to shutdown the computer?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                
                var psi = Process.Start("shutdown", "/s /t 0");
            }
        }
    }
}