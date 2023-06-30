using Pastaloni.Views.xLogin;
namespace Pastaloni;


public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        //MAIN PAGE
        Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));

        //XLogin						USER CONTROL
        Routing.RegisterRoute(nameof(Login), typeof(Login));
        Routing.RegisterRoute(nameof(Register), typeof(Register));
        Routing.RegisterRoute(nameof(ForgottenPassword), typeof(ForgottenPassword));

        //Administration


        //Trader

        //WareHouse

        



    }
}
