using System;
using System.Collections.Generic;

namespace megacasting.WPF.dblib.Class
{
    public partial class Genre
    {
        public Genre()
        {
            GenreOffres = new HashSet<GenreOffre>();
        }

        public int Identifiant { get; set; }
        public string Libelle { get; set; } = null!;

        public virtual ICollection<GenreOffre> GenreOffres { get; set; }
    }
}
