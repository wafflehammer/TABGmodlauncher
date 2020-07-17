namespace TML
{
    partial class Launcher
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Launcher));
            this.launch = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.downloadBar = new System.Windows.Forms.ProgressBar();
            this.modChooser = new System.Windows.Forms.GroupBox();
            this.gameBrawlGG = new System.Windows.Forms.RadioButton();
            this.gameOriginal = new System.Windows.Forms.RadioButton();
            this.discordButton = new System.Windows.Forms.Button();
            this.installDirectoryDisplay = new System.Windows.Forms.GroupBox();
            this.installDirectory = new System.Windows.Forms.Label();
            this.launchHeadless = new System.Windows.Forms.Button();
            this.killHeadless = new System.Windows.Forms.Button();
            this.modChooser.SuspendLayout();
            this.installDirectoryDisplay.SuspendLayout();
            this.SuspendLayout();
            // 
            // launch
            // 
            this.launch.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.launch.BackColor = System.Drawing.Color.Transparent;
            this.launch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.launch.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.launch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.launch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.launch.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.launch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.launch.Location = new System.Drawing.Point(9, 380);
            this.launch.Margin = new System.Windows.Forms.Padding(2);
            this.launch.Name = "launch";
            this.launch.Size = new System.Drawing.Size(244, 54);
            this.launch.TabIndex = 2;
            this.launch.Text = "Launch Game";
            this.launch.UseVisualStyleBackColor = false;
            this.launch.Click += new System.EventHandler(this.launch_Click);
            // 
            // downloadBar
            // 
            this.downloadBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.downloadBar.BackColor = System.Drawing.Color.MediumAquamarine;
            this.downloadBar.Location = new System.Drawing.Point(9, 439);
            this.downloadBar.Name = "downloadBar";
            this.downloadBar.Size = new System.Drawing.Size(415, 18);
            this.downloadBar.TabIndex = 17;
            // 
            // modChooser
            // 
            this.modChooser.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.modChooser.BackColor = System.Drawing.Color.Transparent;
            this.modChooser.Controls.Add(this.gameBrawlGG);
            this.modChooser.Controls.Add(this.gameOriginal);
            this.modChooser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modChooser.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.modChooser.Location = new System.Drawing.Point(9, 313);
            this.modChooser.Name = "modChooser";
            this.modChooser.Size = new System.Drawing.Size(415, 57);
            this.modChooser.TabIndex = 18;
            this.modChooser.TabStop = false;
            this.modChooser.Text = "Gamemode:";
            // 
            // gameBrawlGG
            // 
            this.gameBrawlGG.AutoSize = true;
            this.gameBrawlGG.Checked = true;
            this.gameBrawlGG.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameBrawlGG.Location = new System.Drawing.Point(248, 24);
            this.gameBrawlGG.Name = "gameBrawlGG";
            this.gameBrawlGG.Size = new System.Drawing.Size(131, 21);
            this.gameBrawlGG.TabIndex = 20;
            this.gameBrawlGG.TabStop = true;
            this.gameBrawlGG.Text = "Brawl / Gun Game";
            this.gameBrawlGG.UseVisualStyleBackColor = true;
            // 
            // gameOriginal
            // 
            this.gameOriginal.AutoSize = true;
            this.gameOriginal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOriginal.Location = new System.Drawing.Point(82, 24);
            this.gameOriginal.Name = "gameOriginal";
            this.gameOriginal.Size = new System.Drawing.Size(72, 21);
            this.gameOriginal.TabIndex = 19;
            this.gameOriginal.Text = "Original";
            this.gameOriginal.UseVisualStyleBackColor = true;
            // 
            // discordButton
            // 
            this.discordButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.discordButton.BackColor = System.Drawing.Color.Transparent;
            this.discordButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.discordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.discordButton.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discordButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.discordButton.Image = global::TML.Properties.Resources.discord;
            this.discordButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.discordButton.Location = new System.Drawing.Point(12, 20);
            this.discordButton.Name = "discordButton";
            this.discordButton.Size = new System.Drawing.Size(151, 43);
            this.discordButton.TabIndex = 61;
            this.discordButton.Text = "Join our Discord!";
            this.discordButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.discordButton.UseVisualStyleBackColor = false;
            this.discordButton.Click += new System.EventHandler(this.discordButton_Click);
            // 
            // installDirectoryDisplay
            // 
            this.installDirectoryDisplay.BackColor = System.Drawing.Color.Transparent;
            this.installDirectoryDisplay.Controls.Add(this.installDirectory);
            this.installDirectoryDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.installDirectoryDisplay.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.installDirectoryDisplay.Location = new System.Drawing.Point(9, 262);
            this.installDirectoryDisplay.Name = "installDirectoryDisplay";
            this.installDirectoryDisplay.Size = new System.Drawing.Size(415, 45);
            this.installDirectoryDisplay.TabIndex = 63;
            this.installDirectoryDisplay.TabStop = false;
            this.installDirectoryDisplay.Text = "Install directory:";
            // 
            // installDirectory
            // 
            this.installDirectory.AutoSize = true;
            this.installDirectory.Location = new System.Drawing.Point(6, 18);
            this.installDirectory.Name = "installDirectory";
            this.installDirectory.Size = new System.Drawing.Size(0, 16);
            this.installDirectory.TabIndex = 0;
            // 
            // launchHeadless
            // 
            this.launchHeadless.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.launchHeadless.BackColor = System.Drawing.Color.Transparent;
            this.launchHeadless.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.launchHeadless.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.launchHeadless.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.launchHeadless.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.launchHeadless.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.launchHeadless.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.launchHeadless.Location = new System.Drawing.Point(257, 380);
            this.launchHeadless.Margin = new System.Windows.Forms.Padding(2);
            this.launchHeadless.Name = "launchHeadless";
            this.launchHeadless.Size = new System.Drawing.Size(167, 25);
            this.launchHeadless.TabIndex = 64;
            this.launchHeadless.Text = "Launch Headless Client";
            this.launchHeadless.UseVisualStyleBackColor = false;
            this.launchHeadless.Click += new System.EventHandler(this.launchHeadless_Click);
            // 
            // killHeadless
            // 
            this.killHeadless.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.killHeadless.BackColor = System.Drawing.Color.Transparent;
            this.killHeadless.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.killHeadless.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.killHeadless.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.killHeadless.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.killHeadless.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.killHeadless.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.killHeadless.Location = new System.Drawing.Point(257, 409);
            this.killHeadless.Margin = new System.Windows.Forms.Padding(2);
            this.killHeadless.Name = "killHeadless";
            this.killHeadless.Size = new System.Drawing.Size(167, 25);
            this.killHeadless.TabIndex = 65;
            this.killHeadless.Text = "Kill Headless Client(s)";
            this.killHeadless.UseVisualStyleBackColor = false;
            this.killHeadless.Click += new System.EventHandler(this.killHeadless_Click);
            // 
            // Launcher
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::TML.Properties.Resources.gradient;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(434, 461);
            this.Controls.Add(this.killHeadless);
            this.Controls.Add(this.launchHeadless);
            this.Controls.Add(this.installDirectoryDisplay);
            this.Controls.Add(this.discordButton);
            this.Controls.Add(this.modChooser);
            this.Controls.Add(this.downloadBar);
            this.Controls.Add(this.launch);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Launcher";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "TABG Mod Launcher";
            this.Load += new System.EventHandler(this.Launcher_Load);
            this.modChooser.ResumeLayout(false);
            this.modChooser.PerformLayout();
            this.installDirectoryDisplay.ResumeLayout(false);
            this.installDirectoryDisplay.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button launch;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ProgressBar downloadBar;
        private System.Windows.Forms.GroupBox modChooser;
        private System.Windows.Forms.RadioButton gameBrawlGG;
        private System.Windows.Forms.RadioButton gameOriginal;
        private System.Windows.Forms.Button discordButton;
        private System.Windows.Forms.GroupBox installDirectoryDisplay;
        private System.Windows.Forms.Label installDirectory;
        private System.Windows.Forms.Button launchHeadless;
        private System.Windows.Forms.Button killHeadless;
    }
}

