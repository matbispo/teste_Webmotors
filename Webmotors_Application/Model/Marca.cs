using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webmotors.Application.Model
{
    public class Marca
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public IEnumerable<Modelo> ModelCars { get; set; }
    }
}
