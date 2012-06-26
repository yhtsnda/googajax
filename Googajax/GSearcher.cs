using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;

using System.Net.Json;

namespace Googajax
{
    public abstract class GSearcher<T> where T : IDataLoader
    {
        // url constant
        protected const string BaseSearchUrl = "http://ajax.googleapis.com/ajax/services/search/";

        // query constants
        protected const string QueryParmeter           = "q";
        protected const string UserIpParmeter          = "userip";
        protected const string HostLangParmeter        = "hl";
        protected const string AppKeyParmeter          = "key";
        protected const string StartIndexParmeter      = "start";
        protected const string ResultsSizeParmeter     = "rsz";

        private const string ResponseStatusField = "responseStatus";
        private const string ResponseDetailsField = "responseDetails";
        private const string ResponseDataField = "responseData";
        private const int ResponseStatusSuccess = 200;

        // member variables
        private Dictionary<string, GSearchParameter> SearchParameters;

        protected GSearcher(string searchType)
        {
            SearchParameters = new Dictionary<string, GSearchParameter>();
            SearchUrl = BaseSearchUrl + searchType;
            Version = GVersion.V1_0;
        }

        protected GSearchParameter GetParameter(string name)
        {
            return SearchParameters[name];
        }

        protected void SetParameter(GSearchParameter parm)
        {
            if (parm != null)
                SearchParameters[parm.Name] = parm;
        }

        protected void ClearParameter(string name)
        {
            SearchParameters.Remove(name);
        }

        public IWebProxy Proxy
        {
            get;
            set;
        }

        public string SearchUrl
        {
            get;
            private set;
        }

        public string QueryString
        {
            get
            {
                string QueryStr = "?";

                foreach (string ParmName in SearchParameters.Keys)
                {
                    QueryStr += SearchParameters[ParmName].ToQueryString() + "&";
                }

                return QueryStr;
            }
        }

        public string Query
        {
            get { GSearchParameter parm = GetParameter(QueryParmeter); return parm != null ? parm.Value : null; }
            set { if (value != null && value.Length > 0) SetParameter(new GSearchParameter(QueryParmeter, value)); else ClearParameter(QueryParmeter); }
        }

        public string UserIP
        {
            get { GSearchParameter parm = GetParameter(UserIpParmeter); return parm != null ? parm.Value : null; }
            set { if (value != null && value.Length > 0) SetParameter(new GSearchParameter(UserIpParmeter, value)); else ClearParameter(UserIpParmeter); }
        }

        public GHostLanguage HostLanguage
        {
            get { return (GHostLanguage)GetParameter(GHostLanguage.InternalName); }
            set { if (value != null) SetParameter(value); else ClearParameter(GHostLanguage.InternalName); }
        }

        public string AppKey
        {
            get { GSearchParameter parm = GetParameter(AppKeyParmeter); return parm != null ? parm.Value : null; }
            set { if (value != null && value.Length > 0) SetParameter(new GSearchParameter(AppKeyParmeter, value)); else ClearParameter(AppKeyParmeter); }
        }

        public int StartIndex
        {
            get { GSearchParameter parm = GetParameter(StartIndexParmeter); return parm != null ? int.Parse(parm.Value) : 0; }
            set { SetParameter(new GSearchParameter(StartIndexParmeter, value.ToString())); }
        }

        public int ResultsSize
        {
            get { GSearchParameter parm = GetParameter(ResultsSizeParmeter); return parm != null ? int.Parse(parm.Value) : (int)GResultsSize.Small; }
            set { SetParameter(new GSearchParameter(ResultsSizeParmeter, value.ToString())); }
        }

        public GVersion Version
        {
            get { return (GVersion)GetParameter(GVersion.InternalName); }
            set { if(value != null) SetParameter(value); }
        }

        public T Search()
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(SearchUrl + QueryString);
                if (Proxy != null) request.Proxy = Proxy;

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                StreamReader responseStream = new
                  StreamReader(response.GetResponseStream(), System.Text.Encoding.GetEncoding(1252));

                string responseStr = responseStream.ReadToEnd();

                responseStream.Close();
                response.Close();

                return ParseResponse(responseStr);
            }
            catch (GSearchException gse)
            {
                throw gse;
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.StackTrace);
                throw new GSearchException("The search failed to execute", ex);
            }
        }

        private T ParseResponse(string responseStr)
        {
            if (responseStr == null || responseStr.Length == 0)
                throw new GSearchException("The search response is null or empty");

            JsonTextParser jsonParser = new JsonTextParser();
            JsonObjectCollection response = (JsonObjectCollection)jsonParser.Parse(responseStr);

            string responseDetails = (string)response[ResponseDetailsField].GetValue();
            int responseStatus = int.Parse((string)response[ResponseStatusField].GetValue().ToString());

            if (responseStatus != ResponseStatusSuccess)
                throw new GSearchException(responseDetails, responseStatus);

            T results = (T)Activator.CreateInstance(typeof(T));
            results.Load((JsonObjectCollection)response[ResponseDataField]);
            results.SetProxy(Proxy);

            return results;
        }
    }
}
