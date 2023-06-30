using Microsoft.Maui.Controls.PlatformConfiguration.AndroidSpecific;
using Microsoft.Maui.Graphics.Text;
using Pastaloni.Views.xLogin;

namespace Pastaloni;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
        Shell.Current.GoToAsync("Login");
		
        InitializeComponent();
        AddMenuByRole();



    }
    private void AddMenuByRole()
    {
        var menuTrader = new MenuFlyoutItem()
        {
            Text = "Trader"
        };

        var menuWareHouse = new MenuFlyoutItem()
        {
            Text = "WareHouse"
        };

        var menuAdmin = new MenuFlyoutItem()
        {
            Text = "Admin"
        };



        string role = "admin";
        switch (role)
        {
            case "admin":
                menuBar.Add(menuTrader);
                menuBar.Add(menuWareHouse);
                menuBar.Add(menuAdmin);
                break;


            case "trader":
                menuBar.Add(menuTrader);
                break;

            case "WareHouse":
                menuBar.Add(menuWareHouse);
                break;

            default:
                break;


        }
    }

    private void OnCounterClicked(object sender, EventArgs e)
	{
		//count++;

		//if (count == 1)
		//	CounterBtn.Text = $"Clicked {count} time";
		//else
		//	CounterBtn.Text = $"Clicked {count} times";

		//SemanticScreenReader.Announce(CounterBtn.Text);
		
	}
	private void menuSell_Clicked(object sender, EventArgs e)
	{
		DisplayAlert("asd", "asd", "asd");
	}
    private void menuWareHouse_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("asd", "asd", "asd");
    }
    private void menuTrader_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("asd", "asd", "asd");
    }
    private void menuAdmin_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("asdad", "asdasd", "asdasd");
    }
}

