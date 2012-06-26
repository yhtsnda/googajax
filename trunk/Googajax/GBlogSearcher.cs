using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Googajax
{
    public sealed class GBlogSearcher : GSearcher<GBlogResultSet>
    {
        public GBlogSearcher() :
            base("blogs")
        {
        }

        public bool ScoreByDate
        {
            get { GSearchParameter parm = GetParameter(GScoring.InternalName); return parm != null; }
            set { if (value) { if (!ScoreByDate) SetParameter(GScoring.DescendingDate); } else ClearParameter(GScoring.InternalName); }
        }
    }
}
