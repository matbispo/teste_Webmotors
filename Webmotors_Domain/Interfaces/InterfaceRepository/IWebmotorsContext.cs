using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webmotors.Domain.Interfaces.InterfaceRepository
{
    public interface IWebmotorsContext: IDisposable
    {
        int SaveChanges();
        DbEntityEntry Entry(object entity);
        DbSet<TEntity> Set<TEntity>() where TEntity : class;
    }
}
