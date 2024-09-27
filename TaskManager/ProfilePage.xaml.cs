namespace TaskManager;

public partial class ProfilePage : ContentPage
{
	public ProfilePage()
	{
		InitializeComponent();
	}
    private void OnEditProfileClicked(object sender, EventArgs e)
    {

        DisplayAlert("Edite profife", "Editing", "Ok");
    }

    
    private void OnLogoutClicked(object sender, EventArgs e)
    {
        DisplayAlert("Exit", "...", "OK");
        
        // Application.Current.MainPage = new LoginPage();
    }
}
