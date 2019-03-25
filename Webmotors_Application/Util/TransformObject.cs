using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webmotors.Application.Util
{
    public static class TransformObject
    {
        public static T ModelEntity<T>(object model) where T : class
        {
            var entity = JsonConvert.DeserializeObject<T>(JsonConvert.SerializeObject(model));

            return entity;
        }
    }
}
