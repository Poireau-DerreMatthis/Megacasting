using megacasting.WPF.dblib.Class;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCasting.WPF.ViewModels
{
    internal class PackViewModel : BaseViewModel
    {
        #region Attributes
        private ObservableCollection<Pack> _Packs;

        private Pack _SelectedPack;
        #endregion

        #region Properties
        public ObservableCollection<Pack> Packs
        {
            get { return _Packs; }
            set { _Packs = value; }
        }

        public Pack SelectedPack
        {
            get { return _SelectedPack; }
            set { _SelectedPack = value; }
        }
        #endregion

        #region Constructor
        public PackViewModel(megacastingContext MegacastingContext) : base(MegacastingContext)
        {
            this.Entities.Packs.ToList();
            this.Packs = this.Entities.Packs.Local.ToObservableCollection();
        }
        #endregion
    }
}
