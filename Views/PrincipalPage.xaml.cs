using Microsoft.Maui.Controls;
using System;

namespace Tp4AplicacionesMoviles.Views
{
    public partial class PrincipalPage : ContentPage
    {
        public PrincipalPage()
        {
            InitializeComponent();
        }

        private void btnSalir_Clicked(object sender, EventArgs e)
        {
            // Navegar de regreso a la página de inicio de sesión
            Application.Current.MainPage = new NavigationPage(new LoginPage());
        }

        private void btnAcercaDe_Clicked(object sender, EventArgs e)
        {
            // Navegar a la página AcercaDePage
            Navigation.PushAsync(new AcercaDePage());
        }
    }
}
