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
                if (rb2.IsChecked == true)
                {
                    IMobileServiceTable<OrganizatorTabela> userTableObj1 = App.MobileService.GetTable<OrganizatorTabela>();
                    OrganizatorTabela obj1 = new OrganizatorTabela();

                }
                
                userTableObj.InsertAsync(obj);
                MessageDialog msgDialog = new MessageDialog("Registracija uspješna!");
               
                msgDialog.ShowAsync();
            }
            catch (Exception ex)
            {
                MessageDialog msgDialogError = new MessageDialog("Error : " + ex.ToString());
                msgDialogError.ShowAsync();
            }
        }
    }
}
