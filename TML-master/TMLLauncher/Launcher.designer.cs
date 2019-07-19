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
            this.titleLabel = new System.Windows.Forms.Label();
            this.changeDir = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.downloadBar = new System.Windows.Forms.ProgressBar();
            this.modChooser = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.commName = new System.Windows.Forms.Label();
            this.commSupport = new System.Windows.Forms.Label();
            this.audixas = new System.Windows.Forms.Label();
            this.polarnf = new System.Windows.Forms.Label();
            this.mfc = new System.Windows.Forms.Label();
            this.testAndFeed = new System.Windows.Forms.Label();
            this.mhnd = new System.Windows.Forms.Label();
            this.dev = new System.Windows.Forms.Label();
            this.aboutLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.modChooser.SuspendLayout();
            this.SuspendLayout();
            // 
            // launch
            // 
            this.launch.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.launch.BackColor = System.Drawing.Color.Transparent;
            this.launch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.launch.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.launch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.launch.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.launch.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.launch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.launch.Location = new System.Drawing.Point(669, 406);
            this.launch.Margin = new System.Windows.Forms.Padding(2);
            this.launch.Name = "launch";
            this.launch.Size = new System.Drawing.Size(341, 50);
            this.launch.TabIndex = 2;
            this.launch.Text = "Launch Game";
            this.launch.UseVisualStyleBackColor = false;
            this.launch.Click += new System.EventHandler(this.launch_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.CadetBlue;
            this.titleLabel.Location = new System.Drawing.Point(283, 8);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(468, 65);
            this.titleLabel.TabIndex = 14;
            this.titleLabel.Text = "TABG MOD LOADER";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // changeDir
            // 
            this.changeDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.changeDir.BackColor = System.Drawing.Color.Transparent;
            this.changeDir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeDir.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeDir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.changeDir.Location = new System.Drawing.Point(918, 20);
            this.changeDir.Name = "changeDir";
            this.changeDir.Size = new System.Drawing.Size(136, 47);
            this.changeDir.TabIndex = 15;
            this.changeDir.Text = "Choose Installation Directory";
            this.changeDir.UseVisualStyleBackColor = false;
            this.changeDir.Click += new System.EventHandler(this.Button2_Click);
            // 
            // downloadBar
            // 
            this.downloadBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.downloadBar.BackColor = System.Drawing.Color.MediumAquamarine;
            this.downloadBar.Location = new System.Drawing.Point(12, 461);
            this.downloadBar.Name = "downloadBar";
            this.downloadBar.Size = new System.Drawing.Size(1042, 10);
            this.downloadBar.TabIndex = 17;
            // 
            // modChooser
            // 
            this.modChooser.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.modChooser.BackColor = System.Drawing.Color.Transparent;
            this.modChooser.Controls.Add(this.radioButton2);
            this.modChooser.Controls.Add(this.radioButton1);
            this.modChooser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modChooser.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.modChooser.Location = new System.Drawing.Point(57, 398);
            this.modChooser.Name = "modChooser";
            this.modChooser.Size = new System.Drawing.Size(607, 57);
            this.modChooser.TabIndex = 18;
            this.modChooser.TabStop = false;
            this.modChooser.Text = "Gamemode";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(6, 36);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(77, 21);
            this.radioButton2.TabIndex = 20;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Modded";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(6, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(63, 21);
            this.radioButton1.TabIndex = 19;
            this.radioButton1.Text = "Vanilla";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // commName
            // 
            this.commName.AutoSize = true;
            this.commName.BackColor = System.Drawing.Color.Transparent;
            this.commName.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commName.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.commName.Location = new System.Drawing.Point(31, 263);
            this.commName.Name = "commName";
            this.commName.Size = new System.Drawing.Size(136, 20);
            this.commName.TabIndex = 34;
            this.commName.Text = "TABG\'s Last Hope";
            // 
            // commSupport
            // 
            this.commSupport.AutoSize = true;
            this.commSupport.BackColor = System.Drawing.Color.Transparent;
            this.commSupport.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commSupport.ForeColor = System.Drawing.SystemColors.Control;
            this.commSupport.Location = new System.Drawing.Point(18, 242);
            this.commSupport.Name = "commSupport";
            this.commSupport.Size = new System.Drawing.Size(154, 21);
            this.commSupport.TabIndex = 33;
            this.commSupport.Text = "Community Support";
            // 
            // audixas
            // 
            this.audixas.AutoSize = true;
            this.audixas.BackColor = System.Drawing.Color.Transparent;
            this.audixas.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.audixas.ForeColor = System.Drawing.Color.YellowGreen;
            this.audixas.Location = new System.Drawing.Point(31, 211);
            this.audixas.Name = "audixas";
            this.audixas.Size = new System.Drawing.Size(67, 20);
            this.audixas.TabIndex = 32;
            this.audixas.Text = "Audixas";
            // 
            // polarnf
            // 
            this.polarnf.AutoSize = true;
            this.polarnf.BackColor = System.Drawing.Color.Transparent;
            this.polarnf.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.polarnf.ForeColor = System.Drawing.Color.Yellow;
            this.polarnf.Location = new System.Drawing.Point(31, 191);
            this.polarnf.Name = "polarnf";
            this.polarnf.Size = new System.Drawing.Size(67, 20);
            this.polarnf.TabIndex = 31;
            this.polarnf.Text = "PolarNF";
            // 
            // mfc
            // 
            this.mfc.AutoSize = true;
            this.mfc.BackColor = System.Drawing.Color.Transparent;
            this.mfc.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mfc.ForeColor = System.Drawing.Color.DarkOrange;
            this.mfc.Location = new System.Drawing.Point(31, 171);
            this.mfc.Name = "mfc";
            this.mfc.Size = new System.Drawing.Size(113, 20);
            this.mfc.TabIndex = 30;
            this.mfc.Text = "amanda bynes";
            // 
            // testAndFeed
            // 
            this.testAndFeed.AutoSize = true;
            this.testAndFeed.BackColor = System.Drawing.Color.Transparent;
            this.testAndFeed.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testAndFeed.ForeColor = System.Drawing.SystemColors.Control;
            this.testAndFeed.Location = new System.Drawing.Point(14, 150);
            this.testAndFeed.Name = "testAndFeed";
            this.testAndFeed.Size = new System.Drawing.Size(164, 21);
            this.testAndFeed.TabIndex = 29;
            this.testAndFeed.Text = "Testing and Feedback";
            // 
            // mhnd
            // 
            this.mhnd.AutoSize = true;
            this.mhnd.BackColor = System.Drawing.Color.Transparent;
            this.mhnd.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mhnd.ForeColor = System.Drawing.Color.Salmon;
            this.mhnd.Location = new System.Drawing.Point(31, 116);
            this.mhnd.Name = "mhnd";
            this.mhnd.Size = new System.Drawing.Size(305, 20);
            this.mhnd.TabIndex = 28;
            this.mhnd.Text = "MichaelHasNoDad#0486 - MOD Launcher";
            // 
            // dev
            // 
            this.dev.AutoSize = true;
            this.dev.BackColor = System.Drawing.Color.Transparent;
            this.dev.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dev.ForeColor = System.Drawing.SystemColors.Control;
            this.dev.Location = new System.Drawing.Point(11, 66);
            this.dev.Name = "dev";
            this.dev.Size = new System.Drawing.Size(106, 21);
            this.dev.TabIndex = 27;
            this.dev.Text = "Development";
            // 
            // aboutLabel
            // 
            this.aboutLabel.AutoSize = true;
            this.aboutLabel.BackColor = System.Drawing.Color.Transparent;
            this.aboutLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.aboutLabel.Location = new System.Drawing.Point(8, 17);
            this.aboutLabel.Name = "aboutLabel";
            this.aboutLabel.Size = new System.Drawing.Size(90, 40);
            this.aboutLabel.TabIndex = 26;
            this.aboutLabel.Text = "About";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(31, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 20);
            this.label1.TabIndex = 39;
            this.label1.Text = "amanda bynes - Game MOD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(443, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 21);
            this.label2.TabIndex = 40;
            this.label2.Text = "MAD THANKS TO:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkOrange;
            this.label3.Location = new System.Drawing.Point(296, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 41;
            this.label3.Text = "Ape Lincoln";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkOrange;
            this.label4.Location = new System.Drawing.Point(355, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 42;
            this.label4.Text = "Saltique";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkOrange;
            this.label5.Location = new System.Drawing.Point(365, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 43;
            this.label5.Text = "Saber";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkOrange;
            this.label6.Location = new System.Drawing.Point(355, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 44;
            this.label6.Text = "Audixas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkOrange;
            this.label7.Location = new System.Drawing.Point(371, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 20);
            this.label7.TabIndex = 45;
            this.label7.Text = "Peen";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkOrange;
            this.label8.Location = new System.Drawing.Point(371, 303);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 20);
            this.label8.TabIndex = 46;
            this.label8.Text = "Polar";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkOrange;
            this.label9.Location = new System.Drawing.Point(452, 203);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 20);
            this.label9.TabIndex = 47;
            this.label9.Text = "Jurassic";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkOrange;
            this.label10.Location = new System.Drawing.Point(452, 223);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 20);
            this.label10.TabIndex = 48;
            this.label10.Text = "Huan";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkOrange;
            this.label11.Location = new System.Drawing.Point(452, 243);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 20);
            this.label11.TabIndex = 49;
            this.label11.Text = "GirthWormJim";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkOrange;
            this.label12.Location = new System.Drawing.Point(443, 263);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 20);
            this.label12.TabIndex = 50;
            this.label12.Text = "DildoBaggins";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DarkOrange;
            this.label13.Location = new System.Drawing.Point(443, 283);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 20);
            this.label13.TabIndex = 51;
            this.label13.Text = "Lolla Rossa";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.DarkOrange;
            this.label14.Location = new System.Drawing.Point(443, 303);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 20);
            this.label14.TabIndex = 52;
            this.label14.Text = "VarmintMan";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.DarkOrange;
            this.label15.Location = new System.Drawing.Point(608, 212);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 20);
            this.label15.TabIndex = 53;
            this.label15.Text = "Lad";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.DarkOrange;
            this.label16.Location = new System.Drawing.Point(593, 232);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(228, 20);
            this.label16.TabIndex = 54;
            this.label16.Text = "Yall Anime Fucks at LF general";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.DarkOrange;
            this.label17.Location = new System.Drawing.Point(584, 252);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(70, 20);
            this.label17.TabIndex = 55;
            this.label17.Text = "Ear Fluff";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.DarkOrange;
            this.label18.Location = new System.Drawing.Point(593, 272);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(69, 20);
            this.label18.TabIndex = 56;
            this.label18.Text = "MikeyDs";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.DarkOrange;
            this.label19.Location = new System.Drawing.Point(593, 292);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(49, 20);
            this.label19.TabIndex = 57;
            this.label19.Text = "Weed";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.DarkOrange;
            this.label20.Location = new System.Drawing.Point(371, 335);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(303, 20);
            this.label20.TabIndex = 58;
            this.label20.Text = "And you, you breathtaking mother fucker";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.linkLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.linkLabel1.Location = new System.Drawing.Point(463, 90);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(139, 17);
            this.linkLabel1.TabIndex = 59;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Join The TABG Discord!";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Launcher
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::TML.Properties.Resources.gradient;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1066, 483);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.commName);
            this.Controls.Add(this.commSupport);
            this.Controls.Add(this.audixas);
            this.Controls.Add(this.polarnf);
            this.Controls.Add(this.mfc);
            this.Controls.Add(this.testAndFeed);
            this.Controls.Add(this.mhnd);
            this.Controls.Add(this.dev);
            this.Controls.Add(this.aboutLabel);
            this.Controls.Add(this.modChooser);
            this.Controls.Add(this.downloadBar);
            this.Controls.Add(this.changeDir);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.launch);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(993, 522);
            this.Name = "Launcher";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "TML";
            this.Load += new System.EventHandler(this.Launcher_Load);
            this.modChooser.ResumeLayout(false);
            this.modChooser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button launch;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button changeDir;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ProgressBar downloadBar;
        private System.Windows.Forms.GroupBox modChooser;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label commName;
        private System.Windows.Forms.Label commSupport;
        private System.Windows.Forms.Label audixas;
        private System.Windows.Forms.Label polarnf;
        private System.Windows.Forms.Label mfc;
        private System.Windows.Forms.Label testAndFeed;
        private System.Windows.Forms.Label mhnd;
        private System.Windows.Forms.Label dev;
        private System.Windows.Forms.Label aboutLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

