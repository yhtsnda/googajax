using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Json;
using System.Text;

namespace Googajax
{
    public sealed class GViewport
    {
        internal GViewport(JsonObjectCollection data)
        {
            Load(data);
        }

        public GCoord Center
        {
            get;
            private set;
        }

        public GCoord Span
        {
            get;
            private set;
        }

        public GCoord Southwest
        {
            get;
            private set;
        }

        public GCoord Northeast
        {
            get;
            private set;
        }

        internal void Load(JsonObjectCollection data)
        {
            if (data == null) return;

            JsonObject obj = data["center"];
            if (obj != null)
                Center = new GCoord(obj as JsonObjectCollection);

            obj = data["span"];
            if (obj != null)
                Span = new GCoord(obj as JsonObjectCollection);

            obj = data["sw"];
            if (obj != null)
                Southwest = new GCoord(obj as JsonObjectCollection);

            obj = data["ne"];
            if (obj != null)
                Northeast = new GCoord(obj as JsonObjectCollection);

        }
    }
}
