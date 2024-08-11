using Microsoft.VisualBasic.ApplicationServices;
using System.Diagnostics;
using System.Net;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;
using System;

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
        private void button2_Click(object sender, EventArgs e)
        {
            string hostName = Dns.GetHostName();
            // Get the IP address
            IPAddress[] ipAddresses = Dns.GetHostAddresses(hostName);
            //must be null to accept that not having an IP may be an option
            IPAddress ipAddress = null;
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
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string url = textBox1.Text;
                IPAddress[] addresses = Dns.GetHostAddresses(url);

                linkLabel1.Text = "IP Address: " + addresses[0].ToString();

                string ipAddress = addresses[0].ToString();
                Clipboard.SetText(ipAddress);
                MessageBox.Show(ipAddress + "\n IP is copied to clipboard ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            using (FolderBrowserDialog ProfileSnatch = new FolderBrowserDialog())
            {
                // be sure to add the last "\" else it sleects the current logged in user for some stupid reason 
                ProfileSnatch.SelectedPath = @"C:\Users\";
                //Opens the file explorer 
                DialogResult result = ProfileSnatch.ShowDialog();
                //choose the profile to transfer 
                string selectedDirectory = ProfileSnatch.SelectedPath;
                DialogResult choice = MessageBox.Show("You selected: " + selectedDirectory, "Directory Selected", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.OK && choice == DialogResult.Yes)
                {
                    string destinationFolder = @"C:\Atesting\"; // Change this to your desired destination folder
                    // Change name of compressed folder to directory name.zip
                    string zipFileName = Path.GetFileName(selectedDirectory) + ".zip";
                    string zipFilePath = Path.Combine(destinationFolder, zipFileName);
                    // Zip the selected directory
                    try
                    {
                        ZipFile.CreateFromDirectory(selectedDirectory, zipFilePath);
                    }
                    catch (UnauthorizedAccessException ex)
                    {
                        MessageBox.Show("Access denied: " + ex.Message);
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show("I/O error: " + ex.Message);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                    // set path of zip folder to a string 
                    string destinationPath = Path.Combine(destinationFolder, Path.GetFileName(zipFilePath));
                    // Transfer the zipped file to the destination folder
                    File.Move(zipFilePath, destinationPath);
                    //
                    MessageBox.Show("Directory zipped and transferred successfully!" + zipFilePath);
                }
                // if user decides they got the wrong folder then they can reset the dialog back to the profiles upon clicking no or cancel
                else
                {
                    ProfileSnatch.ShowDialog(this);
                }
            }
        }
    }
}
