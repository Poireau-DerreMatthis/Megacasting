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
    /// Logique d'interaction pour UserView.xaml
    /// </summary>
    public partial class UserView : UserControl
    {
        bool isAnyTextboxEmpty = false;

        public UserView()
        {
            InitializeComponent();
        }

        public DbSet<User> Users { get; set; }

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


        private void SupprimerUser_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (var context = new megacastingContext())
                {
                    User selectedUser = (User)DataGridUser.SelectedItem;
                    User userToDelete = context.Users.Where(e => e.Id == selectedUser.Id).FirstOrDefault();
                    context.Users.Remove(userToDelete);
                    DataGridUser.Items.Refresh();
                    context.SaveChanges();
                    DataGridUser.Items.Refresh();
                    var users = context.Users;
                    DataGridUser.ItemsSource = users.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur: Selectionner un utilisateur \n" + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void ModifierUser_Click(object sender, RoutedEventArgs e)
        {
            ((UserViewModel)this.DataContext).Save();
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
                        var user = new User()
                        {
                            Nom = Nom.Text,
                            Prenom = Prenom.Text,
                            DateNaissance = DateNaissance.SelectedDate.Value,
                            Telephone = Telephone.Text,
                            Email = Mail.Text,
                            Password = "Not24get",
                            Ville = Ville.Text,
                            Roles = "[]"

                        };

                        // ajoutez l'objet offer à la base de données et actualisation datagrid
                        context.Users.Add(user);
                        DataGridUser.Items.Refresh();
                        try
                        {
                            context.SaveChanges();
                        }
                        catch (DbUpdateException ex)
                        {
                            MessageBox.Show("Erreur:Un utilisateur est selectionné (ctrl clique pour déselectionner)\n" + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                        DataGridUser.Items.Refresh();
                        var users = context.Users;
                        DataGridUser.ItemsSource = users.ToList();
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
