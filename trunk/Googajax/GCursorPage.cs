using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Net.Json;

namespace Googajax
{
    public sealed class GCursorPage
    {
        internal GCursorPage()
        {
        }

        public int Start
        {
            get;
            private set;
        }

        public int Label
        {
            get;
            private set;
        }

        internal void Load(JsonObjectCollection data)
        {
            if (data == null) return;

            Start = int.Parse(data["start"].GetValue().ToString());
            Label = int.Parse(data["label"].GetValue().ToString());
        }
    }
}
