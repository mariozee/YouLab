using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YouLab
{
    public static class Constants
    {
        public static readonly string FfmpegDirectory = Application.StartupPath + "\\ffmpeg";
        public const string Mp4Format = ".mp4";

        //AbstractDownloader.cs
        public const string TitlePattern = @"[\/*:\\""?><|]+";

        //AudioDownloader.cs
        public const string Mp3Format = ".mp3";
        public const string DownloadedVideoName = "video.mp4";
        public const string ProcessFileName = "cmd.exe";
        public static readonly string AudioExtractCommand = "/C ffmpeg -i video.mp4 -b:a {0}K -vn {1}";

        //DualVideoDownloader.cs
        public const string DownloadedVideoNamePrime = "videoHigh.mp4";
        public const string DownloadedVideoNameSec = "videoLow.mp4";
        public static readonly string DualVideoExtractCommand = "/C ffmpeg -i videoHigh.mp4 -i videoLow.mp4 -c copy -map 0:0 -map 1:1 -shortest {0}";

        //DownloadManager.cs
        public const int Video1080 = 1080;
        public const int Video720 = 720;
        public const int Video480 = 480;
        public const int Video360 = 360;

        public const int Audio192 = 192;
        public const int Audio128 = 128;
        public const int Audio64 = 64;

        public const int Index360 = 0;
        public const int Index480 = 1;
        public const int Index720 = 2;
        public const int Index1080 = 3;

        public const int Index64 = 0;
        public const int Index128 = 1;
        public const int Index192 = 2;

        public const string ErrorDownlodingQulityText = "N/A";

        //MainForm.cs
        public static readonly string DefaultSavePath = Application.StartupPath + "\\Downloads";
        public const string MyEmail = "mario.zisov@gmail.com";
        public const string ApplicationGitLink = "https://github.com/zisov4eto/YouLab";

        //UrlProcessor.cs
        public const string PlaylistPattern = @"(?:http|https|)(?::\/\/|)(?:www.|)(?:youtu\.be\/|youtube\.com(?:\/embed\/|\/v\/|\/watch\?v=|\/ytscreeningroom\?v=|\/feeds\/api\/videos\/|\/user\S*[^\w\-\s]|\S*[^\w\-\s]))([\w\-]{12,})[a-z0-9;:@#?&%=+\/\$_.-]*";
        public const string SingleVideoPattern = @"(?:http|https|)(?::\/\/|)(?:www.|)(?:youtu\.be\/|youtube\.com(?:\/embed\/|\/v\/|\/watch\?v=|\/ytscreeningroom\?v=|\/feeds\/api\/videos\/|\/user\S*[^\w\-\s]|\S*[^\w\-\s]))([\w\-]{11})[a-z0-9;:@#?&%=+\/\$_.-]*";

    }
}
