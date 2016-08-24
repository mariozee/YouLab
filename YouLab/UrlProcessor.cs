using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using HtmlAgilityPack;

namespace YouLab
{
    public static class UrlProcessor
    {        
        private static Regex regex;

        public static void ValidateURL(string url, bool isPlaylist)
        {
            if (isPlaylist)
            {
                regex = new Regex(Constants.PlaylistPattern);
                if (!regex.IsMatch(url))
                {
                    throw new ArgumentException(string.Format(GlobalMessages.InvalidPlaylistUrlText, url, Environment.NewLine));
                }
            }
            else
            {
                regex = new Regex(Constants.SingleVideoPattern);
                if (!regex.IsMatch(url))
                {
                    throw new ArgumentException(String.Format(GlobalMessages.InvalidVideoUrlText, url, Environment.NewLine));
                }
            }
        }

        public static void ExtractUrls(string url, ref ISet<string> urls)
        {
            string playlistUrl = url;
            if (playlistUrl.Contains("watch"))
            {
                string temp = string.Empty;
                playlistUrl = playlistUrl.Replace("watch", "playlist");
                int firstQuestionMark = playlistUrl.IndexOf('?');
                int firstAmpersand = playlistUrl.IndexOf('&');
                temp = playlistUrl.Substring(0, firstQuestionMark + 1);
                temp = temp + playlistUrl.Substring(firstAmpersand + 1);
                playlistUrl = temp;
            }

            HtmlWeb hw = new HtmlWeb();
            HtmlDocument doc = new HtmlDocument();
            doc = hw.Load(playlistUrl);
            foreach (HtmlNode link in doc.DocumentNode.SelectNodes("//a[@href]"))
            {
                // Get the value of the HREF attribute
                string hrefValue = link.GetAttributeValue("href", string.Empty);
                if (hrefValue.StartsWith("/watch?"))
                {
                    hrefValue = hrefValue.Split(';')[0];
                    hrefValue = "https://www.youtube.com" + hrefValue;
                    urls.Add(hrefValue);
                }
            }
        }
    }
}