
namespace Webmotors.Application.Aplication
{
    public class ResponseWS
    {

        public string message { get; set; }
        public string statusCode { get; set; }
        public string data { get; set; }

        public ResponseWS()
        {
            message = "";
            statusCode = "";
            data = "";
        }

    }
}
