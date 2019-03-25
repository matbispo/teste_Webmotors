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
    public class MarcaApplication: IMarcaApplication
    {
        string url = "http://desafioonline.webmotors.com.br/api/OnlineChallenge/Make";

        public string GetMarcasString()
        {

            string marcas;

            var response = RequestWS.SendGetRequest(url);

            try
            {
                if (response.statusCode.Equals("OK"))
                {
                    marcas = response.data;
                }
                else
                {
                    marcas = "";
                }
            }
            catch (Exception e)
            {
                marcas = "";
            }

            return marcas;
        }
    }
}

