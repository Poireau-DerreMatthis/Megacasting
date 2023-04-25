using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using megacasting.WPF.dblib.Class;
using megacasting.WPF.Views;
using MegaCasting.WPF.ViewModels;

namespace megacasting.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
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

        public MainWindow()
        {
            InitializeComponent();

            this.Entities = new megacastingContext();
        }

        #endregion Constructor

        private void Accueil_Click(object sender, RoutedEventArgs e)
        {
            this.DockPanelView.Children.Clear();
            Accueil view = new Accueil();
            this.DockPanelView.Children.Add(view);
        }

        private void User_Click(object sender, RoutedEventArgs e)
        {
            UserViewModel viewModel = new UserViewModel(this.Entities);
            this.DockPanelView.Children.Clear();
            UserView view = new UserView();

            view.DataContext = viewModel;

            this.DockPanelView.Children.Add(view);
        }

        private void Offre_Click(object sender, RoutedEventArgs e)
        {
            OffreViewModel viewModel = new OffreViewModel(this.Entities);
            this.DockPanelView.Children.Clear();
            OffreView view = new OffreView();

            view.DataContext = viewModel;

            this.DockPanelView.Children.Add(view);
        }

        private void Partenaire_Click(object sender, RoutedEventArgs e)
        {
            PartenaireViewModel viewModel = new PartenaireViewModel(this.Entities);
            this.DockPanelView.Children.Clear();
            PartenaireView view = new PartenaireView();

            view.DataContext = viewModel;

            this.DockPanelView.Children.Add(view);
        }
    }
}
