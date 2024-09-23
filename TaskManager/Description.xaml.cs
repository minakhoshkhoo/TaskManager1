namespace TaskManager;
using CommunityToolkit.Maui.Views;


public partial class Description : Popup
{
    

    public Description()
	{
		InitializeComponent();
	}
    private void PopUpButto_Clicked(object sender, EventArgs e)
    {
        App.Current.MainPage = new NewMember();
    }
    private void OnCancelClicked(object sender, EventArgs e)
    {
        
    }
    private void Button_Clicked(object sender, EventArgs e,string description)
    {

        Console.WriteLine($"Description: {description}");
    }

    private void Button_Clicked(object sender, EventArgs e)
    {

    }

}