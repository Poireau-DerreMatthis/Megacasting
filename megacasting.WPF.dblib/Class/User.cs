using System;
using System.Collections.Generic;

namespace megacasting.WPF.dblib.Class
{
    public partial class User
    {
        public User()
        {
            Offres = new HashSet<Offre>();
            Souscrits = new HashSet<Souscrit>();
        }

        public int Id { get; set; }
        public string Email { get; set; } = null!;
        /// <summary>
        /// (DC2Type:json)
        /// </summary>
        public string Roles { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Nom { get; set; } = null!;
        public string Prenom { get; set; } = null!;
        public DateTime DateNaissance { get; set; }
        public string Telephone { get; set; } = null!;
        public string Ville { get; set; } = null!;

        public virtual ICollection<Offre> Offres { get; set; }
        public virtual ICollection<Souscrit> Souscrits { get; set; }
    }
}
