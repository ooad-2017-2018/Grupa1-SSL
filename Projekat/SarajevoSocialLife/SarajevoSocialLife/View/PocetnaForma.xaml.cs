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


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace SarajevoSocialLife.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PocetnaForma : Page
    {
        Proljece p;
        public PocetnaForma()
        {
            this.InitializeComponent();
            p = new Proljece();
           
        }

        private void proljeceButtonOnClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Proljece));
        }

        private void logInClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Login));
        }

        private void registracijaOnClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Registracija));
        }

        private void ljetoButtonOnClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Ljeto));
        }

        private void jesenButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Jesen));
        }

        private void zimaButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Zima));
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            // aplikacija = (Aplikacija)e.Parameter;
        }
    }
}
