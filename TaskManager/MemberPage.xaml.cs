using CommunityToolkit.Maui.Views;
using System.Collections.ObjectModel;

namespace TaskManager;


public partial class MemberPage : ContentPage
{
    public ObservableCollection<Member> Members { get; set; }
    public ObservableCollection<Member> FilteredMembers { get; set; }

    public MemberPage()
    {
        InitializeComponent();

        Members = new ObservableCollection<Member>
             {
                new Member { Username = "user1",GroupName="group A", PhoneNumber = "9756430", JobTitle = "Developer", Group = "A" },
                new Member { Username = "user2",GroupName="group B", PhoneNumber = "9846378", JobTitle= "Designer", Group = "B" },
                new Member { Username = "user3",GroupName="group C", PhoneNumber = "8664325", JobTitle = "Project Manager", Group = "C" },
                new Member { Username = "user4",GroupName="group D", PhoneNumber = "9787554", JobTitle = "Tester", Group = "D" },
                new Member { Username = "user5",GroupName="group E", PhoneNumber = "0898676", JobTitle = "Analyst", Group = "D" },
                new Member { Username = "user5",GroupName="group E", PhoneNumber = "0898676", JobTitle = "Analyst", Group = "D" },
                new Member { Username = "user5",GroupName="group E", PhoneNumber = "0898676", JobTitle = "Analyst", Group = "D" },
                new Member { Username = "user5",GroupName="group E", PhoneNumber = "0898676", JobTitle = "Analyst", Group = "D" },
                new Member { Username = "user5",GroupName="group E", PhoneNumber = "0898676", JobTitle = "Analyst", Group = "D" },
                new Member { Username = "user5",GroupName="group E", PhoneNumber = "0898676", JobTitle = "Analyst", Group = "D" },
            };
        FilteredMembers = new ObservableCollection<Member>(Members);
        BindingContext = this;
    }
    private async void OnDeleteUser(object sender, EventArgs e)
    {
        var swipeItem = sender as SwipeItem;
        var member = (sender as BindableObject)?.BindingContext as Member;

        if (member != null)
        {

            var result = await DisplayAlert("Confirm Delete", $"Are you sure you want to delete {member.Username}?", "Yes", "No");
            if (result)
            {

            }
        }
    }
    private async void OnMemberTapped(object sender, EventArgs e)
    {
        var tappedItem = (sender as Microsoft.Maui.Controls.Grid)?.BindingContext as Member; // Model for Member

        if (tappedItem != null)
        {
            string details = $"Name: {tappedItem.Username}\nPhone: {tappedItem.PhoneNumber}\nGroup: {tappedItem.Group}\nPosition: {tappedItem.JobTitle}";
            await DisplayAlert("Member Details", details, "OK");
        }
    }
    private async void OnGroupsButoonClicked(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new GroupPage());
    }
    private async void OnAddUserButtonClicked(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new NewMember());
    }
    private void OnSearchTextChanged(object sender, TextChangedEventArgs e)
    {
        string searchText = SearchEntry.Text?.ToLower();
        FilteredMembers.Clear();

        if (string.IsNullOrWhiteSpace(searchText))
        {
            foreach (var member in Members)
            {
                FilteredMembers.Add(member);
            }
        }
        else
        {
            var filteredResults = Members.Where(m => m.Username.ToLower().Contains(searchText));
            foreach (var member in filteredResults)
            {
                FilteredMembers.Add(member);
            }
        }
    }


    private async void DisplayMemberInfo(Member member)
    {
        string message = $"Name: {member.Username}\n" +
                         $"Phone Number: {member.PhoneNumber}\n" +
                         $"Job Title: {member.JobTitle}\n" +
                         $"Group: {member.Group}";

        await DisplayAlert("Member Information", message, "OK");
    }

}
public class Member
{
    public string Username { get; set; }
    public string PhoneNumber { get; set; }
    public string JobTitle { get; set; }
    public string Group { get; set; }
    public string Password { get; internal set; }
    public string ProfileImage { get; set; } 
    public string GroupName { get; set; }
}