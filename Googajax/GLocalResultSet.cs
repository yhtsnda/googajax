using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Json;
using System.Text;

namespace Googajax
{
    public sealed class GLocalResultSet : GSearchResultSet<GLocalResult>
    {
        public GLocalResultSet()
        {
        }

        internal override void Load(JsonObjectCollection data)
        {
            base.Load(data);

            JsonObject obj = data["viewport"];
            if (obj != null)
                Viewport = new GViewport(obj as JsonObjectCollection);
        }

        public GViewport Viewport
        {
            get;
            private set;
        }
    }
}
