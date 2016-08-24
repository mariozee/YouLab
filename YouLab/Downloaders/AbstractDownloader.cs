using System.IO;
using System.Text.RegularExpressions;
using YouLab.Panels;
using YoutubeExtractor;

namespace YouLab.Downloaders
{
    public abstract class AbstractDownloader
    {
        private const int FileModifierStartValue = 2;

        private VideoInfo primeryVideo;
        private VideoInfo secondaryVideo;
        private DownloadPanel downloadPanel;
        private string dirToSave;
        private string title;
        private int audioQulity;
        private Regex regex;
        private string fileFormat;

        protected int fileNameModifier;

        protected AbstractDownloader(VideoInfo primeryVideo, DownloadPanel downloadPanel, string dirToSave, int audioQulity, string fileFormat)
            : this(primeryVideo, null, downloadPanel, dirToSave, audioQulity, fileFormat)
        {
        }

        protected AbstractDownloader(VideoInfo primeryVideo, VideoInfo secondaryVideo , DownloadPanel downloadPanel, string dirToSave, string fileFormat)
            : this(primeryVideo, secondaryVideo, downloadPanel, dirToSave, -1, fileFormat)
        {
        }

        protected AbstractDownloader(VideoInfo primeryVideo, DownloadPanel downloadPanel, string dirToSave, string fileFormat)
            : this(primeryVideo, null, downloadPanel, dirToSave, -1, fileFormat)
        {
        }

        protected AbstractDownloader(VideoInfo primeryVideo, VideoInfo secondaryVideo, DownloadPanel downloadPanel, string dirToSave, int audioQulity, string fileFormat)
        {
            this.primeryVideo = primeryVideo;
            this.secondaryVideo = secondaryVideo;
            this.downloadPanel = downloadPanel;
            this.dirToSave = dirToSave;
            this.title = this.primeryVideo.Title;
            this.audioQulity = audioQulity;
            this.regex = new Regex(Constants.TitlePattern);
            this.fileFormat = fileFormat;
            this.fileNameModifier = FileModifierStartValue;
        }

        public VideoDownloader PrimeryDownloader { get; protected set; }

        public VideoDownloader SecondaryDowloader { get; protected set; }

        public VideoInfo PrimeryVideo { get { return this.primeryVideo; } }

        public VideoInfo SecondaryVideo { get { return this.secondaryVideo; } }

        public string DirToSave { get { return this.dirToSave; } }

        public int AudioQulity { get { return this.audioQulity; } }

        public string Title
        {
            get { return this.title; }
            protected set
            {
                value = this.regex.Replace(value, string.Empty);
                this.title = value;
            }
        }

        public DownloadPanel DownloadPanel
        {
            get { return this.downloadPanel; }
            protected set { this.downloadPanel = value; }
        }               

        protected void SetUniqueTitle()
        {
            string tempTitle = this.Title;
            string path = Path.Combine(this.DirToSave + "\\", tempTitle + this.fileFormat);         

            while (File.Exists(path))
            {
                tempTitle = $"{this.Title}({fileNameModifier})";
                path = Path.Combine(this.DirToSave + "\\", tempTitle + this.fileFormat);
                fileNameModifier++;
            }

            this.Title = tempTitle;
        }

        public abstract void Download();
    }
}