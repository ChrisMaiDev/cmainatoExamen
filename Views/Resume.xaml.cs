namespace cmainatoExamen.Views;

public partial class Resume : ContentPage
{
    public Resume(string nombre, string apellido, string va, DateTime fecha, string ciudad, decimal montoInicial, decimal cuotaMensual)
    {
        InitializeComponent();

        // Asignar valores a las etiquetas
        nombreLabel.Text = nombre;
        apellidoLabel.Text = apellido;
        vaLabel.Text = va;
        fechaLabel.Text = fecha.ToShortDateString();
        ciudadLabel.Text = ciudad;
        montoInicialLabel.Text = montoInicial.ToString("C"); // Formato de moneda
        cuotaMensualLabel.Text = cuotaMensual.ToString("C"); // Formato de moneda

        // Calcular y mostrar el pago total
        decimal pagoTotal = montoInicial + (cuotaMensual * 3); // Suponiendo 3 cuotas
        pagoTotalLabel.Text = pagoTotal.ToString("C"); // Formato de moneda
    }

    private async void OnLogoutClicked(object sender, EventArgs e)
    {
        // Navegar de regreso al Login
        await Navigation.PopToRootAsync();
    }
}