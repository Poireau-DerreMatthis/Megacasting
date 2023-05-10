using megacasting.WPF.dblib.Class;
using MegaCasting.WPF.ViewModels;
using Microsoft.EntityFrameworkCore;
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

namespace megacasting.WPF.Views
{
    /// <summary>
    /// Logique d'interaction pour PackView.xaml
    /// </summary>
    public partial class PackView : UserControl
    {
        public PackView()
        {
            InitializeComponent();
        }

        public DbSet<Pack> Users { get; set; }

        #region Attributes
        /// <summary>
        /// Context
        /// </summary>
        private megacastingContext _Entities;
        private bool isAnyTextboxEmpty;
        #endregion

        #region Properties
        /// <summary>
        /// 
        /// </summary>
        public megacastingContext Entities
        {
            get { return _Entities; }
            private set { _Entities = value; }
        }
        #endregion

        private void ModifierPack_Click(object sender, RoutedEventArgs e)
        {
            ((PackViewModel)this.DataContext).Save();
        }

        private void SupprimerPack_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (var context = new megacastingContext())
                {
                    Pack selectedPack = (Pack)DataGridPack.SelectedItem;
                    Pack packToDelete = context.Packs.Where(e => e.Identifiant == selectedPack.Identifiant).FirstOrDefault();
                    context.Packs.Remove(packToDelete);
                    DataGridPack.Items.Refresh();
                    context.SaveChanges();
                    DataGridPack.Items.Refresh();
                    var packs = context.Users;
                    DataGridPack.ItemsSource = packs.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur: Selectionner un pack \n" + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void AjouterUser_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                foreach (var textbox in myGrid.Children.OfType<TextBox>())
                {
                    if (string.IsNullOrWhiteSpace(textbox.Text))
                    {
                        isAnyTextboxEmpty = true;
                        break;
                    }
                }

                if (isAnyTextboxEmpty)
                {
                    MessageBox.Show("Il faut remplir tout les champs.");
                }
                else
                {

                    using (var context = new megacastingContext())
                    {
                        // créez un nouvel objet offer à partir des informations saisies par l'utilisateur
                        var pack = new Pack()
                        {
                            Libelle = Libelle.Text,
                            NombreOffre = int.Parse(NombreOffre.Text),
                            Tarif = double.Parse(Tarif.Text),
                        };

                        // ajoutez l'objet offer à la base de données et actualisation datagrid
                        context.Packs.Add(pack);
                        DataGridPack.Items.Refresh();
                        try
                        {
                            context.SaveChanges();
                        }
                        catch (DbUpdateException ex)
                        {
                            MessageBox.Show("Erreur:Un pack est selectionné (ctrl clique pour déselectionner)\n" + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                        DataGridPack.Items.Refresh();
                        var packs = context.Packs;
                        DataGridPack.ItemsSource = packs.ToList();
                    }
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Erreur: Remplir tout les champs \n" + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
