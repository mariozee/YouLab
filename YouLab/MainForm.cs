using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using YouLab.Panels;

namespace YouLab
{
    public partial class MainForm : MetroForm
    {
        private DownloadManager downloadManager;
        private DownloadPanel downloadPanel;

        public MainForm()
        {
            InitializeComponent();

            this.MaximizeBox = false;
            this.audioButton.UseSelectable = false;
            this.videoButton.UseSelectable = false;
            this.playlistButton.UseSelectable = false;
            this.signleMediaButton.UseSelectable = false;
            this.urlTextBox.UseSelectable = false;
            this.directoryTextBox.UseSelectable = false;
            this.directoryTextBox.Text = Constants.DefaultSavePath;
        }

        private void downloadLink_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(this.urlTextBox.Text)
                && !string.IsNullOrWhiteSpace(this.directoryTextBox.Text)
                && Directory.Exists(this.directoryTextBox.Text))
            {
                try
                {
                    UrlProcessor.ValidateURL(this.urlTextBox.Text, this.playlistButton.Highlight);

                    this.downloadPanel = new DownloadPanel(this);
                    this.downloadPanel.CancelDownload = false;

                    this.downloadManager = new DownloadManager(this.playlistButton.Highlight
                        , this.videoButton.Highlight
                        , this.audioQulityBar.Value
                        , this.videoQulityBar.Value
                        , this.directoryTextBox.Text
                        , this.urlTextBox.Text
                        , downloadPanel);

                    downloadPanel.Swipe(true);
                    this.downloadManager.StartDownloading();
                }
                catch (ArgumentException ae)
                {
                    string errorLabel = this.playlistButton.Highlight ? GlobalMessages.InvalidPlaylistUrl : GlobalMessages.InvalidVideoUrl;
                    MetroMessageBox.Show(this, ae.Message, errorLabel, MessageBoxButtons.OK, MessageBoxIcon.Error, 180);
                }
                catch (Exception)
                {
                }
            }
        }

        private void closeLink_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeLink_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void browseLink_Click(object sender, EventArgs e)
        {
            this.folderBrowserDialog.ShowDialog();
            this.directoryTextBox.Text = this.folderBrowserDialog.SelectedPath;
        }

        private void audioButton_Click(object sender, EventArgs e)
        {
            this.videoButton.Highlight = false;
            this.videoButton.UseStyleColors = false;
            this.videoButton.Refresh();
            this.audioButton.Highlight = true;
            this.audioButton.UseStyleColors = true;
            this.audioButton.Refresh();
            this.audioQulityBar.Enabled = true;
            this.videoQulityBar.Enabled = false;
        }

        private void videoButton_Click(object sender, EventArgs e)
        {
            this.videoButton.Highlight = true;
            this.videoButton.UseStyleColors = true;
            this.videoButton.Refresh();
            this.audioButton.Highlight = false;
            this.audioButton.UseStyleColors = false;
            this.audioButton.Refresh();
            this.audioQulityBar.Enabled = false;
            this.videoQulityBar.Enabled = true;
        }

        private void playlistButton_Click(object sender, EventArgs e)
        {
            this.signleMediaButton.Highlight = false;
            this.signleMediaButton.UseStyleColors = false;
            this.signleMediaButton.Refresh();
            this.playlistButton.Highlight = true;
            this.playlistButton.UseStyleColors = true;
            this.playlistButton.Refresh();
        }

        private void signleMediaButton_Click(object sender, EventArgs e)
        {
            this.signleMediaButton.Highlight = true;
            this.signleMediaButton.UseStyleColors = true;
            this.signleMediaButton.Refresh();
            this.playlistButton.Highlight = false;
            this.playlistButton.UseStyleColors = false;
            this.playlistButton.Refresh();
        }

        private void gmailLink_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Constants.MyEmail);         
        }

        private void githubLink_Click(object sender, EventArgs e)
        {
            Process.Start(Constants.ApplicationGitLink);            
        }
    }
}