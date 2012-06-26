using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Googajax
{
    public sealed class GBlogResult : GSearchResult
    {
        public GBlogResult()
        {
        }

        public string PostUrl
        {
            get { return this["postUrl"]; }
        }

        public string BlogUrl
        {
            get { return this["blogUrl"]; }
        }

        public string Author
        {
            get { return this["author"]; }
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

        private DateTime PublishedDateTime = DateTime.MinValue;
        public DateTime PublishedDate
        {
            get { if (PublishedDateTime == DateTime.MinValue) PublishedDateTime = GetFieldAsDateTime("publishedDate"); return PublishedDateTime; }
        }
    }
}
