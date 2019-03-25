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
            Property(a => a.ID).IsRequired();
            Property(a => a.marca).HasMaxLength(45).IsRequired();
            Property(a => a.modelo).HasMaxLength(45).IsRequired();
            Property(a => a.versao).HasMaxLength(45).IsRequired();
            Property(a => a.ano).IsRequired();
            Property(a => a.quilometragem).IsRequired();
            Property(a => a.observacao).HasColumnType("text").IsRequired();

        }
    }
}
