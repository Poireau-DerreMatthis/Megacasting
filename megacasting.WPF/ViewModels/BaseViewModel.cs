using megacasting.WPF.dblib.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCasting.WPF.ViewModels
{
    internal class BaseViewModel
    {
        #region Attributes
        /// <summary>
        /// Contexte
        /// </summary>
        private megacastingContext _Entities;
        #endregion

        #region Properties
        /// <summary>
        /// Obtient le contexte
        /// </summary>
        public megacastingContext Entities
        {
            get { return _Entities; }
            set { _Entities = value; }
        }

        #endregion

        #region Constructor
        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        /// <param name="megacastingContext">Contexte de l'Application</param>
        public BaseViewModel(megacastingContext megacastingContext)
        {
            this._Entities = megacastingContext;
        }
        #endregion

        #region Methods
        ///<summary>
        ///Sauvegarde les modifications de la base de données
        /// </summary>
        public void Save() => this.Entities.SaveChanges();
        #endregion
    }
}
