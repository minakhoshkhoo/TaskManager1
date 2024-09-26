using CommunityToolkit.Maui.Views;
using System.Collections.ObjectModel;
namespace TaskManager;

public partial class NewGroup : ContentPage
{
    public ObservableCollection<Member> Members { get; set; }
    public NewGroup()
    {
        InitializeComponent();

        Members = new ObservableCollection<Member>
            {
                new Member { Name = "User1" },
                new Member { Name = "User2" },
                new Member { Name = "User3" },
                new Member { Name = "User3" },
                new Member { Name = "User3" },
                new Member { Name = "User3" },
                new Member { Name = "User3" }
            };
        membersCollectionView.ItemsSource = Members;
    }
    private void OnShowMembersButtonClicked(object sender, EventArgs e)
    {

        membersFrame.IsVisible = !membersFrame.IsVisible;

    }
    private void OnAddGroupsButtonClicked(object sender, EventArgs e)
    {

    }
    private void OnSaveButtonClicked(object sender, EventArgs e)
    {
        var selectedMembers = Members.Where(m => m.IsSelected).ToList();

        if (!string.IsNullOrWhiteSpace(groupNameEntry.Text) && !string.IsNullOrWhiteSpace(groupidEntry.Text) && selectedMembers.Any())
        {
            DisplayAlert("Group Saved", $"Group '{groupNameEntry.Text}' with {selectedMembers.Count} members added.", "OK");

            membersFrame.IsVisible = false;
            showMembersButton.IsVisible = true;
        }
        else
        {
            DisplayAlert("Error", "Please enter group details and select at least one member.", "OK");
        }
    }
    private void OnSaveGroupButtonClicked(object sender, EventArgs e)
    {
        string groupName = groupNameEntry.Text;
        string groupId = groupidEntry.Text;
    }
    public class Member
    {
        public string Name { get; set; }
        public bool IsSelected { get; set; }
    }
}