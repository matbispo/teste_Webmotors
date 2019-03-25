using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webmotors.Application.Model;
using Webmotors.Domain.Entities;

namespace Webmotors.Application.Interfaces
{
    public interface IAnuncioApplication
    {
        IEnumerable<Anuncio> listAnuncios();

        bool DeleteAnuncio(int id);

        bool EditAnuncio(AnuncioModel anuncio);

        bool CreateAnuncio(AnuncioModel anuncio);

        Anuncio ModelEntity(AnuncioModel model);
    }
}
