namespace cmainatoExamen.Views;

public partial class RegistroPage : ContentPage
{
    public string Username { get; set; }
    private decimal cuotaMensual;
    public RegistroPage(string username)
    {
        InitializeComponent();
        Username = username;
        BindingContext = this; // Para enlazar el nombre de usuario
    }

    private async void OnCalculateClicked(object sender, EventArgs e)
    {
        double costo = 300;
        double montoInicial = double.TryParse(montoInicialEntry.Text, out var result) ? result : 0;

        double cuotaMensual = (costo - (0.15 * costo)) / 3 * 1.05; // Sumar 5% a cada cuota

        cuotaMensualEntry.Text = cuotaMensual.ToString("F2");
    }

    private async void OnSummaryClicked(object sender, EventArgs e)
    {
        string nombre = nombreTxt.Text;
        string apellido = apellidoTxt.Text;
        string va = vaPicker.SelectedItem?.ToString();
        DateTime fecha = fechaPicker.Date;
        string ciudad = ciudadPicker.SelectedItem?.ToString();
        decimal montoInicial = decimal.Parse(montoInicialEntry.Text);

        // Pasar la cuota mensual calculada
        await Navigation.PushAsync(new Resume(nombre, apellido, va, fecha, ciudad, montoInicial, cuotaMensual));
    }
}
