using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webmotors.Application.Interfaces;
using Webmotors.Application.Model;
using Webmotors.Domain.Entities;
using Webmotors.Domain.Interfaces.InterfaceService;

namespace Webmotors.Application.Aplication
{
    public class AnuncioApplication: IAnuncioApplication
    {
        private IAnuncioService _anuncioService;

        public AnuncioApplication(IAnuncioService anuncioService)
        {
            _anuncioService = anuncioService;
        }

        public IEnumerable<Anuncio> listAnuncios()
        {
            try
            {
                var anuncios = _anuncioService.GetAll();
                return anuncios;
            }
            catch (Exception e)
            {
                return new List<Anuncio>();
            }

        }
        public bool DeleteAnuncio(int id)
        {
            return _anuncioService.Delete(id);
        }

        public bool EditAnuncio(AnuncioModel anuncio)
        {
            return _anuncioService.Update(ModelEntity(anuncio));
        }

        public bool CreateAnuncio(AnuncioModel anuncio)
        {
            return _anuncioService.Add(ModelEntity(anuncio));
        }

        public Anuncio ModelEntity(AnuncioModel model)
        {
            Anuncio newAnuncio = new Anuncio();

            newAnuncio.ano = model.ano;
            newAnuncio.observacao = model.descricao;
            newAnuncio.quilometragem = model.kilometragem;
            
            return newAnuncio;
        }
    }
}
