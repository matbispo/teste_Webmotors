using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webmotors.Domain.Entities;

namespace Webmotors.Data.mapping
{
    public class AnuncioMapping: EntityTypeConfiguration<Anuncio>
    {
        public AnuncioMapping()
        {
            ToTable("tb_AnuncioWebmotors");
            HasKey(a => a.ID);

        }
    }
}
