using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Googajax
{
    public sealed class GLocalSearcher : GSearcher<GLocalResultSet>
    {
        private const string SearchCenterParameter = "sll";
        private const string SearchSpanParameter = "sspn";

        public GLocalSearcher() :
            base("local")
        {
        }

        public string SearchCenter
        {
            get { GSearchParameter parm = GetParameter(SearchCenterParameter); return parm != null ? parm.Value : null; }
            set { if (value != null && value.Length > 0) SetParameter(new GSearchParameter(SearchCenterParameter, value)); else ClearParameter(SearchCenterParameter); }
        }

        public string SearchSpan
        {
            get { GSearchParameter parm = GetParameter(SearchSpanParameter); return parm != null ? parm.Value : null; }
            set { if (value != null && value.Length > 0) SetParameter(new GSearchParameter(SearchSpanParameter, value)); else ClearParameter(SearchSpanParameter); }
        }

        public GLocalListing Listing
        {
            get { return (GLocalListing)GetParameter(GLocalListing.InternalName); }
            set { if (value != null) SetParameter(value); else ClearParameter(GLocalListing.InternalName); }
        }
    }
}
