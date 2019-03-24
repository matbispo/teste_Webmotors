using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webmotors.Application.Model;

namespace Webmotors.Application.Aplication
{
    public class VersaoApplication
    {
        string url = "http://desafioonline.webmotors.com.br/api/OnlineChallenge/Version?ModelID=";

        IEnumerable<Versao> versoes;

        public IEnumerable<Versao> GetVersoes(string id)
        {
            url += id;
            var response = RequestWS.SendGetRequest(url);

            try
            {
                if (response.statusCode.Equals("200"))
                {
                    versoes = JsonConvert.DeserializeObject<List<Versao>>(response.data);
                }
                else
                {
                    versoes = new List<Versao>();
                }
            }
            catch (Exception e)
            {
                versoes = new List<Versao>();
            }

            return versoes;
        }
    }
}
