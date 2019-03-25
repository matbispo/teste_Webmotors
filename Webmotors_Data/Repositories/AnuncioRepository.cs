using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Webmotors.Domain.Entities;
using Webmotors.Domain.Interfaces.InterfaceRepository;

namespace Webmotors.Data.Repositories
{
    public class AnuncioRepository : IAnuncioRepository
    {
        private IDbSet<Anuncio> _anuncio;
        private IWebmotorsContext _context;

        public AnuncioRepository(IWebmotorsContext context)
        {
            _context = context;
            _anuncio = _context.Set<Anuncio>();
        }

        public int Add(Anuncio anuncio)
        {
            _anuncio.Add(anuncio);
            return _context.SaveChanges();
        }

        public int Delete(Anuncio anuncio)
        {
            _anuncio.Remove(anuncio);
            return _context.SaveChanges();
        }

        public IEnumerable<Anuncio> GetAll()
        {
            return _anuncio.ToList();
        }

        public Anuncio GetById(int id)
        {
            return _anuncio.Where(a => a.ID == id).FirstOrDefault();
        }

            public int Update(Anuncio anuncio)
        {
            _context.Entry(anuncio).State = EntityState.Modified;
            return _context.SaveChanges();
        }
    }
}
