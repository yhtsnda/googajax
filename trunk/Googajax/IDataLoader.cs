using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

using System.Net.Json;

namespace Googajax
{
    public interface IDataLoader
    {
        void SetProxy(IWebProxy proxy);
        void Load(object data);
    }
}
