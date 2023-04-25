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
    /// Logique d'interaction pour PartenaireView.xaml
    /// </summary>
    public partial class PartenaireView : UserControl
    {
        bool isAnyTextboxEmpty = false;

        public PartenaireView()
        {
            InitializeComponent();
        }


        #region Attributes
        /// <summary>
        /// Context
        /// </summary>
        private megacastingContext _Entities;
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

        private void ModifierPartenaire_Click(object sender, RoutedEventArgs e)
        {
            ((PartenaireViewModel)this.DataContext).Save();
        }

        private void SupprimerPartenaire_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (var context = new megacastingContext())
                {
                    Partenaire selectedPartenaire = (Partenaire)DataGridPartenaire.SelectedItem;
                    Partenaire partenaireToDelete = context.Partenaires.Where(e => e.Identifiant == selectedPartenaire.Identifiant).FirstOrDefault();
                    context.Partenaires.Remove(partenaireToDelete);
                    DataGridPartenaire.Items.Refresh();
                    context.SaveChanges();
                    DataGridPartenaire.Items.Refresh();
                    var partenaires = context.Partenaires;
                    DataGridPartenaire.ItemsSource = partenaires.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur: Selectionner un utilisateur \n" + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void AjouterPartenaire_Click(object sender, RoutedEventArgs e)
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
                        var partenaire = new Partenaire()
                        {
                            Nom = Nom.Text,
                            Telephone = Telephone.Text,
                            Mail = Mail.Text,
                        };

                        // ajoutez l'objet offer à la base de données et actualisation datagrid
                        context.Partenaires.Add(partenaire);
                        DataGridPartenaire.Items.Refresh();
                        try
                        {
                            context.SaveChanges();
                        }
                        catch (DbUpdateException ex)
                        {
                            MessageBox.Show("Erreur:Un partenaire est selectionné (ctrl clique pour déselectionner)\n" + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                        DataGridPartenaire.Items.Refresh();
                        var partenaires = context.Partenaires;
                        DataGridPartenaire.ItemsSource = partenaires.ToList();
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
