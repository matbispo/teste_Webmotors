
using System.Collections.Generic;
using Webmotors.Domain.Entities;
using Webmotors.Domain.Interfaces.InterfaceRepository;
using Webmotors.Domain.Interfaces.InterfaceService;

namespace Webmotors.Domain.Services
{
    public class AnuncioService : IAnuncioService
    {
        private IAnuncioRepository _anuncioRepository;

        public AnuncioService(IAnuncioRepository anuncioRepository)
        {
            _anuncioRepository = anuncioRepository;
        }

        public bool Add(Anuncio anuncio)
        {
            if (_anuncioRepository.Add(anuncio) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public bool Delete(int id)
        {
            var anuncio = GetById(id);

            if (_anuncioRepository.Delete(anuncio) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
             
        }

        public IEnumerable<Anuncio> GetAll()
        {
            return _anuncioRepository.GetAll();
        }

        public Anuncio GetById(int id)
        {
            return _anuncioRepository.GetById(id);
        }

        public bool Update(Anuncio anuncio)
        {
            if (_anuncioRepository.Update(anuncio) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }            
        }
    }
}
