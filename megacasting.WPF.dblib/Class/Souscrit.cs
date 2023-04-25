using System;
using System.Collections.Generic;

namespace megacasting.WPF.dblib.Class
{
    public partial class Souscrit
    {
        public int Identifiant { get; set; }
        public DateTime DateSouscription { get; set; }
        public int IdentifiantPack { get; set; }
        public int IdentifiantUser { get; set; }

        public virtual Pack IdentifiantPackNavigation { get; set; } = null!;
        public virtual User IdentifiantUserNavigation { get; set; } = null!;
    }
}
