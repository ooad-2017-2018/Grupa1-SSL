using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

using Microsoft.WindowsAzure.MobileServices;
using Windows.UI.Popups;
using System.Data.SqlClient;
using System.Text;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace SarajevoSocialLife.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Registracija : Page
    {
        public Registracija()
        {
            this.InitializeComponent();
        }
        IMobileServiceTable<Korisnici> userTableObj = App.MobileService.GetTable<Korisnici>();
        
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            // aplikacija = (Aplikacija)e.Parameter;
        }

        private void regButtonOnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                Korisnici obj = new Korisnici();
                obj.ime = imeTextBox.Text;
                obj.prezime = prezimeimeTextBox.Text;
                obj.username = usernameTextBox.Text;
                obj.password = passwordTextBox.Text;
                DateTimeOffset myDateTimeOffset = datumPick.Date;
                DateTime myDateTime = myDateTimeOffset.DateTime;
                obj.datumRodjenja = myDateTime;
                obj.spol = "rand";
                userTableObj.InsertAsync(obj);
                if (rb2.IsChecked == true)
                {
                    IMobileServiceTable<OrganizatorTabela> userTableObj1 = App.MobileService.GetTable<OrganizatorTabela>();
                    OrganizatorTabela obj1 = new OrganizatorTabela();
                    try
                    {
                        SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                        builder.DataSource = "sslserver.database.windows.net";
                        builder.UserID = "ssladmin";
                        builder.Password = "Sifrabaze1";
                        builder.InitialCatalog = "SSLBaza";
                        String sql=" ";
                        using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                        {
                            
                                connection.Open();
                            
                                StringBuilder sb = new StringBuilder();
                                sb.Append("SELECT id ");
                                sb.Append("FROM Korisnici ");
                                sb.Append("WHERE username='" + usernameTextBox.Text + "';");
                                sql= sb.ToString();
                           
                            
                                using (SqlCommand command = new SqlCommand(sql, connection))
                                {
                                    
                                        using (SqlDataReader reader = command.ExecuteReader())
                                        {
                                           while(reader.Read());
                                            obj1.id_korisnik = reader.GetString(0);
                                        }
                                    
                                }
                            connection.Close();
                            
                        }
                        obj1.id_korisnik = organizatorTextBox.Text;
                        userTableObj1.InsertAsync(obj1);
                    }
                    catch (SqlException ex)
                    {
                        MessageDialog msgDialogError = new MessageDialog("Error : " + ex.ToString());
                        msgDialogError.ShowAsync();
                    }

                }
                
                MessageDialog msgDialog = new MessageDialog("Registracija uspješna!");
               
                msgDialog.ShowAsync();
            }
            catch (Exception ex)
            {
                MessageDialog msgDialogError = new MessageDialog("Error : " + ex.ToString());
                msgDialogError.ShowAsync();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(PocetnaForma));
        }

        private void cekiran(object sender, RoutedEventArgs e)
        {
            organizatorTextBox.Visibility = Visibility.Visible;
        }

        private void odcekiran(object sender, RoutedEventArgs e)
        {
            organizatorTextBox.Visibility = Visibility.Collapsed;
        }
    }
}
