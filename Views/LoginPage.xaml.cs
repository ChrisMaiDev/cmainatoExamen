using Microsoft.Win32;

namespace cmainatoExamen.Views;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
    }

    // Matriz para almacenar usuarios y contraseñas
    private readonly (string User, string Password)[] _users =
        {
            ("estudiante2024", "uisrael2024"),
            ("examen1", "parcial1"),
            ("NombreEstudiante", "2024")
        };



    private void OnLoginClicked(object sender, EventArgs e)
    {

        var usuario = txtUsuario.Text;
        var contrasena = txtContrasena.Text;
        bool isValidUser = false;
        foreach (var user in _users)
        {
            if (user.User == usuario && user.Password == contrasena)
            {
                isValidUser = true;
                Navigation.PushAsync(new RegistroPage("Usuario Conectado: "+usuario));
                break;
            }
        }
        if (!isValidUser)
        {
            DisplayAlert("Error", "Usuario o contraseña incorrectos", "OK");

        }
    }
    private async void OnAboutClicked(object sender, EventArgs e)
    {
        DisplayAlert("INFORMACION", "Desarrollado por Christian Mainato", "OK");
    }

}
