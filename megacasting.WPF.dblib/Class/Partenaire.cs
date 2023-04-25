using System;
using System.Collections.Generic;

namespace megacasting.WPF.dblib.Class
{
    public partial class Partenaire
    {
        public int Identifiant { get; set; }
        public string Nom { get; set; } = null!;
        public string Telephone { get; set; } = null!;
        public string Mail { get; set; } = null!;
    }
}
