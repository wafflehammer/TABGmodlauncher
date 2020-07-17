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
        private bool check_path()
        {

            try
            {
                if (File.Exists(Path.GetTempPath() + @"tmlsettings.txt"))
                {

                    gamePath = File.ReadAllText(Path.GetTempPath() + @"tmlsettings.txt");
                    return true;
                }
                else
                {
                    gamePath = @"C:/Program Files (x86)/Steam/steamapps/common/TotallyAccurateBattlegrounds";

                    if (System.IO.File.Exists(Path.Combine(gamePath,"TotallyAccurateBattlegrounds.exe")))
                    {
                        MessageBox.Show("Found Tabg Install Directory!!  You Good to go Fam!");
                        File.WriteAllText(Path.GetTempPath() + @"tmlsettings.txt", gamePath);
                        return true;

                    }
                    else
                    {
                        string filePath = openFileDialog1.InitialDirectory = @"C:/Program Files (x86)/Steam/steamapps/common/TotallyAccurateBattlegrounds";
                        openFileDialog1.Filter = "TABG Executable|TotallyAccurateBattlegrounds.exe";

                        if (openFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            gamePath = openFileDialog1.FileName;
                            gamePath = Path.GetDirectoryName(gamePath);
                            if (Directory.Exists(gamePath))
                            {
                                File.WriteAllText(Path.GetTempPath() + @"tmlsettings.txt", gamePath);
                                return true;
                            }
                            else
                            {
                                MessageBox.Show("Game Path was not found, though it was read (incorrectly?) from tmlsettings.txt file...wat in the fuck did you do?", "niggers");
                                return false;
                            }

                   
                        }
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "you fucked something up");
                return false;
            }



        }
        private void launch_Click(object sender, EventArgs e)
        {
            if (!check_path())
            {
                return;
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
                MessageBox.Show(excp1.ToString(), "fuckin niggers ask miley about this on the Discord!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Launcher_Load(object sender, EventArgs e)
        {
            if (check_path())
                installDirectory.Text = gamePath;
            else
                MessageBox.Show("failed to find game directory despite every attempt to hold your hand...", "you fuckin idiot");
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
                        foreach (System.Diagnostics.Process proc in System.Diagnostics.Process.GetProcessesByName("agent"))
                        {
                            proc.Kill();
                        }
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
