using CommunityToolkit.Maui.Views;
namespace TaskManager;

public partial class NewMember : ContentPage
{
    private string selectedGroup;
    public NewMember()
    {
        InitializeComponent();
    }
    private async void OnSelectGroupClicked(object sender, EventArgs e)
    {
        var groups = new List<string>()
        {
                "Group A",
                "Group B",
                "Group C",

        };
        var result = await DisplayActionSheet("Select Group", "Cancel", null, groups.ToArray());
        if (result != "Cancel")
        {
            selectedGroup = result;
            groupButton.Text = selectedGroup; 
        }
    }
    private async void OnSaveButtonClicked(object sender, EventArgs e)
    {

        var username = usernameEntry.Text;
        var password = passwordEntry.Text;


        if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(selectedGroup))
        {
            await DisplayAlert("Error", "Please fill all fields.", "OK");
            return;
        }


        var newUser = new Member { Username = username, Password = password, Group = selectedGroup };


        await DisplayAlert("Success", "User added successfully!", "OK");

        
        await Navigation.PopAsync();
    }
    private void OnSelectDominClicked(object sender, EventArgs e)
    {
        this.ShowPopup(new PopUpDomain());

    }
}



