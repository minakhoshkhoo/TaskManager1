using CommunityToolkit.Maui.Views;
namespace TaskManager;

public partial class NewMember : ContentPage
{
	public NewMember()
	{
		InitializeComponent();
    }
    private void OnAddButtonClicked(object sender, EventArgs e)
    {
        this.ShowPopup(new PopUpGroup());

    }
    private void OnAddDomainClicked(object sender, EventArgs e)
    {
        this.ShowPopup(new PopUpDomain());

    }
    private void OnAddSaveClicked(object sender, EventArgs e)
    {

    }
}