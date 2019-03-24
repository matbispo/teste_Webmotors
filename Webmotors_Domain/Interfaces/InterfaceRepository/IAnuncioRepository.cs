using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webmotors.Domain.Entities;

namespace Webmotors.Domain.Interfaces.InterfaceRepository
{
    public interface IAnuncioRepository
    {
        bool Add(Anuncio anuncio);
    }
}
