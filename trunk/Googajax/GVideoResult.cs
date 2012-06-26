using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Googajax
{
    public sealed class GVideoResult : GSearchResult
    {
        public GVideoResult()
        {
        }

        public string Publisher
        {
            get { return this["publisher"]; }
        }

        private DateTime PublishedDateTime = DateTime.MinValue;
        public DateTime PublishedDate
        {
            get { if (PublishedDateTime == DateTime.MinValue) PublishedDateTime = GetFieldAsDateTime("published"); return PublishedDateTime; }
        }

        public string VideoType
        {
            get { return this["videoType"]; }
        }

        public int ThumbnailWidth
        {
            get { return GetFieldAsInteger("tbWidth"); }
        }

        public int ThumbnailHeight
        {
            get { return GetFieldAsInteger("tbHeight"); }
        }

        public string ThumbnailUrl
        {
            get { return this["tbUrl"]; }
        }

        public string Url
        {
            get { return this["url"]; }
        }

        public string PlayUrl
        {
            get { return this["playUrl"]; }
        }

        public string Content
        {
            get { return this["content"]; }
        }

        public string Title
        {
            get { return this["title"]; }
        }

        public string TitleNoFormatting
        {
            get { return this["titleNoFormatting"]; }
        }

        public double Rating
        {
            get { return GetFieldAsDouble("rating"); }
        }

        public int Duration
        {
            get { return GetFieldAsInteger("duration"); }
        }

        public System.Drawing.Image DownloadThumbnail()
        {
            return DownloadImage(ThumbnailUrl);
        }
    }
}
