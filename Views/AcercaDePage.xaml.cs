using Microsoft.Maui.Controls;
using System;

namespace Tp4AplicacionesMoviles.Views
{
    public partial class AcercaDePage : ContentPage
    {
        public AcercaDePage()
        {
            InitializeComponent();
        }

        private void btnVolver_Clicked(object sender, EventArgs e)
        {
            // Manejar el evento Clicked del botón Volver
            Navigation.PopAsync();
        }
        
        private void btnContacto_Clicked(object sender, EventArgs e)
        {
            // Manejar el evento Clicked del botón Contacto
            string phoneNumber = "+5492954333333";
            PhoneDialer.Default.Open(phoneNumber);
        }

        private async void btnEmail_Clicked(object sender, EventArgs e)
        {
            // Manejar el evento Clicked del botón Enviar
            var message = new EmailMessage
            {
                Subject = "Asunto",
                Body = "Me gustaria contactarme",
                To = new List<string> { "Tinagmail.com"}
            };
            await Email.ComposeAsync(message);
        }

        
    }
}
