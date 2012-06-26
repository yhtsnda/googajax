using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Json;
using System.Text;

namespace Googajax
{
    public sealed class GCoord
    {

        internal GCoord(JsonObjectCollection data)
        {
            Load(data);
        }

        public double Latitude
        {
            get;
            private set;
        }

        public double Longitude
        {
            get;
            private set;
        }

        internal void Load(JsonObjectCollection data)
        {
            if (data == null) return;
            
            JsonObject obj = data["lat"];
            if (obj != null)
                Latitude = double.Parse(obj.GetValue().ToString());

            obj = data["lng"];
            if (obj != null)
                Longitude = double.Parse(obj.GetValue().ToString());
            
        }
    }
}
