using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webmotors.Application.Interfaces;
using Webmotors.Application.Model;
using Webmotors.Application.Util;
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
            return _anuncioService.Update(TransformObject.ModelEntity<Anuncio>(anuncio));
        }

        public bool CreateAnuncio(AnuncioModel anuncio)
        {
            return _anuncioService.Add(TransformObject.ModelEntity<Anuncio>(anuncio));
        }

        public AnuncioModel GetById(int id)
        {
            var anuncio = TransformObject.ModelEntity<AnuncioModel>(_anuncioService.GetById(id));
            return anuncio;
        }
    }
}
