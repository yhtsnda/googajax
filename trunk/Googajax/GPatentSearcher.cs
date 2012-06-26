using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Googajax
{
    public sealed class GPatentSearcher : GSearcher<GPatentResultSet>
    {
        private const string IssuedOnlyParameter = "as_psrg";
        private const string FiledOnlyParameter = "as_psrg";

        public GPatentSearcher() :
            base("patent")
        {
        }

        public bool IssuedOnly
        {
            get { GSearchParameter parm = GetParameter(IssuedOnlyParameter); return parm != null; }
            set { if (value) { if (!IssuedOnly) SetParameter(new GSearchParameter(IssuedOnlyParameter, "1")); } else ClearParameter(IssuedOnlyParameter); }
        }

        public bool FiledOnly
        {
            get { GSearchParameter parm = GetParameter(FiledOnlyParameter); return parm != null; }
            set { if (value) { if (!FiledOnly) SetParameter(new GSearchParameter(FiledOnlyParameter, "1")); } else ClearParameter(FiledOnlyParameter); }
        }

        public GScoring Scoring
        {
            get { return (GScoring)GetParameter(GScoring.InternalName); }
            set { if (value != null) SetParameter(value); else ClearParameter(GScoring.InternalName); }
        }
    }
}
