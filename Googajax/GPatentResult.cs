using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Googajax
{
    public sealed class GPatentResult : GSearchResult
    {
        public GPatentResult()
        {
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

        public string Content
        {
            get { return this["content"]; }
        }

        public string PatentNumber
        {
            get { return this["patentNumber"]; }
        }

        public string PatentStatus
        {
            get { return this["patentStatus"]; }
        }

        public string Assignee
        {
            get { return this["assignee"]; }
        }

        private DateTime ApplicationDateTime = DateTime.MinValue;
        public DateTime ApplicationDate
        {
            get { if (ApplicationDateTime == DateTime.MinValue) ApplicationDateTime = GetFieldAsDateTime("applicationDate"); return ApplicationDateTime; }
        }

        public string ThumbnailUrl
        {
            get { return this["tbUrl"]; }
        }

        public System.Drawing.Image DownloadThumbnail()
        {
            return DownloadImage(ThumbnailUrl);
        }
    }
}
