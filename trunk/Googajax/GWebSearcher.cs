using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Googajax
{
    public sealed class GWebSearcher : GSearcher<GWebResultSet>
    {
        private const string CseIdParameter = "cx";
        private const string CseSpecUrlParameter = "cref";
        private const string DupeFilterParameter = "filter";

        public GWebSearcher() :
            base("web")
        {
        }

        public string CseId
        {
            get { GSearchParameter parm = GetParameter(CseIdParameter); return parm != null ? parm.Value : null; }
            set { if (value != null && value.Length > 0) SetParameter(new GSearchParameter(CseIdParameter, value)); else ClearParameter(CseIdParameter); }
        }

        public string CseSpecUrl
        {
            get { GSearchParameter parm = GetParameter(CseSpecUrlParameter); return parm != null ? parm.Value : null; }
            set { if (value != null && value.Length > 0) SetParameter(new GSearchParameter(CseSpecUrlParameter, value)); else ClearParameter(CseSpecUrlParameter); }
        }

        public GSafetyLevel SafetyLevel
        {
            get { return (GSafetyLevel)GetParameter(GSafetyLevel.InternalName); }
            set { if (value != null) SetParameter(value); else ClearParameter(GSafetyLevel.InternalName); }
        }

        public GLangRestriction LanguageRestriction
        {
            get { return (GLangRestriction)GetParameter(GLangRestriction.InternalName); }
            set { if (value != null) SetParameter(value); else ClearParameter(GLangRestriction.InternalName); }
        }

        public GCountryRestriction CountryRestriction
        {
            get { return (GCountryRestriction)GetParameter(GCountryRestriction.InternalName); }
            set { if (value != null) SetParameter(value); else ClearParameter(GCountryRestriction.InternalName); }
        }

        public bool FilterDuplicates
        {
            get { return GetParameter(DupeFilterParameter) == null; }
            set { if (!value) SetParameter(new GSearchParameter(DupeFilterParameter, "0")); else ClearParameter(DupeFilterParameter); }
        }
    }
}
