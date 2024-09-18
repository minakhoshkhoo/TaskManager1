using CommunityToolkit.Maui.Views;

namespace TaskManager;

public partial class MemberPage : ContentPage
{
    public MemberPage()
    {
        InitializeComponent();
    }
    private async void OnAddButtonClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new NewMember());
    }

}