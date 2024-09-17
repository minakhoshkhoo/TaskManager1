using CommunityToolkit.Maui.Views;

namespace TaskManager;

public partial class GroupPage : ContentPage
{
	public GroupPage()
	{
		InitializeComponent();
	}
    private void OnAddButtonClicked(object sender, EventArgs e)
    {
        this.ShowPopup(new NewGroup());

    }

}