
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Webmotors.Data.mapping;
using SqlProviderServices = System.Data.Entity.SqlServer.SqlProviderServices;
using System.Data.SqlClient;
using Webmotors.Domain.Entities;
using Webmotors.Domain.Interfaces.InterfaceRepository;

namespace Webmotors.Data.Context
{
    public class WebmotorsContext: DbContext, IWebmotorsContext
    {
        public WebmotorsContext():
            base("webmotorsdb")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        //public DbSet<Anuncio> Anuncio { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties<int>().Where(p => p.Name.Equals("ID")).Configure(p => p.IsKey());
            modelBuilder.Properties<string>().Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Configurations.Add(new AnuncioMapping());

        }
    }
}
