using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webmotors.Domain.Entities;

namespace Webmotors.Domain.Interfaces.InterfaceService
{
    public interface IAnuncioService
    {
        IEnumerable<Anuncio> GetAll();

        bool Add(Anuncio anuncio);

        bool Delete(int id);

        bool Update(Anuncio anuncio);

        Anuncio GetById(int id);
    }
}
