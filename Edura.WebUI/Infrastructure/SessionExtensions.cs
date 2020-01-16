using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace Edura.WebUI.Infrastructure
{
    public static class SessionExtensions
    {
        public static void SetJson(this ISession session, string key,object value) // key == > cart value ==> obje (cart nesnesi sinifi)
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
        }

        public static T GetJson<T>(this ISession session,string key)
        {
            var data = session.GetString(key);
            return data == null ?
                default(T) : JsonConvert.DeserializeObject<T>(data);
        }
    }
}
