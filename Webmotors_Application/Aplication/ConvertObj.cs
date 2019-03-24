using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webmotors.Application.Aplication
{
    public static class ConvertObj
    {
        public static Tdest Convert<Tini, Tdest>(Tini data)
    where Tini : class
    where Tdest : class
        {
            Tdest result = default(Tdest);

            try
            {
                result = JsonConvert.DeserializeObject<Tdest>(JsonConvert.SerializeObject(data));

            }
            catch (Exception e)
            {
               // ControLogger.GravarLog(e);
            }
            return result;
        }
    }
}
