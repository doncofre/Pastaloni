using Microsoft.Maui.Controls;

namespace Pastaloni.Views.xLogin;

public partial class Register : ContentPage
{
    public Register()
    {
        this.BackgroundColor = Color.FromRgb(255, 255, 255);
        InitializeComponent();
        //RegisterViewModel viewModel = new RegisterViewModel();


    }

    private void btnRegister_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("ADV", "USER CREATED CORRECTLY", "OK");
        Shell.Current.GoToAsync("..");
    }
    private void btnCancel_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("Login");
    }
}