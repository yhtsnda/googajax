using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

using System.Net.Json;

namespace Googajax
{

    public abstract class GSearchResult : IDataLoader
    {
        private static readonly string[] GMonths = new string[12] { "Jan", "Feb", "Mar", "Apr", "May", "Jun",
                                                                   "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };

        private JsonObjectCollection Result;

        protected GSearchResult()
        {
        }

        public string this[string fieldName]
        {
            get { return GetFieldAsString(fieldName); }
        }

        protected string GetFieldAsString(string fieldName)
        {
            JsonObject field = Result[fieldName];
            return field != null ? field.GetValue().ToString() : string.Empty;
        }

        protected int GetFieldAsInteger(string fieldName)
        {
            JsonObject field = Result[fieldName]; 
            return field != null ? int.Parse(field.GetValue().ToString()) : 0;
        }

        protected double GetFieldAsDouble(string fieldName)
        {
            JsonObject field = Result[fieldName];
            return field != null ? double.Parse(field.GetValue().ToString()) : 0d;
        }

        protected DateTime GetFieldAsDateTime(string fieldName)
        {
            DateTime result;
            JsonObject field = Result[fieldName];

            if (field != null)
            {
                string x = field.GetValue().ToString();

                int day = int.Parse(x.Substring(5, 2));
                int month = Array.IndexOf(GMonths, x.Substring(8, 3)) + 1;
                int year = int.Parse(x.Substring(12, 4));

                int hour = int.Parse(x.Substring(17, 2));
                int minute = int.Parse(x.Substring(20, 2));
                int second = int.Parse(x.Substring(23, 2));

                result = new DateTime(year, month, day, hour, minute, second, 0);
            }
            else
                throw new GSearchException(string.Format("Undefined date field '%s'", fieldName));

            return result;
        }

        internal JsonObject GetFieldAsJsonObject(string fieldName)
        {
            JsonObject field = Result[fieldName];
            return field != null ? field : null;
        }

        protected bool ContainsField(string fieldName)
        {
            return Result[fieldName] != null;
        }

        public override string ToString()
        {
            return Result != null ? Result.ToString() : base.ToString();
        }

        void IDataLoader.Load(object result)
        {
            this.Load(result);
        }

        internal void Load(object result)
        {
            Result = result as JsonObjectCollection;
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

        protected Image DownloadImage(string imageUrl)
        {
            return DownloadImage(imageUrl, Proxy);
        }

        private static Image DownloadImage(string imageUrl, System.Net.IWebProxy proxy)
        {
            Image image = null;

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(imageUrl);

                request.AllowWriteStreamBuffering = true;
                request.Proxy = proxy;

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                Stream responseStream = response.GetResponseStream();

                image = Image.FromStream(responseStream);

                responseStream.Close();
                response.Close();
            }
            catch (Exception ex)
            {
                throw new GSearchException("Unable to download image", ex);
            }

            return image;
        }
    }
}
