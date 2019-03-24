﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Webmotors.Application.Aplication
{
    public class RequestWS
    {
        HttpWebRequest request;
        HttpWebResponse response;
        ResponseWS responseWs;

        public ResponseWS SendGetRequest(string url)
        {
            responseWs = new ResponseWS();

            try
            {
                int timeOut = Convert.ToInt32(ConfigurationManager.AppSettings["TimeOut"]);

                request = (HttpWebRequest)WebRequest.Create(url);
                request.Timeout = timeOut;
                request.Method = "GET";
                request.ContentType = "application/json";
                response = (HttpWebResponse)request.GetResponse();

                responseWs.statusCode = Convert.ToString(response.StatusCode);

                if (response.StatusCode == HttpStatusCode.OK)
                {

                    Stream dataStream = response.GetResponseStream();
                    StreamReader reader = new StreamReader(dataStream);
                    responseWs.data = reader.ReadToEnd();
                }
                else
                {
                    if (!url.Contains("commits"))
                    {
                        throw new Exception(response.StatusCode.ToString());
                    }
                }
            }

            catch (Exception e)
            {

               // ControLogger.GravarLog(e);

                responseWs.message = e.Message;
            }


            return responseWs;
        }

        public ResponseWS SendPostRequest(string url)
        {
            // todo send parameter post
            responseWs = new ResponseWS();
            return responseWs;
        }
    }
}
