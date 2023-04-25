using megacasting.WPF.dblib.Class;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCasting.WPF.ViewModels
{
    internal class OffreViewModel : BaseViewModel
    {
        #region Attributes
        private ObservableCollection<Offre> _Offres;

        private Offre _SelectedOffre;

        private ObservableCollection<Metier> _Metiers;

        private Metier _SelectedMetier;

        private ObservableCollection<TypeContrat> _TypeContrats;

        private TypeContrat _SelectedTypeContrat;

        private ObservableCollection<User> _Users;

        private User _SelectedUser;
        #endregion

        #region Properties
        public ObservableCollection<Offre> Offres
        {
            get { return _Offres; }
            set { _Offres = value; }
        }

        public Offre SelectedOffre
        {
            get { return _SelectedOffre; }
            set { _SelectedOffre = value; }
        }

        public ObservableCollection<Metier> Metiers
        {
            get { return _Metiers; }
            set { _Metiers = value; }
        }

        public Metier SelectedMetier
        {
            get { return _SelectedMetier; }
            set { _SelectedMetier = value; }
        }

        public ObservableCollection<TypeContrat> TypeContrats
        {
            get { return _TypeContrats; }
            set { _TypeContrats = value; }
        }

        public TypeContrat SelectedTypeContrat
        {
            get { return _SelectedTypeContrat; }
            set { _SelectedTypeContrat = value; }
        }

        public ObservableCollection<User> Users
        {
            get { return _Users; }
            set { _Users = value; }
        }

        public User SelectedUser
        {
            get { return _SelectedUser; }
            set { _SelectedUser = value; }
        }
        #endregion

        #region Constructor
        public OffreViewModel(megacastingContext MegacastingContext) : base(MegacastingContext)
        {
            this.Entities.Offres.ToList();
            this.Offres = this.Entities.Offres.Local.ToObservableCollection();
            this.Entities.Metiers.ToList();
            this.Metiers = this.Entities.Metiers.Local.ToObservableCollection();
            this.Entities.TypeContrats.ToList();
            this.TypeContrats = this.Entities.TypeContrats.Local.ToObservableCollection();
            this.Entities.Users.ToList();
            this.Users = this.Entities.Users.Local.ToObservableCollection();
        }
        #endregion
    }
}
