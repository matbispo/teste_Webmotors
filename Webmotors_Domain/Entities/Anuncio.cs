

namespace Webmotors.Domain.Entities
{
    public class Anuncio
    {
        public int ID { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public string versao { get; set; }
        public int ano { get; set; }
        public int kilometragem { get; set; }
        public string descricao { get; set; }
    }
}
