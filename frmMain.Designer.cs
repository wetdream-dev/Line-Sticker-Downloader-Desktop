namespace LineStickerDownloader
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pWindow = new System.Windows.Forms.Panel();
            this.lblTitleApp = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pMinimize = new System.Windows.Forms.Panel();
            this.lblMinimize = new System.Windows.Forms.Label();
            this.pClose = new System.Windows.Forms.Panel();
            this.lblClose = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblLog = new System.Windows.Forms.Label();
            this.pDownload = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pbPreviewImg = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gbDownloadPanel = new System.Windows.Forms.GroupBox();
            this.btnSticker = new System.Windows.Forms.PictureBox();
            this.btnEmoji = new System.Windows.Forms.PictureBox();
            this.btnOpenFolder = new System.Windows.Forms.Button();
            this.lblHelp2 = new System.Windows.Forms.Label();
            this.lblHelp = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.btnDownload = new System.Windows.Forms.Button();
            this.tbID = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ttEmoji = new System.Windows.Forms.ToolTip(this.components);
            this.ttSticker = new System.Windows.Forms.ToolTip(this.components);
            this.pWindow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pMinimize.SuspendLayout();
            this.pClose.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreviewImg)).BeginInit();
            this.gbDownloadPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSticker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEmoji)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pWindow
            // 
            this.pWindow.Controls.Add(this.lblTitleApp);
            this.pWindow.Controls.Add(this.pictureBox1);
            this.pWindow.Controls.Add(this.pMinimize);
            this.pWindow.Controls.Add(this.pClose);
            this.pWindow.Dock = System.Windows.Forms.DockStyle.Top;
            this.pWindow.Location = new System.Drawing.Point(0, 0);
            this.pWindow.Name = "pWindow";
            this.pWindow.Size = new System.Drawing.Size(362, 32);
            this.pWindow.TabIndex = 0;
            this.pWindow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pWindow_MouseDown);
            this.pWindow.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pWindow_MouseMove);
            this.pWindow.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pWindow_MouseUp);
            // 
            // lblTitleApp
            // 
            this.lblTitleApp.AutoSize = true;
            this.lblTitleApp.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleApp.ForeColor = System.Drawing.Color.White;
            this.lblTitleApp.Location = new System.Drawing.Point(46, 7);
            this.lblTitleApp.Name = "lblTitleApp";
            this.lblTitleApp.Size = new System.Drawing.Size(172, 19);
            this.lblTitleApp.TabIndex = 3;
            this.lblTitleApp.Text = "Line Sticker Downloader";
            this.lblTitleApp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblTitleApp_MouseDown);
            this.lblTitleApp.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblTitleApp_MouseMove);
            this.lblTitleApp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblTitleApp_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pMinimize
            // 
            this.pMinimize.Controls.Add(this.lblMinimize);
            this.pMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.pMinimize.Location = new System.Drawing.Point(298, 0);
            this.pMinimize.Name = "pMinimize";
            this.pMinimize.Size = new System.Drawing.Size(32, 32);
            this.pMinimize.TabIndex = 1;
            this.pMinimize.Click += new System.EventHandler(this.pMinimize_Click);
            this.pMinimize.MouseEnter += new System.EventHandler(this.pMinimize_MouseEnter);
            this.pMinimize.MouseLeave += new System.EventHandler(this.pMinimize_MouseLeave);
            // 
            // lblMinimize
            // 
            this.lblMinimize.AutoSize = true;
            this.lblMinimize.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimize.ForeColor = System.Drawing.Color.White;
            this.lblMinimize.Location = new System.Drawing.Point(5, 1);
            this.lblMinimize.Name = "lblMinimize";
            this.lblMinimize.Size = new System.Drawing.Size(23, 31);
            this.lblMinimize.TabIndex = 4;
            this.lblMinimize.Text = "-";
            this.lblMinimize.Click += new System.EventHandler(this.lblMinimize_Click);
            this.lblMinimize.MouseEnter += new System.EventHandler(this.lblMinimize_MouseEnter);
            this.lblMinimize.MouseLeave += new System.EventHandler(this.lblMinimize_MouseLeave);
            // 
            // pClose
            // 
            this.pClose.Controls.Add(this.lblClose);
            this.pClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.pClose.Location = new System.Drawing.Point(330, 0);
            this.pClose.Name = "pClose";
            this.pClose.Size = new System.Drawing.Size(32, 32);
            this.pClose.TabIndex = 0;
            this.pClose.Click += new System.EventHandler(this.pClose_Click);
            this.pClose.MouseEnter += new System.EventHandler(this.pClose_MouseEnter);
            this.pClose.MouseLeave += new System.EventHandler(this.pClose_MouseLeave);
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.White;
            this.lblClose.Location = new System.Drawing.Point(7, 6);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(19, 20);
            this.lblClose.TabIndex = 5;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            this.lblClose.MouseEnter += new System.EventHandler(this.lblClose_MouseEnter);
            this.lblClose.MouseLeave += new System.EventHandler(this.lblClose_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.panel2.Controls.Add(this.pWindow);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(362, 587);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.lblLog);
            this.panel3.Controls.Add(this.pDownload);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.groupBox3);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.gbDownloadPanel);
            this.panel3.Controls.Add(this.menuStrip1);
            this.panel3.Location = new System.Drawing.Point(5, 35);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(352, 546);
            this.panel3.TabIndex = 1;
            // 
            // lblLog
            // 
            this.lblLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLog.ForeColor = System.Drawing.Color.White;
            this.lblLog.Location = new System.Drawing.Point(17, 462);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(318, 23);
            this.lblLog.TabIndex = 0;
            this.lblLog.Text = "◈ Iddle ◈ ";
            this.lblLog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pDownload
            // 
            this.pDownload.Location = new System.Drawing.Point(17, 441);
            this.pDownload.Name = "pDownload";
            this.pDownload.Size = new System.Drawing.Size(318, 15);
            this.pDownload.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(147, 529);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 11);
            this.label2.TabIndex = 0;
            this.label2.Text = "Version : 1.3.2.1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblTitle);
            this.groupBox3.Controls.Add(this.pbPreviewImg);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(17, 219);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(318, 216);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Preview";
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(70, 169);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(178, 44);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pbPreviewImg
            // 
            this.pbPreviewImg.Location = new System.Drawing.Point(95, 32);
            this.pbPreviewImg.Name = "pbPreviewImg";
            this.pbPreviewImg.Size = new System.Drawing.Size(128, 128);
            this.pbPreviewImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPreviewImg.TabIndex = 0;
            this.pbPreviewImg.TabStop = false;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(0, 513);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(352, 33);
            this.label8.TabIndex = 0;
            this.label8.Text = "Created with ❤️ by WetDream";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // gbDownloadPanel
            // 
            this.gbDownloadPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDownloadPanel.Controls.Add(this.btnSticker);
            this.gbDownloadPanel.Controls.Add(this.btnEmoji);
            this.gbDownloadPanel.Controls.Add(this.btnOpenFolder);
            this.gbDownloadPanel.Controls.Add(this.lblHelp2);
            this.gbDownloadPanel.Controls.Add(this.lblHelp);
            this.gbDownloadPanel.Controls.Add(this.cbType);
            this.gbDownloadPanel.Controls.Add(this.lblType);
            this.gbDownloadPanel.Controls.Add(this.lblID);
            this.gbDownloadPanel.Controls.Add(this.btnDownload);
            this.gbDownloadPanel.Controls.Add(this.tbID);
            this.gbDownloadPanel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gbDownloadPanel.Location = new System.Drawing.Point(17, 47);
            this.gbDownloadPanel.Name = "gbDownloadPanel";
            this.gbDownloadPanel.Size = new System.Drawing.Size(318, 166);
            this.gbDownloadPanel.TabIndex = 0;
            this.gbDownloadPanel.TabStop = false;
            this.gbDownloadPanel.Text = "Sticker Download";
            // 
            // btnSticker
            // 
            this.btnSticker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSticker.Image = ((System.Drawing.Image)(resources.GetObject("btnSticker.Image")));
            this.btnSticker.Location = new System.Drawing.Point(6, 135);
            this.btnSticker.Name = "btnSticker";
            this.btnSticker.Size = new System.Drawing.Size(20, 20);
            this.btnSticker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSticker.TabIndex = 5;
            this.btnSticker.TabStop = false;
            this.ttSticker.SetToolTip(this.btnSticker, "Sticker Download");
            this.btnSticker.Visible = false;
            this.btnSticker.Click += new System.EventHandler(this.btnSticker_Click);
            // 
            // btnEmoji
            // 
            this.btnEmoji.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmoji.Image = ((System.Drawing.Image)(resources.GetObject("btnEmoji.Image")));
            this.btnEmoji.Location = new System.Drawing.Point(292, 135);
            this.btnEmoji.Name = "btnEmoji";
            this.btnEmoji.Size = new System.Drawing.Size(20, 20);
            this.btnEmoji.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEmoji.TabIndex = 4;
            this.btnEmoji.TabStop = false;
            this.ttEmoji.SetToolTip(this.btnEmoji, "Emoji Download");
            this.btnEmoji.Click += new System.EventHandler(this.btnEmoji_Click);
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnOpenFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenFolder.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenFolder.ForeColor = System.Drawing.Color.White;
            this.btnOpenFolder.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenFolder.Image")));
            this.btnOpenFolder.Location = new System.Drawing.Point(216, 103);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(35, 25);
            this.btnOpenFolder.TabIndex = 4;
            this.btnOpenFolder.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnOpenFolder.UseVisualStyleBackColor = false;
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // lblHelp2
            // 
            this.lblHelp2.AutoSize = true;
            this.lblHelp2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblHelp2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelp2.ForeColor = System.Drawing.Color.White;
            this.lblHelp2.Location = new System.Drawing.Point(249, 38);
            this.lblHelp2.Name = "lblHelp2";
            this.lblHelp2.Size = new System.Drawing.Size(15, 19);
            this.lblHelp2.TabIndex = 0;
            this.lblHelp2.Text = "?";
            this.lblHelp2.Click += new System.EventHandler(this.lblHelp2_Click);
            // 
            // lblHelp
            // 
            this.lblHelp.AutoSize = true;
            this.lblHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblHelp.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelp.ForeColor = System.Drawing.Color.White;
            this.lblHelp.Location = new System.Drawing.Point(249, 66);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(15, 19);
            this.lblHelp.TabIndex = 0;
            this.lblHelp.Text = "?";
            this.lblHelp.Click += new System.EventHandler(this.lblHelp_Click);
            // 
            // cbType
            // 
            this.cbType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(64)))));
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.ForeColor = System.Drawing.Color.White;
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(136, 64);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(107, 21);
            this.cbType.TabIndex = 2;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.ForeColor = System.Drawing.Color.White;
            this.lblType.Location = new System.Drawing.Point(55, 66);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(76, 15);
            this.lblType.TabIndex = 0;
            this.lblType.Text = "Sticker Type :";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.Location = new System.Drawing.Point(55, 39);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(62, 15);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "Sticker ID :";
            // 
            // btnDownload
            // 
            this.btnDownload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownload.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownload.ForeColor = System.Drawing.Color.White;
            this.btnDownload.Location = new System.Drawing.Point(68, 103);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(142, 25);
            this.btnDownload.TabIndex = 3;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = false;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // tbID
            // 
            this.tbID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(64)))));
            this.tbID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbID.ForeColor = System.Drawing.Color.White;
            this.tbID.Location = new System.Drawing.Point(136, 38);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(107, 20);
            this.tbID.TabIndex = 1;
            this.tbID.TextChanged += new System.EventHandler(this.tbIDSticker_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.changeLogToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(352, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // changeLogToolStripMenuItem
            // 
            this.changeLogToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.changeLogToolStripMenuItem.Name = "changeLogToolStripMenuItem";
            this.changeLogToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.changeLogToolStripMenuItem.Text = "Change Log";
            this.changeLogToolStripMenuItem.Click += new System.EventHandler(this.changeLogToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // ttEmoji
            // 
            this.ttEmoji.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(64)))));
            this.ttEmoji.ForeColor = System.Drawing.Color.White;
            // 
            // ttSticker
            // 
            this.ttSticker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(64)))));
            this.ttSticker.ForeColor = System.Drawing.Color.White;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 587);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Line Sticker Downloader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pWindow.ResumeLayout(false);
            this.pWindow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pMinimize.ResumeLayout(false);
            this.pMinimize.PerformLayout();
            this.pClose.ResumeLayout(false);
            this.pClose.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPreviewImg)).EndInit();
            this.gbDownloadPanel.ResumeLayout(false);
            this.gbDownloadPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSticker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEmoji)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pWindow;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pMinimize;
        private System.Windows.Forms.Panel pClose;
        private System.Windows.Forms.Label lblTitleApp;
        private System.Windows.Forms.Label lblMinimize;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.GroupBox gbDownloadPanel;
        private System.Windows.Forms.Label lblHelp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pbPreviewImg;
        public System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOpenFolder;
        private System.Windows.Forms.Label lblHelp2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeLogToolStripMenuItem;
        private System.Windows.Forms.ProgressBar pDownload;
        private System.Windows.Forms.Label lblLog;
        private System.Windows.Forms.PictureBox btnSticker;
        private System.Windows.Forms.PictureBox btnEmoji;
        private System.Windows.Forms.ToolTip ttEmoji;
        private System.Windows.Forms.ToolTip ttSticker;
    }
}

