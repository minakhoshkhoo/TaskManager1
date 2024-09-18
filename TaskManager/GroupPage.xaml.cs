using CommunityToolkit.Maui.Views;

namespace TaskManager;

public partial class GroupPage : ContentPage
{
	public GroupPage()
	{
		InitializeComponent();
	}
    private async void OnAddButtonClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new NewGroup());
    }

    //private void OnAddButtonClicked(object sender, EventArgs e)
    //{
    //    this.ShowPopup(new NewGroup());

    //}

}