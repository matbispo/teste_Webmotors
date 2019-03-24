using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webmotors.Application.Model;

namespace Webmotors.Application.Aplication
{
    class MarcaApplication
    {
        string url = "http://desafioonline.webmotors.com.br/api/OnlineChallenge/Make";
        RequestWS request;
        IEnumerable<Marca> marcas;

        public MarcaApplication()
        {
            RequestWS request = new RequestWS();
        }

        public IEnumerable<Marca> GetMarcas() {

            var response = request.SendGetRequest(url);

            try
            {
                if (response.statusCode.Equals("200"))
                {
                    marcas = JsonConvert.DeserializeObject<Tdest>(JsonConvert.SerializeObject(data));
                }
                else
                {
                    marcas = new List<Marca>();
                }
            }
            catch (Exception e)
            {
                marcas = new List<Marca>();
            }

            return marcas;
        }

    }
}
