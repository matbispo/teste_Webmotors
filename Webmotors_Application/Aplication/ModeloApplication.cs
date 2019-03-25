using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webmotors.Application.Interfaces;
using Webmotors.Application.Model;
using Webmotors.Application.Util;

namespace Webmotors.Application.Aplication
{
    public class ModeloApplication: IModeloApplication
    {
        string url = "http://desafioonline.webmotors.com.br/api/OnlineChallenge/Model?MakeID=";

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
