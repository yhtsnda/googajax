using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Net.Json;

namespace Googajax
{
    public sealed class GCursor
    {
        private const string EstResultsCountField = "estimatedResultCount";
        private const string CurrentPageIndexField = "currentPageIndex";
        private const string MoreResultsUrlField = "moreResultsUrl";
        private const string PagesField = "pages";

        internal GCursor()
        {
        }

        public int EstimatedResultsCount
        {
            get;
            private set;
        }

        public int CurrentPageIndex
        {
            get;
            private set;
        }

        public string MoreResultsUrl
        {
            get;
            private set;
        }

        private List<GCursorPage> PageList = new List<GCursorPage>();
        public List<GCursorPage> Pages
        {
            get { return PageList; }
        }

        internal void Load(JsonObjectCollection data)
        {

            if (data == null) return;

            if (data[EstResultsCountField] != null)
                EstimatedResultsCount = int.Parse(data[EstResultsCountField].GetValue().ToString());

            if (data[CurrentPageIndexField] != null)
                CurrentPageIndex = int.Parse(data[CurrentPageIndexField].GetValue().ToString());

            if (data[MoreResultsUrlField] != null)
                MoreResultsUrl = data[MoreResultsUrlField].GetValue().ToString();

            if (data[PagesField] != null)
            {
                JsonArrayCollection pagesColl = (JsonArrayCollection)data[PagesField];
                foreach (JsonObjectCollection pageCol in pagesColl)
                {
                    GCursorPage page = new GCursorPage();
                    page.Load(pageCol);

                    PageList.Add(page);
                }
            }
        }
    }
}
