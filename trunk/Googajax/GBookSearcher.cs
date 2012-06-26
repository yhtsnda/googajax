using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Googajax
{
    public sealed class GBookSearcher : GSearcher<GBookResultSet>
    {
        private const string FullOnlyParameter = "as_brr";
        private const string LibraryParameter = "as_list";

        public GBookSearcher() :
            base("books")
        {
        }

        public bool FullOnly
        {
            get { GSearchParameter parm = GetParameter(FullOnlyParameter); return parm != null; }
            set { if (value) { if (!FullOnly) SetParameter(new GSearchParameter(FullOnlyParameter, "1")); } else ClearParameter(FullOnlyParameter); }
        }

        public string Library
        {
            get { GSearchParameter parm = GetParameter(LibraryParameter); return parm != null ? parm.Value : null; }
            set { if (value != null && value.Length > 0) SetParameter(new GSearchParameter(LibraryParameter, value)); else ClearParameter(LibraryParameter); }
        }
    }
}
