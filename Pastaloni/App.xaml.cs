namespace Pastaloni;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		//MainPage = new AppShell();


        var shell = new Shell();

        // Crear y configurar los botones de menú
        var opcion1 = new MenuItem
        {
            Text = "Opción 1",
            Command = new Command(() =>
            {
                // Acciones para la Opción 1
            })
        };

        var opcion2 = new MenuItem
        {
            Text = "Opción 2",
            Command = new Command(() =>
            {
                // Acciones para la Opción 2
            })
        };

        // Agregar los botones de menú a la barra de pestañas
        shell.Items.Add(new ShellContent
        {
            Title = "Opción 1",
            Icon = "icon1.png",
            Content = new ContentPage()
        });

        shell.Items.Add(new ShellContent
        {
            Title = "Opción 2",
            Content = new ContentPage()
        });

        MainPage = shell;
    }
}
