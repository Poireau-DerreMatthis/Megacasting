using System;
using System.Collections.Generic;

namespace megacasting.WPF.dblib.Class
{
    public partial class Domaine
    {
        public Domaine()
        {
            Metiers = new HashSet<Metier>();
        }

        public int Identifiant { get; set; }
        public string Libelle { get; set; } = null!;
        public string? Description { get; set; }

        public virtual ICollection<Metier> Metiers { get; set; }
    }
}
