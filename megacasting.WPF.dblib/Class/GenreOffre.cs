using System;
using System.Collections.Generic;

namespace megacasting.WPF.dblib.Class
{
    public partial class GenreOffre
    {
        public int Id { get; set; }
        public int IdentifiantGenre { get; set; }
        public int IdentifiantOffre { get; set; }

        public virtual Genre IdentifiantGenreNavigation { get; set; } = null!;
        public virtual Offre IdentifiantOffreNavigation { get; set; } = null!;
    }
}
