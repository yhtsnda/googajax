using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Googajax
{
    public sealed class GBookResult : GSearchResult
    {
        public GBookResult()
        {
        }

        public string Authors
        {
            get { return this["authors"]; }
        }

        public string BookId
        {
            get { return this["bookId"]; }
        }

        public string Url
        {
            get { return this["url"]; }
        }

        public string UnescapedUrl
        {
            get { return this["unescapedUrl"]; }
        }

        public string Title
        {
            get { return this["title"]; }
        }

        public string TitleNoFormatting
        {
            get { return this["titleNoFormatting"]; }
        }

        public int PublishedYear
        {
            get { return GetFieldAsInteger("publishedYear"); }
        }

        public string ThumbnailUrl
        {
            get { return this["tbUrl"]; }
        }

        public int ThumbnailWidth
        {
            get { return GetFieldAsInteger("tbWidth"); }
        }

        public int ThumbnailHeight
        {
            get { return GetFieldAsInteger("tbHeight"); }
        }

        public int PageCount
        {
            get { return GetFieldAsInteger("pageCount"); }
        }

        public System.Drawing.Image DownloadThumbnail()
        {
            return DownloadImage(ThumbnailUrl);
        }
    }
}
