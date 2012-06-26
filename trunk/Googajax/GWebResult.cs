using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Net.Json;

namespace Googajax
{
    public sealed class GWebResult : GSearchResult
    {
        internal const string ResultClass = "GwebSearch";

        public GWebResult()
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

        public string VisibleUrl
        {
            get { return this["visibleUrl"]; }
        }

        public string CacheUrl
        {
            get { return this["cacheUrl"]; }
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
    }
}
