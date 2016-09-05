using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using YouLab.Downloaders;
using YoutubeExtractor;
using MetroFramework;
using YouLab.Panels;

namespace YouLab
{
    public class DownloadManager
    {
        private readonly IDictionary<int, int> audioQulities = new Dictionary<int, int>()
        {
            { Constants.Index64, Constants.Audio64 },
            { Constants.Index128, Constants.Audio128 },
            { Constants.Index192, Constants.Audio192 }
        };

        private readonly IDictionary<int, int> audioToVideoQulities = new Dictionary<int, int>()
        {
            { Constants.Index64, Constants.Video360 },
            { Constants.Index128, Constants.Video360 },
            { Constants.Index192, Constants.Video720 }
        };

        private readonly IDictionary<int, int> videoQulities = new Dictionary<int, int>()
        {
            { Constants.Index360, Constants.Video360 },
            { Constants.Index480, Constants.Video480 },
            { Constants.Index720, Constants.Video720 },
            { Constants.Index1080, Constants.Video1080 }
        };

        private bool isPlaylist;
        private bool isVideo;
        private int audioQulityIndex;
        private int videoQulityIndex;
        private string dirToSave;
        private string url;
        private DownloadPanel downloadPanel;

        private ISet<string> urls;
        private IEnumerable<VideoInfo> presentedVideos;
        private Queue<IEnumerable<VideoInfo>> videos;
        BackgroundWorker preparationWorker;
        BackgroundWorker downloadWorker;

        private int downloadedVideosCount;

        public DownloadManager(bool isPlaylist
            , bool isVideo
            , int audioQulityIndex
            , int videoQulityIndex
            , string dirToSave
            , string url
            , DownloadPanel downloadPanel)
        {
            this.isPlaylist = isPlaylist;
            this.isVideo = isVideo;
            this.audioQulityIndex = audioQulityIndex;
            this.videoQulityIndex = videoQulityIndex;
            this.dirToSave = dirToSave;
            this.url = url;
            this.downloadPanel = downloadPanel;

            this.urls = new HashSet<string>();
            this.presentedVideos = new List<VideoInfo>();
            this.videos = new Queue<IEnumerable<VideoInfo>>();
            this.preparationWorker = new BackgroundWorker();
            this.downloadWorker = new BackgroundWorker();

            this.downloadedVideosCount = 0;
        }

        public void StartDownloading()
        {
            this.preparationWorker.DoWork += preparationWorker_PrepareVideos;
            this.preparationWorker.RunWorkerAsync();
        }

        private void ExctractUrls()
        {
            if (!isPlaylist)
            {
                this.urls.Add(this.url);
            }
            else
            {
                UrlProcessor.ExtractUrls(this.url, ref this.urls);
            }
        }

        private void PrepareVideos()
        {
            this.downloadWorker.DoWork += downloadWorker_DownloadVideos;
            this.downloadWorker.RunWorkerCompleted += downloadWorker_DownloadComplete;

            foreach (var url in this.urls)
            {
                try
                {
                    this.presentedVideos = DownloadUrlResolver.GetDownloadUrls(url);
                    this.videos.Enqueue(this.presentedVideos);
                }
                catch (ArgumentException)
                {
                    this.downloadPanel.Invoke(new MethodInvoker(() =>
                    this.downloadPanel
                    .StatusGrid
                    .Rows
                    .Add(url, Constants.ErrorDownlodingQulityText, Properties.Resources.uncomplete)));
                }
                catch (VideoNotAvailableException)
                {
                    this.downloadPanel.Invoke(new MethodInvoker(() =>
                    this.downloadPanel
                    .StatusGrid
                    .Rows
                    .Add(url, Constants.ErrorDownlodingQulityText, Properties.Resources.uncomplete)));
                }
                catch (YoutubeParseException)
                {
                    this.downloadPanel.Invoke(new MethodInvoker(() => 
                    this.downloadPanel
                    .StatusGrid
                    .Rows
                    .Add(url, Constants.ErrorDownlodingQulityText, Properties.Resources.uncomplete)));
                }

                if (!downloadWorker.IsBusy && !this.downloadPanel.CancelDownload)
                {
                    downloadWorker.RunWorkerAsync();
                }
            }
        }

