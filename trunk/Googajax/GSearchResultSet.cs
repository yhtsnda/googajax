using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Net.Json;

namespace Googajax
{
    public abstract class GSearchResultSet<T> : IDataLoader, IEnumerable<T> where T : IDataLoader
    {
        private const string ResultsField = "results";
        private const string CursorField = "cursor";

        private List<T> SearchResultsList;

        protected GSearchResultSet()
        {
            SearchResultsList = new List<T>();
            Cursor = new GCursor();
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T Result in SearchResultsList)
            {
                yield return Result;
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            foreach (T Result in SearchResultsList)
            {
                yield return Result;
            }
        }

        public T this[int index]
        {
            get { return SearchResultsList[index]; }
        }

        public int Count
        {
            get { return SearchResultsList.Count; }
        }

        public GCursor Cursor
        {
            get;
            private set;
        }

        private System.Net.IWebProxy Proxy;

        internal void SetProxy(System.Net.IWebProxy proxy)
        {
            Proxy = proxy;
        }

        void IDataLoader.SetProxy(System.Net.IWebProxy proxy)
        {
            this.SetProxy(proxy); 
        }

        internal virtual void Load(JsonObjectCollection data)
        {
            if (data == null) return;

            if (data[ResultsField] != null)
            {
                JsonArrayCollection resultsArray = (JsonArrayCollection)data[ResultsField];

                foreach (JsonObjectCollection resultColl in resultsArray)
                {
                    T result = (T)Activator.CreateInstance(typeof(T));
                    result.Load(resultColl);
                    result.SetProxy(Proxy);

                    SearchResultsList.Add(result);
                }
            }

            if (data[CursorField] != null)
            {
                JsonObjectCollection cursorColl = (JsonObjectCollection)data[CursorField];
                Cursor.Load(cursorColl);
            }
        }

        void IDataLoader.Load(object responseData)
        {
            this.Load(responseData as JsonObjectCollection);
        }
    }
}
