using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Googajax
{
    public sealed class GNewsSearcher : GSearcher<GNewsResultSet>
    {
        private const string LocationParameter = "geo";
        private const string EditionParameter = "ned";
        private const string QSIDParameter = "qsid";

        public GNewsSearcher() :
            base("news")
        {
        }

        public string Location
        {
            get { GSearchParameter parm = GetParameter(LocationParameter); return parm != null ? parm.Value : null; }
            set { if (value != null && value.Length > 0) SetParameter(new GSearchParameter(LocationParameter, value)); else ClearParameter(LocationParameter); }
        }

        public GNewsTopic Topic
        {
            get { return (GNewsTopic)GetParameter(GNewsTopic.InternalName); }
            set { if (value != null) SetParameter(value); else ClearParameter(GNewsTopic.InternalName); }
        }

        public bool ScoreByDate
        {
            get { GSearchParameter parm = GetParameter(GScoring.InternalName); return parm != null; }
            set { if (value) { if (!ScoreByDate) SetParameter(GScoring.DescendingDate); } else ClearParameter(GScoring.InternalName); }
        }

        public string Edition
        {
            get { GSearchParameter parm = GetParameter(EditionParameter); return parm != null ? parm.Value : null; }
            set { if (value != null && value.Length > 0) SetParameter(new GSearchParameter(EditionParameter, value)); else ClearParameter(EditionParameter); }
        }

        public string QSID
        {
            get { GSearchParameter parm = GetParameter(QSIDParameter); return parm != null ? parm.Value : null; }
            set { if (value != null && value.Length > 0) SetParameter(new GSearchParameter(QSIDParameter, value)); else ClearParameter(QSIDParameter); }
        }
    }
}
