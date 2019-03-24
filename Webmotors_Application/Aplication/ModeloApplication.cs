using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webmotors.Application.Model;

namespace Webmotors.Application.Aplication
{
    public class ModeloApplication
    {
        string url = "http://desafioonline.webmotors.com.br/api/OnlineChallenge/Model?MakeID=";

        public IEnumerable<Modelo> GetModelos(string id)
        {
            url += id;
            var response = RequestWS.SendGetRequest(url);
            IEnumerable<Modelo> modelos;

            try
            {
                if (response.statusCode.Equals("OK"))
                {
                    modelos = JsonConvert.DeserializeObject<List<Modelo>>(response.data);
                }
                else
                {
                    modelos = new List<Modelo>();
                }
            }
            catch (Exception e)
            {
                modelos = new List<Modelo>();
            }

            return modelos;
        }

        public string GetModelosString(string id)
        {
            string modelos;
            url += id;
            var response = RequestWS.SendGetRequest(url);

            try
            {
                if (response.statusCode.Equals("OK"))
                {
                    modelos = response.data;
                }
                else
                {
                    modelos = "";
                }
            }
            catch (Exception e)
            {
                modelos = "";
            }

            return modelos;
        }

    }
}
