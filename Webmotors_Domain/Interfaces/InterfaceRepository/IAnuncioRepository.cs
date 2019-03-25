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
        IEnumerable<Anuncio> GetAll();

        int Add(Anuncio anuncio);

        int Delete(Anuncio anuncio);

        int Update(Anuncio anuncio);

        Anuncio GetById(int id);
    }
}