        private void DownloadVideos()
        {
            try
            {
                while (videos.Count > 0 && !this.downloadPanel.CancelDownload)
                {
                    VideoInfo primeryVideo = null;
                    VideoInfo secondaryVideo = null;
                    int kbpsIndex = this.audioQulityIndex;
                    int resIndex = this.videoQulityIndex;

                    presentedVideos = this.videos.Dequeue();

                    if (this.isVideo)
                    {
                        primeryVideo = presentedVideos.FirstOrDefault(v
                            => v.VideoType == VideoType.Mp4 && v.Resolution == this.videoQulities[resIndex]);
                        while (primeryVideo == null)
                        {
                            GetLowerQulity(ref resIndex);
                            primeryVideo = presentedVideos.FirstOrDefault(v
                                => v.VideoType == VideoType.Mp4 && v.Resolution == this.videoQulities[resIndex]);
                        }

                        if (resIndex == Constants.Index1080 || resIndex == Constants.Index480)
                        {
                            GetLowerQulity(ref resIndex);
                            secondaryVideo = presentedVideos.FirstOrDefault(v
                                => v.VideoType == VideoType.Mp4 && v.Resolution == this.videoQulities[resIndex]);
                        }

                        if (secondaryVideo != null)
                        {
                            AbstractDownloader dualDownloader = new DualVideoDownload(
                                primeryVideo, secondaryVideo, this.downloadPanel, this.dirToSave);

                            dualDownloader.Download();
                        }
                        else
                        {
                            SingleVideoDownload singleDownloader = new SingleVideoDownload(
                                primeryVideo, this.downloadPanel, this.dirToSave);

                            singleDownloader.Download();
                        }
                    }
                    else
                    {
                        primeryVideo = presentedVideos.FirstOrDefault(v
                            => v.VideoType == VideoType.Mp4 && v.Resolution == this.audioToVideoQulities[kbpsIndex]);

                        while (primeryVideo == null)
                        {
                            GetLowerQulity(ref kbpsIndex);
                            primeryVideo = presentedVideos.FirstOrDefault(v
                                => v.VideoType == VideoType.Mp4 && v.Resolution == this.audioToVideoQulities[kbpsIndex]);
                        }

                        int qulity = this.audioQulities[kbpsIndex];
                        AbstractDownloader audioDownloader = new Downloaders.AudioDownloader(
                            primeryVideo, this.downloadPanel, this.dirToSave, qulity);

                        audioDownloader.Download();
                    }

                    this.downloadPanel.Invoke(new MethodInvoker(() =>
                    {
                        if (!this.downloadPanel.CancelDownload)
                        {
                            downloadedVideosCount++;
                            this.downloadPanel.TotalDownload.Text = $"{downloadedVideosCount}/{this.urls.Count}";
                            string qulity = isVideo ? primeryVideo.Resolution + "p" : this.audioQulities[kbpsIndex] + "kbps";
                            this.downloadPanel.TotalDownload.Text = $"{downloadedVideosCount}/{this.urls.Count}";

                            this.downloadPanel.StatusGrid.Rows.Add(primeryVideo.Title, qulity, Properties.Resources.complete);
                        }
                    }));
                }
            }
            catch (ArgumentException)
            {
                this.downloadPanel.Invoke(new MethodInvoker(() => 
                this.downloadPanel
                .StatusGrid
                .Rows
                .Add(url, Constants.ErrorDownlodingQulityText, Properties.Resources.uncomplete)));
            }
        }

        private void GetLowerQulity(ref int qulityIndex)
        {
            qulityIndex--;
            if (qulityIndex < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        private void preparationWorker_PrepareVideos(object sender, DoWorkEventArgs e)
        {
            this.ExctractUrls();
            this.downloadPanel.Invoke(new MethodInvoker(() => this.downloadPanel.TotalDownload.Text = $"0/{this.urls.Count}"));
            this.PrepareVideos();
        }

        private void downloadWorker_DownloadVideos(object sender, DoWorkEventArgs e)
        {
            this.downloadPanel.Invoke(new MethodInvoker(() =>
            {
                this.downloadPanel.Spinner.Visible = false;
                this.downloadPanel.StatusLabel.Text = GlobalMessages.DownloadingAudioStatusText;
                this.downloadPanel.Refresh();
            }));

            DownloadVideos();
        }

        private void downloadWorker_DownloadComplete(object sender, RunWorkerCompletedEventArgs e)
        {
            this.downloadPanel.Invoke(new MethodInvoker(() =>
            {
                if (!preparationWorker.IsBusy || this.downloadPanel.CancelDownload)
                {
                    if (!this.downloadPanel.CancelDownload)
                    {
                        this.downloadPanel.StatusLabel.Text = GlobalMessages.DownloadFinishAudioStatusText;
                        this.downloadPanel.MainForm.WindowState = FormWindowState.Normal;
                        MetroMessageBox.Show(this.downloadPanel
                            , string.Empty
                            , GlobalMessages.DownloadFinishMessage
                            , MessageBoxButtons.OK
                            , MessageBoxIcon.Information
                            , 80);                     

                        this.downloadPanel.BackLink.Enabled = true;
                    }
                    else
                    {
                        this.downloadPanel.Swipe(false);
                    }
                }
            }));
        }
    }
}