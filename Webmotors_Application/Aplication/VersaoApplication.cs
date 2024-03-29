﻿using Newtonsoft.Json;
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
    public class VersaoApplication: IVersaoApplication
    {
        string url = "http://desafioonline.webmotors.com.br/api/OnlineChallenge/Version?ModelID=";
      
        public string GetVersoesString(string id)
        {
            string versoes;
            url += id;
            var response = RequestWS.SendGetRequest(url);

            try
            {
                if (response.statusCode.Equals("OK"))
                {
                    versoes = response.data;
                }
                else
                {
                    versoes = "";
                }
            }
            catch (Exception e)
            {
                versoes = "";
            }

            return versoes;
        }
    }
}
