using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webmotors.Application.Model;

namespace Webmotors.Application.Aplication
{
    public class MarcaApplication
    {
        string url = "http://desafioonline.webmotors.com.br/api/OnlineChallenge/Make";

        IEnumerable<Marca> marcas;

        public IEnumerable<Marca> GetMarcas() {

            var response = RequestWS.SendGetRequest(url);

            try
            {
                if (response.statusCode.Equals("200"))
                {
                    marcas = JsonConvert.DeserializeObject<List<Marca>>(response.data);
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
