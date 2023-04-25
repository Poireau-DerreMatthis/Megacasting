using System;
using System.Collections.Generic;

namespace megacasting.WPF.dblib.Class
{
    public partial class Metier
    {
        public Metier()
        {
            Offres = new HashSet<Offre>();
        }

        public int Identifiant { get; set; }
        public string Libelle { get; set; } = null!;
        public string? Description { get; set; }
        public int IdentifiantDomaine { get; set; }

        public virtual Domaine IdentifiantDomaineNavigation { get; set; } = null!;
        public virtual ICollection<Offre> Offres { get; set; }
    }
}
