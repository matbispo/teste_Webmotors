using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webmotors.Application.Model
{
    public class Modelo
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int makeId { get; set; }
        public IEnumerable<Versao> VersionCars { get; set; }
    }
}
