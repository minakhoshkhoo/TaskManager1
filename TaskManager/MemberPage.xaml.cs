using CommunityToolkit.Maui.Views;
using System.Collections.ObjectModel;

namespace TaskManager;
public class Member
{
    public string Name { get; set; }
    public string ProfilePicture { get; set; }
    public string Description { get; set; }
}

public partial class MemberPage : ContentPage
{
    

    public MemberPage()
    {
        InitializeComponent();
        
    }
    

    //open new member
    private async void OnAddButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new NewMember());
    }

    // open a group page
    private async void groupButton(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new GroupPage());
    }
    private void OnSearchTextChanged(object sender, TextChangedEventArgs e)
    {
        string searchText = e.NewTextValue;
        
    }

    private void OnSearchButtonPressed(object sender, EventArgs e)
    {

    }

}