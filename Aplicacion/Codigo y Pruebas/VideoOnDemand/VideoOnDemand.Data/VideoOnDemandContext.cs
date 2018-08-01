using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoOnDemand.Entities;

namespace VideoOnDemand.Data
{
    public class VideoOnDemandContext : DbContext
    {
        public VideoOnDemandContext() : base("name=VideoOnDemandContext")
        {
            this.Configuration.LazyLoadingEnabled = true;
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Media> Medias { get; set; }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Persona> Personas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            var usuarioEntity = modelBuilder.Entity<Usuario>();
            usuarioEntity.HasKey(x => x.Id);
            usuarioEntity.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            usuarioEntity.Property(x => x.Nombre).HasMaxLength(200).IsRequired();
            usuarioEntity.Property(x => x.IdentityId).HasMaxLength(128).IsRequired();

            #region MapeoGenero
            var genero = modelBuilder.Entity<Genero>();
            genero.HasKey(i => i.GeneroId);
            genero.Property(i => i.GeneroId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            genero.Property(i => i.Nombre).HasMaxLength(100).IsRequired();
            genero.Property(i => i.Descripcion).HasMaxLength(500).IsOptional();

            #endregion
            #region MapeoPersona
            var persona = modelBuilder.Entity<Persona>();
            persona.ToTable("Actores");
            persona.HasKey(x => x.Id).Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            persona.Property(x => x.Name).HasMaxLength(25).IsRequired();
            persona.Property(x => x.Descripcion).HasMaxLength(500).IsRequired();
            persona.Property(x => x.Status).IsOptional();

            #region MapeoMedia
            var media = modelBuilder.Entity<Media>();

            media.HasKey(i => i.MediaId);
            media.Property(i => i.MediaId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            media.Property(i => i.Descripcion).HasMaxLength(500).IsOptional();

            media.HasMany<Genero>(g => g.Generos).WithMany(m => m.Medias).Map(gm =>
            {
                gm.MapLeftKey("MediaId");
                gm.MapRightKey("GeneroId");
                gm.ToTable("Media-Genero");
            });

            
            media.HasMany<Persona>(a => a.Actores).WithMany(m => m.Medias).Map(am =>
            {
                am.MapLeftKey("MediaId");
                am.MapRightKey("ActoresId");
                am.ToTable("Media-Actor");
            });
>>>>>>> da97cd1453622b6c6a55f22f15555f3498bd1b33
            #endregion

        }
    }
}
