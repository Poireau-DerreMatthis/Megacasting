using System;
using System.Collections.Generic;

namespace megacasting.WPF.dblib.Class
{
    public partial class Pack
    {
        public Pack()
        {
            Souscrits = new HashSet<Souscrit>();
        }

        public int Identifiant { get; set; }
        public string Libelle { get; set; } = null!;
        public int NombreOffre { get; set; }
        public double Tarif { get; set; }

        public virtual ICollection<Souscrit> Souscrits { get; set; }
    }
}
