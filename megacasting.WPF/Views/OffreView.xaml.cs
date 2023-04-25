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
    /// Logique d'interaction pour OffreView.xaml
    /// </summary>
    public partial class OffreView : UserControl
    {
        public OffreView()
        {
            InitializeComponent();
        }

        #region Attributes
        /// <summary>
        /// Context
        /// </summary>
        private megacastingContext _Entities;

        public DbSet<Offre> Offres { get; set; }

        bool isAnyTextboxEmpty = false;
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

        #region Methods
        private void SupprimerOffre_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (var context = new megacastingContext())
                {
                    Offre selectedOffre = (Offre)DataGridOffre.SelectedItem;
                    Offre offreToDelete = context.Offres.Where(e => e.Identifiant == selectedOffre.Identifiant).FirstOrDefault();
                    context.Offres.Remove(offreToDelete);
                    DataGridOffre.Items.Refresh();
                    context.SaveChanges();
                    DataGridOffre.Items.Refresh();
                    var offres = context.Offres;
                    DataGridOffre.ItemsSource = offres.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur: Selectionner une offre \n" + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void ModifierOffre_Click(object sender, RoutedEventArgs e)
        {
            ((OffreViewModel)this.DataContext).Save();
        }

        private void AjouterOffre_Click(object sender, RoutedEventArgs e)
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
                    int resultDate = DateTime.Compare(DateDebutDiffusion.SelectedDate.Value, DateFinDiffusion.SelectedDate.Value);
                    if (resultDate > 0)
                    {
                        MessageBox.Show("Erreur: La date de fin de casting est inférieur\n à celle de la date de début");
                    }
                    else
                    {
                        using (var context = new megacastingContext())
                        {
                            // créez un nouvel objet offer à partir des informations saisies par l'utilisateur
                            var offre = new Offre()
                            {
                                Libelle = Libelle.Text,
                                DateDebutDiffusion = DateDebutDiffusion.SelectedDate.Value,
                                DateFinDiffusion = DateFinDiffusion.SelectedDate.Value,
                                Reference = Reference.Text,
                                Description = Description.Text,
                                IdentifiantMetier = (int)MetiersCombo.SelectedValue,
                                IdentifiantContrat = (int)ContratsCombo.SelectedValue,
                                IdentifiantUser = (int?)UtilisateursCombo.SelectedValue 
                            };

                            // ajoutez l'objet offer à la base de données et actualisation datagrid
                            context.Offres.Add(offre);
                            DataGridOffre.Items.Refresh();
                            try
                            {
                                context.SaveChanges();
                            }
                            catch (DbUpdateException ex)
                            {
                                MessageBox.Show("Erreur: Une offre est selectionné (ctrl clique pour déselectionner)\n" + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                            }
                            DataGridOffre.Items.Refresh();
                            var offres = context.Offres;
                            DataGridOffre.ItemsSource = offres.ToList();
                            DataGridOffre.Items.Refresh();
                        }
                    }
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Erreur: Remplir tout les champs \n" + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        #endregion
    }
}
