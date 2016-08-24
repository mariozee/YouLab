using System.Windows.Forms;

namespace YouLab
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.playlistLabel = new MetroFramework.Controls.MetroLabel();
            this.downloadTypeLabel = new MetroFramework.Controls.MetroLabel();
            this.audioQualityLabel = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.playlistButton = new MetroFramework.Controls.MetroButton();
            this.signleMediaButton = new MetroFramework.Controls.MetroButton();
            this.audioButton = new MetroFramework.Controls.MetroButton();
            this.videoButton = new MetroFramework.Controls.MetroButton();
            this.audio64 = new MetroFramework.Controls.MetroLabel();
            this.audio128 = new MetroFramework.Controls.MetroLabel();
            this.audio192 = new MetroFramework.Controls.MetroLabel();
            this.audioQulityBar = new MetroFramework.Controls.MetroTrackBar();
            this.video360 = new MetroFramework.Controls.MetroLabel();
            this.video1080 = new MetroFramework.Controls.MetroLabel();
            this.video720 = new MetroFramework.Controls.MetroLabel();
            this.video480 = new MetroFramework.Controls.MetroLabel();
            this.videoQulityBar = new MetroFramework.Controls.MetroTrackBar();
            this.directoryTextBox = new MetroFramework.Controls.MetroTextBox();
            this.urlTextBox = new MetroFramework.Controls.MetroTextBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.tabs = new MetroFramework.Controls.MetroTabControl();
            this.mainTab = new MetroFramework.Controls.MetroTabPage();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.browseLink = new MetroFramework.Controls.MetroLink();
            this.downloadLink = new MetroFramework.Controls.MetroLink();
            this.aboutTab = new MetroFramework.Controls.MetroTabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.githubLink = new MetroFramework.Controls.MetroLink();
            this.gmailLink = new MetroFramework.Controls.MetroLink();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.minimizeLink = new MetroFramework.Controls.MetroLink();
            this.closeLink = new MetroFramework.Controls.MetroLink();
            this.tabs.SuspendLayout();
            this.mainTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.aboutTab.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // playlistLabel
            // 
            resources.ApplyResources(this.playlistLabel, "playlistLabel");
            this.playlistLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.playlistLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.playlistLabel.Name = "playlistLabel";
            // 
            // downloadTypeLabel
            // 
            resources.ApplyResources(this.downloadTypeLabel, "downloadTypeLabel");
            this.downloadTypeLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.downloadTypeLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.downloadTypeLabel.Name = "downloadTypeLabel";
            // 
            // audioQualityLabel
            // 
            resources.ApplyResources(this.audioQualityLabel, "audioQualityLabel");
            this.audioQualityLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.audioQualityLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.audioQualityLabel.Name = "audioQualityLabel";
            // 
            // metroLabel2
            // 
            resources.ApplyResources(this.metroLabel2, "metroLabel2");
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Name = "metroLabel2";
            // 
            // metroLabel3
            // 
            resources.ApplyResources(this.metroLabel3, "metroLabel3");
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Name = "metroLabel3";
            // 
            // metroLabel1
            // 
            resources.ApplyResources(this.metroLabel1, "metroLabel1");
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Name = "metroLabel1";
            // 
            // playlistButton
            // 
            resources.ApplyResources(this.playlistButton, "playlistButton");
            this.playlistButton.Name = "playlistButton";
            this.playlistButton.Style = MetroFramework.MetroColorStyle.Green;
            this.playlistButton.TabStop = false;
            this.metroToolTip1.SetToolTip(this.playlistButton, resources.GetString("playlistButton.ToolTip"));
            this.playlistButton.UseSelectable = true;
            this.playlistButton.Click += new System.EventHandler(this.playlistButton_Click);
            // 
            // signleMediaButton
            // 
            this.signleMediaButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.signleMediaButton.ForeColor = System.Drawing.Color.DarkBlue;
            this.signleMediaButton.Highlight = true;
            resources.ApplyResources(this.signleMediaButton, "signleMediaButton");
            this.signleMediaButton.Name = "signleMediaButton";
            this.signleMediaButton.Style = MetroFramework.MetroColorStyle.Green;
            this.signleMediaButton.TabStop = false;
            this.metroToolTip1.SetToolTip(this.signleMediaButton, resources.GetString("signleMediaButton.ToolTip"));
            this.signleMediaButton.UseSelectable = true;
            this.signleMediaButton.UseStyleColors = true;
            this.signleMediaButton.Click += new System.EventHandler(this.signleMediaButton_Click);
            // 
            // audioButton
            // 
            this.audioButton.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.audioButton, "audioButton");
            this.audioButton.Name = "audioButton";
            this.audioButton.Style = MetroFramework.MetroColorStyle.Green;
            this.audioButton.TabStop = false;
            this.metroToolTip1.SetToolTip(this.audioButton, resources.GetString("audioButton.ToolTip"));
            this.audioButton.UseSelectable = true;
            this.audioButton.Click += new System.EventHandler(this.audioButton_Click);
            // 
            // videoButton
            // 
            resources.ApplyResources(this.videoButton, "videoButton");
            this.videoButton.Highlight = true;
            this.videoButton.Name = "videoButton";
            this.videoButton.Style = MetroFramework.MetroColorStyle.Green;
            this.videoButton.TabStop = false;
            this.metroToolTip1.SetToolTip(this.videoButton, resources.GetString("videoButton.ToolTip"));
            this.videoButton.UseSelectable = true;
            this.videoButton.UseStyleColors = true;
            this.videoButton.Click += new System.EventHandler(this.videoButton_Click);
            // 
            // audio64
            // 
            resources.ApplyResources(this.audio64, "audio64");
            this.audio64.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.audio64.Name = "audio64";
            this.audio64.Style = MetroFramework.MetroColorStyle.Green;
            this.audio64.UseStyleColors = true;
            // 
            // audio128
            // 
            resources.ApplyResources(this.audio128, "audio128");
            this.audio128.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.audio128.Name = "audio128";
            this.audio128.Style = MetroFramework.MetroColorStyle.Green;
            this.audio128.UseStyleColors = true;
            // 
            // audio192
            // 
            resources.ApplyResources(this.audio192, "audio192");
            this.audio192.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.audio192.Name = "audio192";
            this.audio192.Style = MetroFramework.MetroColorStyle.Green;
            this.audio192.UseStyleColors = true;
            // 
            // audioQulityBar
            // 
            this.audioQulityBar.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.audioQulityBar, "audioQulityBar");
            this.audioQulityBar.LargeChange = 1;
            this.audioQulityBar.Maximum = 2;
            this.audioQulityBar.MouseWheelBarPartitions = 1;
            this.audioQulityBar.Name = "audioQulityBar";
            this.audioQulityBar.Style = MetroFramework.MetroColorStyle.Green;
            this.audioQulityBar.Value = 1;
            // 
            // video360
            // 
            resources.ApplyResources(this.video360, "video360");
            this.video360.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.video360.Name = "video360";
            this.video360.Style = MetroFramework.MetroColorStyle.Green;
            this.video360.UseStyleColors = true;
            // 
            // video1080
            // 
            resources.ApplyResources(this.video1080, "video1080");
            this.video1080.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.video1080.Name = "video1080";
            this.video1080.Style = MetroFramework.MetroColorStyle.Green;
            this.video1080.UseStyleColors = true;
            // 
            // video720
            // 
            resources.ApplyResources(this.video720, "video720");
            this.video720.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.video720.Name = "video720";
            this.video720.Style = MetroFramework.MetroColorStyle.Green;
            this.video720.UseStyleColors = true;
            // 
            // video480
            // 
            resources.ApplyResources(this.video480, "video480");
            this.video480.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.video480.Name = "video480";
            this.video480.Style = MetroFramework.MetroColorStyle.Green;
            this.video480.UseStyleColors = true;
            // 
            // videoQulityBar
            // 
            this.videoQulityBar.BackColor = System.Drawing.Color.Transparent;
            this.videoQulityBar.LargeChange = 3;
            resources.ApplyResources(this.videoQulityBar, "videoQulityBar");
            this.videoQulityBar.Maximum = 3;
            this.videoQulityBar.MouseWheelBarPartitions = 1;
            this.videoQulityBar.Name = "videoQulityBar";
            this.videoQulityBar.Style = MetroFramework.MetroColorStyle.Green;
            this.videoQulityBar.Value = 2;
            // 
            // directoryTextBox
            // 
            this.directoryTextBox.BackColor = System.Drawing.Color.PowderBlue;
            // 
            // 
            // 
            this.directoryTextBox.CustomButton.BackColor = System.Drawing.Color.Maroon;
            this.directoryTextBox.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.directoryTextBox.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode")));
            this.directoryTextBox.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location")));
            this.directoryTextBox.CustomButton.Name = "";
            this.directoryTextBox.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size")));
            this.directoryTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.directoryTextBox.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex")));
            this.directoryTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.directoryTextBox.CustomButton.UseSelectable = true;
            this.directoryTextBox.CustomButton.UseVisualStyleBackColor = false;
            this.directoryTextBox.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible")));
            this.directoryTextBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.directoryTextBox.Lines = new string[0];
            resources.ApplyResources(this.directoryTextBox, "directoryTextBox");
            this.directoryTextBox.MaxLength = 32767;
            this.directoryTextBox.Name = "directoryTextBox";
            this.directoryTextBox.PasswordChar = '\0';
            this.directoryTextBox.PromptText = "add directory path";
            this.directoryTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.directoryTextBox.SelectedText = "";
            this.directoryTextBox.SelectionLength = 0;
            this.directoryTextBox.SelectionStart = 0;
            this.directoryTextBox.ShortcutsEnabled = true;
            this.directoryTextBox.Style = MetroFramework.MetroColorStyle.Green;
            this.directoryTextBox.TabStop = false;
            this.directoryTextBox.UseSelectable = true;
            this.directoryTextBox.UseStyleColors = true;
            this.directoryTextBox.WaterMark = "add directory path";
            this.directoryTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.directoryTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // urlTextBox
            // 
            // 
            // 
            // 
            this.urlTextBox.CustomButton.BackColor = System.Drawing.Color.Yellow;
            this.urlTextBox.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.urlTextBox.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode1")));
            this.urlTextBox.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location1")));
            this.urlTextBox.CustomButton.Name = "";
            this.urlTextBox.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size1")));
            this.urlTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.urlTextBox.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex1")));
            this.urlTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.urlTextBox.CustomButton.UseSelectable = true;
            this.urlTextBox.CustomButton.UseVisualStyleBackColor = false;
            this.urlTextBox.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible1")));
            this.urlTextBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.urlTextBox.Lines = new string[0];
            resources.ApplyResources(this.urlTextBox, "urlTextBox");
            this.urlTextBox.MaxLength = 32767;
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.PasswordChar = '\0';
            this.urlTextBox.PromptText = "add playlist or video link";
            this.urlTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.urlTextBox.SelectedText = "";
            this.urlTextBox.SelectionLength = 0;
            this.urlTextBox.SelectionStart = 0;
            this.urlTextBox.ShortcutsEnabled = true;
            this.urlTextBox.Style = MetroFramework.MetroColorStyle.Green;
            this.urlTextBox.TabStop = false;
            this.urlTextBox.UseSelectable = true;
            this.urlTextBox.UseStyleColors = true;
            this.urlTextBox.WaterMark = "add playlist or video link";
            this.urlTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.urlTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.mainTab);
            this.tabs.Controls.Add(this.aboutTab);
            resources.ApplyResources(this.tabs, "tabs");
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Style = MetroFramework.MetroColorStyle.Green;
            this.tabs.TabStop = false;
            this.tabs.UseSelectable = true;
            this.tabs.UseStyleColors = true;
            // 
            // mainTab
            // 
            this.mainTab.Controls.Add(this.pictureBox8);
            this.mainTab.Controls.Add(this.pictureBox7);
            this.mainTab.Controls.Add(this.pictureBox6);
            this.mainTab.Controls.Add(this.pictureBox5);
            this.mainTab.Controls.Add(this.pictureBox4);
            this.mainTab.Controls.Add(this.pictureBox3);
            this.mainTab.Controls.Add(this.browseLink);
            this.mainTab.Controls.Add(this.downloadLink);
            this.mainTab.Controls.Add(this.playlistLabel);
            this.mainTab.Controls.Add(this.audio192);
            this.mainTab.Controls.Add(this.downloadTypeLabel);
            this.mainTab.Controls.Add(this.audio64);
            this.mainTab.Controls.Add(this.audioQualityLabel);
            this.mainTab.Controls.Add(this.videoQulityBar);
            this.mainTab.Controls.Add(this.metroLabel2);
            this.mainTab.Controls.Add(this.metroLabel1);
            this.mainTab.Controls.Add(this.video1080);
            this.mainTab.Controls.Add(this.metroLabel3);
            this.mainTab.Controls.Add(this.video360);
            this.mainTab.Controls.Add(this.playlistButton);
            this.mainTab.Controls.Add(this.audio128);
            this.mainTab.Controls.Add(this.signleMediaButton);
            this.mainTab.Controls.Add(this.urlTextBox);
            this.mainTab.Controls.Add(this.video720);
            this.mainTab.Controls.Add(this.directoryTextBox);
            this.mainTab.Controls.Add(this.audioButton);
            this.mainTab.Controls.Add(this.video480);
            this.mainTab.Controls.Add(this.audioQulityBar);
            this.mainTab.Controls.Add(this.videoButton);
            this.mainTab.HorizontalScrollbarBarColor = true;
            this.mainTab.HorizontalScrollbarHighlightOnWheel = false;
            this.mainTab.HorizontalScrollbarSize = 10;
            resources.ApplyResources(this.mainTab, "mainTab");
            this.mainTab.Name = "mainTab";
            this.mainTab.VerticalScrollbar = true;
            this.mainTab.VerticalScrollbarBarColor = true;
            this.mainTab.VerticalScrollbarHighlightOnWheel = false;
            this.mainTab.VerticalScrollbarSize = 10;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.Image = global::YouLab.Properties.Resources._6;
            resources.ApplyResources(this.pictureBox8, "pictureBox8");
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Image = global::YouLab.Properties.Resources._5;
            resources.ApplyResources(this.pictureBox7, "pictureBox7");
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = global::YouLab.Properties.Resources._4;
            resources.ApplyResources(this.pictureBox6, "pictureBox6");
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::YouLab.Properties.Resources._3;
            resources.ApplyResources(this.pictureBox5, "pictureBox5");
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::YouLab.Properties.Resources._2;
            resources.ApplyResources(this.pictureBox4, "pictureBox4");
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::YouLab.Properties.Resources._1;
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            // 
            // browseLink
            // 
            this.browseLink.Image = global::YouLab.Properties.Resources.browseFocus;
            this.browseLink.ImageSize = 48;
            resources.ApplyResources(this.browseLink, "browseLink");
            this.browseLink.Name = "browseLink";
            this.browseLink.NoFocusImage = global::YouLab.Properties.Resources.browseNoFocus;
            this.browseLink.UseSelectable = true;
            this.browseLink.Click += new System.EventHandler(this.browseLink_Click);
            // 
            // downloadLink
            // 
            this.downloadLink.Image = global::YouLab.Properties.Resources.YouLabIconSmall;
            this.downloadLink.ImageSize = 45;
            resources.ApplyResources(this.downloadLink, "downloadLink");
            this.downloadLink.Name = "downloadLink";
            this.downloadLink.NoFocusImage = global::YouLab.Properties.Resources.YouLabIconSmallNoFocus;
            this.downloadLink.UseSelectable = true;
            this.downloadLink.Click += new System.EventHandler(this.downloadLink_Click);
            // 
            // aboutTab
            // 
            this.aboutTab.Controls.Add(this.panel1);
            this.aboutTab.Controls.Add(this.githubLink);
            this.aboutTab.Controls.Add(this.gmailLink);
            this.aboutTab.Controls.Add(this.pictureBox1);
            this.aboutTab.HorizontalScrollbarBarColor = true;
            this.aboutTab.HorizontalScrollbarHighlightOnWheel = false;
            this.aboutTab.HorizontalScrollbarSize = 10;
            resources.ApplyResources(this.aboutTab, "aboutTab");
            this.aboutTab.Name = "aboutTab";
            this.aboutTab.Style = MetroFramework.MetroColorStyle.Green;
            this.aboutTab.VerticalScrollbar = true;
            this.aboutTab.VerticalScrollbarBarColor = false;
            this.aboutTab.VerticalScrollbarHighlightOnWheel = false;
            this.aboutTab.VerticalScrollbarSize = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel1.Controls.Add(this.metroLabel5);
            this.panel1.Controls.Add(this.metroLabel4);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // metroLabel5
            // 
            resources.ApplyResources(this.metroLabel5, "metroLabel5");
            this.metroLabel5.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.UseCustomBackColor = true;
            // 
            // metroLabel4
            // 
            resources.ApplyResources(this.metroLabel4, "metroLabel4");
            this.metroLabel4.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.UseCustomBackColor = true;
            // 
            // githubLink
            // 
            this.githubLink.Image = global::YouLab.Properties.Resources.githubFocus;
            this.githubLink.ImageSize = 70;
            resources.ApplyResources(this.githubLink, "githubLink");
            this.githubLink.Name = "githubLink";
            this.githubLink.NoFocusImage = global::YouLab.Properties.Resources.githubNoFocus;
            this.metroToolTip1.SetToolTip(this.githubLink, resources.GetString("githubLink.ToolTip"));
            this.githubLink.UseSelectable = true;
            this.githubLink.Click += new System.EventHandler(this.githubLink_Click);
            // 
            // gmailLink
            // 
            this.gmailLink.Image = global::YouLab.Properties.Resources.gmailFocus;
            this.gmailLink.ImageSize = 50;
            resources.ApplyResources(this.gmailLink, "gmailLink");
            this.gmailLink.Name = "gmailLink";
            this.gmailLink.NoFocusImage = global::YouLab.Properties.Resources.gmailNoFocus;
            this.metroToolTip1.SetToolTip(this.gmailLink, resources.GetString("gmailLink.ToolTip"));
            this.gmailLink.UseSelectable = true;
            this.gmailLink.Click += new System.EventHandler(this.gmailLink_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::YouLab.Properties.Resources.YouLabIcon;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::YouLab.Properties.Resources.YouLabIconSmall;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // minimizeLink
            // 
            this.minimizeLink.Image = global::YouLab.Properties.Resources.minimizeFocus;
            this.minimizeLink.ImageSize = 28;
            resources.ApplyResources(this.minimizeLink, "minimizeLink");
            this.minimizeLink.Name = "minimizeLink";
            this.minimizeLink.NoFocusImage = global::YouLab.Properties.Resources.minimizeNoFocus;
            this.minimizeLink.UseSelectable = true;
            this.minimizeLink.Click += new System.EventHandler(this.minimizeLink_Click);
            // 
            // closeLink
            // 
            this.closeLink.Image = global::YouLab.Properties.Resources.closeFocus;
            this.closeLink.ImageSize = 28;
            resources.ApplyResources(this.closeLink, "closeLink");
            this.closeLink.Name = "closeLink";
            this.closeLink.NoFocusImage = global::YouLab.Properties.Resources.closeNoFocus;
            this.closeLink.UseSelectable = true;
            this.closeLink.Click += new System.EventHandler(this.closeLink_Click);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.minimizeLink);
            this.Controls.Add(this.closeLink);
            this.Controls.Add(this.tabs);
            this.ForeColor = System.Drawing.Color.Cyan;
            this.Name = "MainForm";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.tabs.ResumeLayout(false);
            this.mainTab.ResumeLayout(false);
            this.mainTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.aboutTab.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel playlistLabel;
        private MetroFramework.Controls.MetroLabel downloadTypeLabel;
        private MetroFramework.Controls.MetroLabel audioQualityLabel;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton playlistButton;
        private MetroFramework.Controls.MetroButton signleMediaButton;
        private MetroFramework.Controls.MetroButton audioButton;
        private MetroFramework.Controls.MetroButton videoButton;
        private MetroFramework.Controls.MetroLabel audio64;
        private MetroFramework.Controls.MetroLabel audio128;
        private MetroFramework.Controls.MetroLabel audio192;
        private MetroFramework.Controls.MetroTrackBar audioQulityBar;
        private MetroFramework.Controls.MetroLabel video360;
        private MetroFramework.Controls.MetroLabel video1080;
        private MetroFramework.Controls.MetroLabel video720;
        private MetroFramework.Controls.MetroLabel video480;
        private MetroFramework.Controls.MetroTrackBar videoQulityBar;
        private MetroFramework.Controls.MetroTextBox directoryTextBox;
        private MetroFramework.Controls.MetroTextBox urlTextBox;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private MetroFramework.Controls.MetroTabControl tabs;
        private MetroFramework.Controls.MetroTabPage mainTab;
        private MetroFramework.Controls.MetroTabPage aboutTab;
        private DataGridViewTextBoxColumn primeryDownloaderDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn secondaryDowloaderDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn primeryVideoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn secondaryVideoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dirToSaveDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn audioQulityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn downloadPanelDataGridViewTextBoxColumn;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private MetroFramework.Controls.MetroLink browseLink;
        private MetroFramework.Controls.MetroLink downloadLink;
        private MetroFramework.Controls.MetroLink closeLink;
        private MetroFramework.Controls.MetroLink minimizeLink;
        private PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLink githubLink;
        private MetroFramework.Controls.MetroLink gmailLink;
        private Panel panel1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private PictureBox pictureBox2;
        private PictureBox pictureBox8;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
    }
}