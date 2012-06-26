using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Googajax
{
    public sealed class GVideoSearcher : GSearcher<GVideoResultSet>
    {
        public GVideoSearcher() :
            base("video")
        {
        }

        public bool ScoreByDate
        {
            get { GSearchParameter parm = GetParameter(GScoring.InternalName); return parm != null; }
            set { if (value) { if (!ScoreByDate) SetParameter(GScoring.DescendingDate); } else ClearParameter(GScoring.InternalName); }
        }
    }
}
