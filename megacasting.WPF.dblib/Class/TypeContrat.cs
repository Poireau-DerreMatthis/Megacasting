using System;
using System.Collections.Generic;

namespace megacasting.WPF.dblib.Class
{
    public partial class TypeContrat
    {
        public TypeContrat()
        {
            Offres = new HashSet<Offre>();
        }

        public int Identifiant { get; set; }
        public string Libelle { get; set; } = null!;
        public string LibelleLong { get; set; } = null!;

        public virtual ICollection<Offre> Offres { get; set; }
    }
}
