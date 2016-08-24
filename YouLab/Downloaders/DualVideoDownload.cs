using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using YouLab.Panels;
using YoutubeExtractor;

namespace YouLab.Downloaders
{
    public class DualVideoDownload : AbstractDownloader
    {


        public DualVideoDownload(VideoInfo primeryVideo, VideoInfo secondaryVideo, DownloadPanel downloadPanel, string dirToSave)
            : base(primeryVideo, secondaryVideo, downloadPanel, dirToSave, Constants.Mp4Format)
        {
        }

        public override void Download()
        {
            this.SetUniqueTitle();

            this.PrimeryDownloader = new VideoDownloader(this.PrimeryVideo
                , Path.Combine(Constants.FfmpegDirectory + "\\", Constants.DownloadedVideoNamePrime));
            this.SecondaryDowloader = new VideoDownloader(this.SecondaryVideo
                , Path.Combine(Constants.FfmpegDirectory + "\\", Constants.DownloadedVideoNameSec));

            this.PrimeryDownloader.DownloadProgressChanged += PrimeryDownloader_DownloadProgressChanged;
            this.SecondaryDowloader.DownloadProgressChanged += SecondaryDowloader_DownloadProgressChanged;

            this.PrimeryDownloader.Execute();
            if (!this.DownloadPanel.CancelDownload)
            {
                this.SecondaryDowloader.Execute();
            }

            this.CombineVideos();
        }

        private void SecondaryDowloader_DownloadProgressChanged(object sender, ProgressEventArgs e)
        {
            this.DownloadPanel.Invoke(new MethodInvoker(delegate ()
            {
                e.Cancel = this.DownloadPanel.CancelDownload;
                this.DownloadPanel.PrograssBar.Value = (int)e.ProgressPercentage / 2 + 50;
                this.DownloadPanel.DownloadStatus.Text = $"{this.Title}";
                this.DownloadPanel.DownloadPercents.Text = $"{e.ProgressPercentage / 2 + 50:F1}%";
            }));
        }

        private void PrimeryDownloader_DownloadProgressChanged(object sender, ProgressEventArgs e)
        {
            this.DownloadPanel.Invoke(new MethodInvoker(delegate ()
             {
                 e.Cancel = this.DownloadPanel.CancelDownload;
                 this.DownloadPanel.PrograssBar.Value = (int)e.ProgressPercentage / 2;
                 this.DownloadPanel.DownloadStatus.Text = $"{this.Title}";
                 this.DownloadPanel.DownloadPercents.Text = $"{e.ProgressPercentage / 2:F1}%";
             }));
        }

        private void CombineVideos()
        {
            string path = Constants.FfmpegDirectory;
            Process process = new Process();
            process.EnableRaisingEvents = true;
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WorkingDirectory = path;
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.FileName = Constants.ProcessFileName;
            string savingPath = $"\"{this.DirToSave}\\{this.Title}.mp4\"";
            startInfo.Arguments = string.Format(Constants.DualVideoExtractCommand, savingPath);
            process.StartInfo = startInfo;
            process.Start();
            process.WaitForExit();

            File.Delete(Constants.FfmpegDirectory + "\\" + Constants.DownloadedVideoNamePrime);
            File.Delete(Constants.FfmpegDirectory + "\\" + Constants.DownloadedVideoNameSec);
        }
    }
}