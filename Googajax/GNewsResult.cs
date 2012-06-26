using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Net.Json;

namespace Googajax
{
    public sealed class GNewsResult : GSearchResult
    {
        public GNewsResult()
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

        public string ClusterUrl
        {
            get { return this["clusterUrl"]; }
        }

        public string SignedRedirectUrl
        {
            get { return this["signedRedirectUrl"]; }
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

        public string Language
        {
            get { return this["language"]; }
        }

        public string Location
        {
            get { return this["location"]; }
        }

        public string Publisher
        {
            get { return this["publisher"]; }
        }

        private DateTime PublishedDateTime = DateTime.MinValue;
        public DateTime PublishedDate
        {
            get { if (PublishedDateTime == DateTime.MinValue) PublishedDateTime = GetFieldAsDateTime("publishedDate"); return PublishedDateTime;  }
        }

        public bool HasImage
        {
            get { return GetFieldAsJsonObject("image") != null; }
        }

        private GImageResult ImageResult = null;
        public GImageResult Image
        {
            get
            {
                if (ImageResult != null)
                    return ImageResult;

                ImageResult = new GImageResult();

                JsonObject imageData = GetFieldAsJsonObject("image");
                if (imageData != null)
                {
                    ImageResult.Load((JsonObjectCollection)imageData);
                }

                return ImageResult;
            }
        }

        private List<GNewsResult> RelatedStoriesList = null;
        public List<GNewsResult> RelatedStories
        {
            get
            {
                if (RelatedStoriesList != null)
                    return RelatedStoriesList;

                RelatedStoriesList = new List<GNewsResult>();

                JsonObject storiesData = GetFieldAsJsonObject("relatedStories");
                if (storiesData != null)
                {
                    foreach (JsonObjectCollection storyData in storiesData as JsonArrayCollection)
                    {
                        GNewsResult storyResult = new GNewsResult();
                        storyResult.Load(storyData);

                        RelatedStoriesList.Add(storyResult);
                    }
                }

                return RelatedStoriesList;
            }
        }
    }
}
