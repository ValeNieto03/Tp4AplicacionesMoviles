using Tp4AplicacionesMoviles.Views;

namespace Tp4AplicacionesMoviles;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        //MainPage = new AppShell();
        MainPage = new NavigationPage(new LoginPage()); // Descomentado para la navegación de AppShell
    }
}
