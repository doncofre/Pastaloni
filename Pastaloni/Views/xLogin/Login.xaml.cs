namespace Pastaloni.Views.xLogin;

public partial class Login : ContentPage
{
	public Login()
	{
        this.BackgroundColor = Color.FromRgb(255, 255, 255);
        InitializeComponent();
        
    }
    private void btnLogin_Clicked(object sender, EventArgs e)
    {
        //Controller.UserController.GetUser()
        var us = new
        {
            user = "doncofre",
            password = "123123"
        };
        if( txtUser.Text.Length > 0 || 
            txtPassword.Text.Length > 0 || 
            ((txtUser.Text.Length >0 || txtUser.Text.Length != null) && 
            (txtPassword.Text.Length > 0 || txtPassword.Text.Length != null) )
           ) 
        { 
            if(txtUser.Text == us.user && txtPassword.Text == us.password)
            {
                Shell.Current.GoToAsync("//MainPage");
            }
            else
            {
                DisplayAlert("Incorrect Input", "You entered an invalid user", "OK");
            }
        }
        else
        {
            DisplayAlert("Incorrect Input","You should enter caracteres","OK");
        }
        
    }
    private void btnRegister_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("Register");
    }
    private void btnPasswordForgotten_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("ForgottenPassword");
    }
    
    
}