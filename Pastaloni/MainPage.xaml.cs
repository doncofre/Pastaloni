namespace Pastaloni;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
        //lvUsuarios.SelectionMode = ListViewSelectionMode.None;
        //lvUsuarios.ItemTemplate = new DataTemplate(() =>
        //{
        //	var textCell = new TextCell();
        //	textCell.SetBinding(TextCell.TextProperty, "_Name");
        //          textCell.SetBinding(TextCell.TextProperty, "_Surname");
        //	return textCell;

        //      });
        //lvUsuarios.Header = "Lista de Usuarios";
        //var a = Controller.Controllers.PersonaController.returnsUserCtrl();
        List<string> list = new List<string>() { "Jhon Doe", "Jane Doe","Tom Hanks"};
        //lvUsers.ItemsSource = a.ToList();
        //lvUsers.BindingContext = a;
        ////Content = lvUsuarios;
        

    }

    private async void lvUsers_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        
        if(lvUsers.SelectedItem != null)
        {
            //logica aca
            DisplayAlert("Message", "", "OK");
            //await Navigation.PushAsync(new MainPage());
            
        }
    }

    private void lvUsers_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        lvUsers.SelectedItem = null;
    }
    private void Opcion1_Clicked(object sender, System.EventArgs e)
    {
        // Acciones para la Opción 1
    }

    private void Opcion2_Clicked(object sender, System.EventArgs e)
    {
        // Acciones para la Opción 2
    }
}

