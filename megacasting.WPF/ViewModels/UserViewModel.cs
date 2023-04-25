using megacasting.WPF.dblib.Class;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCasting.WPF.ViewModels
{
    internal class UserViewModel : BaseViewModel
    {
        #region Attributes
        private ObservableCollection<User> _Users;

        private User _SelectedUser;
        #endregion

        #region Properties
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
        public UserViewModel(megacastingContext MegacastingContext) : base(MegacastingContext)
        {
            this.Entities.Users.ToList();
            this.Users = this.Entities.Users.Local.ToObservableCollection();
        }
        #endregion
    }
}
