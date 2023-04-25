using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace megacasting.WPF.dblib.Class
{
    public partial class megacastingContext : DbContext
    {
        public megacastingContext()
        {
        }

        public megacastingContext(DbContextOptions<megacastingContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DoctrineMigrationVersion> DoctrineMigrationVersions { get; set; } = null!;
        public virtual DbSet<Domaine> Domaines { get; set; } = null!;
        public virtual DbSet<Genre> Genres { get; set; } = null!;
        public virtual DbSet<GenreOffre> GenreOffres { get; set; } = null!;
        public virtual DbSet<Metier> Metiers { get; set; } = null!;
        public virtual DbSet<Offre> Offres { get; set; } = null!;
        public virtual DbSet<Pack> Packs { get; set; } = null!;
        public virtual DbSet<Partenaire> Partenaires { get; set; } = null!;
        public virtual DbSet<Souscrit> Souscrits { get; set; } = null!;
        public virtual DbSet<TypeContrat> TypeContrats { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=localhost;Database=megacasting;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DoctrineMigrationVersion>(entity =>
            {
                entity.HasKey(e => e.Version)
                    .HasName("PK__doctrine__79B5C94C6EE5CF27");

                entity.ToTable("doctrine_migration_versions");

                entity.Property(e => e.Version)
                    .HasMaxLength(191)
                    .HasColumnName("version");

                entity.Property(e => e.ExecutedAt)
                    .HasPrecision(6)
                    .HasColumnName("executed_at");

                entity.Property(e => e.ExecutionTime).HasColumnName("execution_time");
            });

            modelBuilder.Entity<Domaine>(entity =>
            {
                entity.HasKey(e => e.Identifiant)
                    .HasName("PK__domaine__DD380E4EFABF7F3F");

                entity.ToTable("domaine");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .HasColumnName("description");

                entity.Property(e => e.Libelle)
                    .HasMaxLength(255)
                    .HasColumnName("libelle");
            });

            modelBuilder.Entity<Genre>(entity =>
            {
                entity.HasKey(e => e.Identifiant)
                    .HasName("PK__genre__DD380E4E0503E397");

                entity.ToTable("genre");

                entity.Property(e => e.Libelle)
                    .HasMaxLength(255)
                    .HasColumnName("libelle");
            });

            modelBuilder.Entity<GenreOffre>(entity =>
            {
                entity.ToTable("genre_offre");

                entity.HasIndex(e => e.IdentifiantGenre, "IDX_128099AACF8CBD73");

                entity.HasIndex(e => e.IdentifiantOffre, "IDX_128099AAE35A08E4");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdentifiantGenre).HasColumnName("identifiantGenre");

                entity.Property(e => e.IdentifiantOffre).HasColumnName("identifiantOffre");

                entity.HasOne(d => d.IdentifiantGenreNavigation)
                    .WithMany(p => p.GenreOffres)
                    .HasForeignKey(d => d.IdentifiantGenre)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_128099AACF8CBD73");

                entity.HasOne(d => d.IdentifiantOffreNavigation)
                    .WithMany(p => p.GenreOffres)
                    .HasForeignKey(d => d.IdentifiantOffre)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_128099AAE35A08E4");
            });

            modelBuilder.Entity<Metier>(entity =>
            {
                entity.HasKey(e => e.Identifiant)
                    .HasName("PK__metier__DD380E4EFB8EA0D9");

                entity.ToTable("metier");

                entity.HasIndex(e => e.IdentifiantDomaine, "IDX_51A00D8CAAD8A9B7");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .HasColumnName("description");

                entity.Property(e => e.IdentifiantDomaine).HasColumnName("identifiantDomaine");

                entity.Property(e => e.Libelle)
                    .HasMaxLength(255)
                    .HasColumnName("libelle");

                entity.HasOne(d => d.IdentifiantDomaineNavigation)
                    .WithMany(p => p.Metiers)
                    .HasForeignKey(d => d.IdentifiantDomaine)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_51A00D8CAAD8A9B7");
            });

            modelBuilder.Entity<Offre>(entity =>
            {
                entity.HasKey(e => e.Identifiant)
                    .HasName("PK__offre__DD380E4E8F8F7370");

                entity.ToTable("offre");

                entity.HasIndex(e => e.IdentifiantMetier, "IDX_AF86866F2B868BAA");

                entity.HasIndex(e => e.IdentifiantUser, "IDX_AF86866F380D0368");

                entity.HasIndex(e => e.IdentifiantContrat, "IDX_AF86866FB2433AE8");

                entity.Property(e => e.DateDebutDiffusion)
                    .HasPrecision(6)
                    .HasColumnName("date_debut_diffusion");

                entity.Property(e => e.DateFinDiffusion)
                    .HasPrecision(6)
                    .HasColumnName("date_fin_diffusion");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .HasColumnName("description");

                entity.Property(e => e.IdentifiantContrat).HasColumnName("identifiantContrat");

                entity.Property(e => e.IdentifiantMetier).HasColumnName("identifiantMetier");

                entity.Property(e => e.IdentifiantUser).HasColumnName("identifiantUser");

                entity.Property(e => e.Libelle)
                    .HasMaxLength(255)
                    .HasColumnName("libelle");

                entity.Property(e => e.Reference)
                    .HasMaxLength(255)
                    .HasColumnName("reference");

                entity.HasOne(d => d.IdentifiantContratNavigation)
                    .WithMany(p => p.Offres)
                    .HasForeignKey(d => d.IdentifiantContrat)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AF86866FB2433AE8");

                entity.HasOne(d => d.IdentifiantMetierNavigation)
                    .WithMany(p => p.Offres)
                    .HasForeignKey(d => d.IdentifiantMetier)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AF86866F2B868BAA");

                entity.HasOne(d => d.IdentifiantUserNavigation)
                    .WithMany(p => p.Offres)
                    .HasForeignKey(d => d.IdentifiantUser)
                    .HasConstraintName("FK_AF86866F380D0368");
            });

            modelBuilder.Entity<Pack>(entity =>
            {
                entity.HasKey(e => e.Identifiant)
                    .HasName("PK__pack__DD380E4E4990EEC5");

                entity.ToTable("pack");

                entity.Property(e => e.Libelle)
                    .HasMaxLength(255)
                    .HasColumnName("libelle");

                entity.Property(e => e.NombreOffre).HasColumnName("nombre_offre");

                entity.Property(e => e.Tarif).HasColumnName("tarif");
            });

            modelBuilder.Entity<Partenaire>(entity =>
            {
                entity.HasKey(e => e.Identifiant)
                    .HasName("PK__partenai__DD380E4E79F72E2C");

                entity.ToTable("partenaire");

                entity.Property(e => e.Mail)
                    .HasMaxLength(255)
                    .HasColumnName("mail");

                entity.Property(e => e.Nom)
                    .HasMaxLength(255)
                    .HasColumnName("nom");

                entity.Property(e => e.Telephone)
                    .HasMaxLength(15)
                    .HasColumnName("telephone");
            });

            modelBuilder.Entity<Souscrit>(entity =>
            {
                entity.HasKey(e => e.Identifiant)
                    .HasName("PK__souscrit__DD380E4E1CAEA674");

                entity.ToTable("souscrit");

                entity.HasIndex(e => e.IdentifiantPack, "IDX_422FF26322408B02");

                entity.HasIndex(e => e.IdentifiantUser, "IDX_422FF263380D0368");

                entity.Property(e => e.DateSouscription)
                    .HasPrecision(6)
                    .HasColumnName("date_souscription");

                entity.Property(e => e.IdentifiantPack).HasColumnName("identifiantPack");

                entity.Property(e => e.IdentifiantUser).HasColumnName("identifiantUser");

                entity.HasOne(d => d.IdentifiantPackNavigation)
                    .WithMany(p => p.Souscrits)
                    .HasForeignKey(d => d.IdentifiantPack)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_422FF26322408B02");

                entity.HasOne(d => d.IdentifiantUserNavigation)
                    .WithMany(p => p.Souscrits)
                    .HasForeignKey(d => d.IdentifiantUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_422FF263380D0368");
            });

            modelBuilder.Entity<TypeContrat>(entity =>
            {
                entity.HasKey(e => e.Identifiant)
                    .HasName("PK__type_con__DD380E4E389FA174");

                entity.ToTable("type_contrat");

                entity.Property(e => e.Libelle)
                    .HasMaxLength(255)
                    .HasColumnName("libelle");

                entity.Property(e => e.LibelleLong)
                    .HasMaxLength(255)
                    .HasColumnName("libelle_long");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("user");

                entity.HasIndex(e => e.Email, "UNIQ_8D93D649E7927C74")
                    .IsUnique()
                    .HasFilter("([email] IS NOT NULL)");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DateNaissance)
                    .HasPrecision(6)
                    .HasColumnName("date_naissance");

                entity.Property(e => e.Email)
                    .HasMaxLength(180)
                    .HasColumnName("email");

                entity.Property(e => e.Nom)
                    .HasMaxLength(255)
                    .HasColumnName("nom");

                entity.Property(e => e.Password)
                    .HasMaxLength(255)
                    .HasColumnName("password");

                entity.Property(e => e.Prenom)
                    .HasMaxLength(255)
                    .HasColumnName("prenom");

                entity.Property(e => e.Roles)
                    .IsUnicode(false)
                    .HasColumnName("roles")
                    .HasComment("(DC2Type:json)");

                entity.Property(e => e.Telephone)
                    .HasMaxLength(15)
                    .HasColumnName("telephone");

                entity.Property(e => e.Ville)
                    .HasMaxLength(255)
                    .HasColumnName("ville");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
