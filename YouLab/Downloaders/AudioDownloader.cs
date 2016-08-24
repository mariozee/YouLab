using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using YouLab.Panels;
using YoutubeExtractor;

namespace YouLab.Downloaders
{
    public class AudioDownloader : AbstractDownloader
    {
        public AudioDownloader(VideoInfo primeryVideo, DownloadPanel downloadPanel, string dirToSave, int audioQulity)
            : base(primeryVideo, downloadPanel, dirToSave, audioQulity, Constants.Mp3Format)
        {
        }

        public override void Download()
        {
            this.SetUniqueTitle();

            this.PrimeryDownloader = new VideoDownloader(this.PrimeryVideo
                , Path.Combine(Constants.FfmpegDirectory + "\\", Constants.DownloadedVideoName));

            this.PrimeryDownloader.DownloadFinished += PrimeryDownloader_DownloadFinished;
            this.PrimeryDownloader.DownloadProgressChanged += PrimeryDownloader_DownloadProgressChanged;
            this.PrimeryDownloader.Execute();
        }

        private void PrimeryDownloader_DownloadProgressChanged(object sender, ProgressEventArgs e)
        {
            this.DownloadPanel.Invoke(new MethodInvoker(delegate ()
            {
                this.DownloadPanel.PrograssBar.Value = (int)e.ProgressPercentage;
                this.DownloadPanel.DownloadStatus.Text = $"{this.Title}";
                this.DownloadPanel.DownloadPercents.Text = $"{e.ProgressPercentage:F1}%";

                e.Cancel = this.DownloadPanel.CancelDownload;
            }));
        }

        private void PrimeryDownloader_DownloadFinished(object sender, EventArgs e)
        {
            if (!this.DownloadPanel.CancelDownload)
            {
                this.DownloadPanel.Invoke(new MethodInvoker(delegate ()
                {
                    this.DownloadPanel.StatusLabel.Text = GlobalMessages.ExctractingAudioStatusText;
                    this.DownloadPanel.Spinner.Visible = true;
                }));

                this.ExctractAudio();
            }
        }

        private void ExctractAudio()
        {
            string path = Constants.FfmpegDirectory;
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WorkingDirectory = path;
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.FileName = Constants.ProcessFileName;
            string savingPath = $"\"{this.DirToSave}\\{this.Title}.mp3\"";
            startInfo.Arguments = string.Format(Constants.AudioExtractCommand, this.AudioQulity.ToString(), savingPath);
            process.StartInfo = startInfo;
            process.Start();
            process.WaitForExit();

            this.DownloadPanel.Invoke(new MethodInvoker(delegate ()
            {
                this.DownloadPanel.Spinner.Visible = false;
                this.DownloadPanel.Text = GlobalMessages.DownloadingAudioStatusText;
            }));

            File.Delete(Constants.FfmpegDirectory + "\\" + Constants.DownloadedVideoName);
        }
    }
}