using megacasting.WPF.dblib.Class;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCasting.WPF.ViewModels
{
    internal class PartenaireViewModel : BaseViewModel
    {
        #region Attributes
        private ObservableCollection<Partenaire> _Partenaires;

        private Partenaire _SelectedPartenaire;
        #endregion

        #region Properties
        public ObservableCollection<Partenaire> Partenaires
        {
            get { return _Partenaires; }
            set { _Partenaires = value; }
        }

        public Partenaire SelectedPartenaire
        {
            get { return _SelectedPartenaire; }
            set { _SelectedPartenaire = value; }
        }
        #endregion

        #region Constructor
        public PartenaireViewModel(megacastingContext MegacastingContext) : base(MegacastingContext)
        {
            this.Entities.Partenaires.ToList();
            this.Partenaires = this.Entities.Partenaires.Local.ToObservableCollection();
        }
        #endregion
    }
}
