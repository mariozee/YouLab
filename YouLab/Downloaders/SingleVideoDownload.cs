using System.IO;
using System.Windows.Forms;
using YouLab.Panels;
using YoutubeExtractor;

namespace YouLab.Downloaders
{
    public class SingleVideoDownload : AbstractDownloader
    {
        public SingleVideoDownload(VideoInfo primeryVideo, DownloadPanel downloadPanel, string dirToSave)
            : base(primeryVideo, downloadPanel, dirToSave, Constants.Mp4Format)
        {
        }

        public override void Download()
        {
            this.SetUniqueTitle();

            this.PrimeryDownloader = new VideoDownloader(this.PrimeryVideo
                , Path.Combine(this.DirToSave + "\\", this.Title + ".mp4"));

            this.PrimeryDownloader.DownloadProgressChanged += PrimeryDownloader_DownloadProgressChanged;
            this.PrimeryDownloader.Execute();
        }

        private void PrimeryDownloader_DownloadProgressChanged(object sender, ProgressEventArgs e)
        {
            this.DownloadPanel.Invoke(new MethodInvoker(delegate ()
            {
                e.Cancel = this.DownloadPanel.CancelDownload;
                this.DownloadPanel.PrograssBar.Value = (int)e.ProgressPercentage;
                this.DownloadPanel.DownloadStatus.Text = $"{this.Title}";
                this.DownloadPanel.DownloadPercents.Text = $"{e.ProgressPercentage:F1}%";
            }));
        }
    }
}