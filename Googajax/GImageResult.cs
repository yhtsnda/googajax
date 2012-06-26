using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Googajax
{
    public sealed class GImageResult : GSearchResult
    {
        public GImageResult()
        {
        }

        public int ImageWidth
        {
            get { return GetFieldAsInteger("width"); }
        }

        public int ImageHeight
        {
            get { return GetFieldAsInteger("height"); }
        }

        public int ThumbnailWidth
        {
            get { return GetFieldAsInteger("tbWidth"); }
        }

        public int ThumbnailHeight
        {
            get { return GetFieldAsInteger("tbHeight"); }
        }

        public string ImageId
        {
            get { return this["imageId"]; }
        }

        public string OriginalContextUrl
        {
            get { return this["originalContextUrl"]; }
        }

        public string ThumbnailUrl
        {
            get { return this["tbUrl"]; }
        }

        public string Url
        {
            get { return this["url"]; }
        }

        public string UnescapedUrl
        {
            get { return this["unescapedUrl"]; }
        }

        public string VisibleUrl
        {
            get { return this["visibleUrl"]; }
        }

        public string Title
        {
            get { return this["title"]; }
        }

        public string TitleNoFormatting
        {
            get { return this["titleNoFormatting"]; }
        }

        public string Content
        {
            get { return this["content"]; }
        }

        public string ContentNoFormatting
        {
            get { return this["contentNoFormatting"]; }
        }

        public Image DownloadImage()
        {
            return DownloadImage(Url);
        }

        public Image DownloadThumbnail()
        {
            return DownloadImage(ThumbnailUrl);
        }
    }
}
