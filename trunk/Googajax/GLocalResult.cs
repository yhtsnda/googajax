using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Json;
using System.Text;

namespace Googajax
{
    public sealed class GLocalResult : GSearchResult
    {
        public GLocalResult()
        {
        }

        public string Title
        {
            get { return this["title"]; }
        }

        public string TitleNoFormatting
        {
            get { return this["titleNoFormatting"]; }
        }

        public string ViewportMode
        {
            get { return this["viewportmode"]; }
        }

        public string ListingType
        {
            get { return this["listingType"]; }
        }

        public double Latitude
        {
            get { return GetFieldAsDouble("lat"); }
        }

        public double Longitude
        {
            get { return GetFieldAsDouble("lng"); }
        }

        public int Accuracy
        {
            get { return GetFieldAsInteger("accuracy"); }
        }

        public string DrivingDirectionsUrl
        {
            get { return this["ddUrl"]; }
        }

        public string DrivingDirectionsToHereUrl
        {
            get { return this["ddUrlToHere"]; }
        }

        public string DrivingDirectionsFromHereUrl
        {
            get { return this["ddUrlFromHere"]; }
        }

        public string StreetAddress
        {
            get { return this["streetAddress"]; }
        }

        public string City
        {
            get { return this["city"]; }
        }

        public string Region
        {
            get { return this["region"]; }
        }

        public string Country
        {
            get { return this["country"]; }
        }

        public string StaticMapUrl
        {
            get { return this["staticMapUrl"]; }
        }

        public string Content
        {
            get { return this["content"]; }
        }

        public int MaxAge
        {
            get { return GetFieldAsInteger("maxAge"); }
        }

        private List<GPhoneNumber> phoneNumberList = null;
        public List<GPhoneNumber> PhoneNumbers
        {
            get
            {
                if(phoneNumberList == null)
                {
                    phoneNumberList = new List<GPhoneNumber>();

                    JsonArrayCollection phoneDataArray = GetFieldAsJsonObject("phoneNumbers") as JsonArrayCollection;
                    if (phoneDataArray != null)
                    {
                        foreach (JsonObjectCollection phoneDataColl in phoneDataArray)
                        {
                            GPhoneNumber phoneNum = new GPhoneNumber(phoneDataColl);
                            phoneNumberList.Add(phoneNum);
                        }
                    }
                }

                return phoneNumberList;
            }
        }

        private string[] AddressLinesArray = null;
        public string[] AddressLines
        {
            get
            {
                if (AddressLinesArray == null)
                {
                    JsonArrayCollection addressArr = GetFieldAsJsonObject("addressLines") as JsonArrayCollection;
                    if (addressArr != null)
                    {
                        AddressLinesArray = new string[addressArr.Count];

                        int i = 0;
                        foreach (JsonObject addressLine in addressArr)
                        {
                            AddressLinesArray[i++] = addressLine.GetValue().ToString();
                        }
                    }
                    else
                        AddressLinesArray = new string[0];
                }

                return AddressLinesArray;
            }
        }
    }
}
