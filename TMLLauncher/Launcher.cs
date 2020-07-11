using System;
using System.IO;
using System.Net;
using System.Windows.Forms;
using System.ComponentModel;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace TML
{
    public partial class Launcher : Form
    {
        public Launcher()
        {
            InitializeComponent();
            mods = false;
            gameOriginal.Checked = true;

        }

        public bool mods = false;
        public string gamePath = "";

        private void launch_Click(object sender, EventArgs e)
        {
            try
            {
                gamePath = File.ReadAllText(Path.GetTempPath() + @"tmlsettings.txt");
                {
                    if (!System.IO.Directory.Exists(gamePath))
                    {


                        string filePath = openFileDialog1.InitialDirectory = "C:\\Program Files(x86)\\Steam\\steamapps\\common\\TotallyAccurateBattlegrounds";
                        openFileDialog1.Filter = "TABG Executable|TotallyAccurateBattlegrounds.exe";

                        if (openFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            gamePath = openFileDialog1.FileName;
                            gamePath = Path.GetDirectoryName(gamePath);
                            File.WriteAllText(Path.GetTempPath() + @"tmlsettings.txt", gamePath);

                        }
                    }
                }
                launch.Enabled = true;
                if (gameOriginal.Checked)
                {
                    mods = false;
                }
                else
                {
                    mods = true;
                }
            }
            catch
            { }

            try
            {
                if (File.Exists(Path.GetTempPath() + @"dl.dll"))
                {
                    File.Delete(Path.GetTempPath() + @"dl.dll");
                }

                if (mods)
                {
                    DownloadFile(@"http://github.com/Audixas/TabgGunGame/raw/master/Assembly-CSharp.dll", Path.GetTempPath() + @"dl.dll");
                }
                else
                {
                    DownloadFile(@"http://github.com/Audixas/TabgGunGame/raw/master/latest.dll", Path.GetTempPath() + @"dl.dll");
                }

                gamePath = System.IO.File.ReadAllText(Path.GetTempPath() + @"tmlsettings.txt").ToString();
            }
            catch (Exception excp1)
            {
                MessageBox.Show(excp1.ToString(), "Frickin heck. Report this to the Discord!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Launcher_Load(object sender, EventArgs e)
        {
            if (System.IO.File.Exists((Path.GetTempPath() + @"tmlsettings.txt")))
                gamePath = File.ReadAllText(Path.GetTempPath() + @"tmlsettings.txt");
            else

            {
                gamePath = "";
                MessageBox.Show("Game directory not found. You probably have a non-standard Steam install directory. Choose the location where TABG is installed.", "Game directory not found", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                openFileDialog1.Filter = "TABG Executable|TotallyAccurateBattlegrounds.exe";
                gamePath = openFileDialog1.InitialDirectory;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {


                    gamePath = openFileDialog1.FileName;
                    gamePath = Path.GetDirectoryName(gamePath);
                    File.WriteAllText(Path.GetTempPath() + @"tmlsettings.txt", gamePath);

                }
            }
            installDirectory.Text = gamePath;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            // File.Delete(Path.GetTempPath() + @"\.TML");
            System.Diagnostics.Process.Start(Directory.GetCurrentDirectory() + @"\TML.exe");
            Application.Exit();
        }

        public void DownloadFile(string urlAddress, string location)
        {
            using (WebClient webClient = new WebClient())
            {
                webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);

                // The variable that will be holding the url address (making sure it starts with http://)
                Uri URL = urlAddress.StartsWith("http://", StringComparison.OrdinalIgnoreCase) ? new Uri(urlAddress) : new Uri("http://" + urlAddress);

                try
                {
                    // Start downloading the file
                    webClient.DownloadFileAsync(URL, location);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // The event that will fire whenever the progress of the WebClient is changed
        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            // Update the progressbar percentage only when the value is not the same.
            downloadBar.Value = e.ProgressPercentage;
        }

        // The event that will trigger when the WebClient is completed
        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
                MessageBox.Show("Download has been canceled.");
            }
            else
            {
                try
                {
                    System.IO.File.Copy(Path.GetTempPath() + @"dl.dll", gamePath + @"\TotallyAccurateBattlegrounds_Data\Managed\Assembly-CSharp.dll", true);
                    File.Delete(Path.GetTempPath() + @"dl.dll");
                    try
                    {
                        System.Diagnostics.Process.Start(@"steam://rungameid/823130");
                        Application.Exit();
                    }
                    catch
                    {
                        MessageBox.Show("Error :c", "Couldn't launch game.\nIs Steam installed?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception x)
                {
                    MessageBox.Show("Unable to copy DLL file\n" + x, "Error :c", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void discordButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/6Vex6wT");
        }
    }
}
