using Microsoft.Maui.Controls;
using System;

namespace Tp4AplicacionesMoviles.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void OnLoginClicked(object sender, EventArgs e)
        {
            if (Usuario.Text == "Alumno" && Clave.Text == "1234")
            {
                Navigation.PushAsync(new PrincipalPage());
            }
            else
            {
                DisplayAlert("Error", "Usuario o Clave incorrecto, vuelve a intentar.", "OK");
            }
        }
    }
}
