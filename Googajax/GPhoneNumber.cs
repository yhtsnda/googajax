using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Json;
using System.Text;

namespace Googajax
{
    public sealed class GPhoneNumber
    {

        internal GPhoneNumber(JsonObjectCollection data)
        {
            Load(data);
        }

        public string Type
        {
            get;
            private set;
        }

        public string Number
        {
            get;
            private set;
        }

        internal void Load(JsonObjectCollection data)
        {
            if (data == null) return;

            if (data["type"] != null)
                Type = data["type"].GetValue().ToString();

            if (data["number"] != null)
                Number = data["number"].GetValue().ToString();

        }
    }
}
