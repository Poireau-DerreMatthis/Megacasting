using System;
using System.Collections.Generic;

namespace megacasting.WPF.dblib.Class
{
    public partial class Offre
    {
        public Offre()
        {
            GenreOffres = new HashSet<GenreOffre>();
        }

        public int Identifiant { get; set; }
        public string Libelle { get; set; } = null!;
        public string Reference { get; set; } = null!;
        public DateTime DateDebutDiffusion { get; set; }
        public DateTime DateFinDiffusion { get; set; }
        public string? Description { get; set; }
        public int IdentifiantMetier { get; set; }
        public int IdentifiantContrat { get; set; }
        public int? IdentifiantUser { get; set; }

        public virtual TypeContrat IdentifiantContratNavigation { get; set; } = null!;
        public virtual Metier IdentifiantMetierNavigation { get; set; } = null!;
        public virtual User? IdentifiantUserNavigation { get; set; }
        public virtual ICollection<GenreOffre> GenreOffres { get; set; }
    }
}
