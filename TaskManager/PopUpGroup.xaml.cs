namespace TaskManager;
using CommunityToolkit.Maui.Views;
using System.Text.RegularExpressions;

public partial class PopUpGroup :CommunityToolkit.Maui.Views.Popup
{
    public List<Group> Groups { get; set; }
    public PopUpGroup()
	{
		InitializeComponent();
        Groups = new List<Group>
        {
            new Group { Name = "Group 1", IsSelected = false },
            new Group { Name = "Group 2", IsSelected = false },
            new Group { Name = "Group 3", IsSelected = false },
        };

        GroupCollectionView.ItemsSource = Groups;
    }

    private async void OnConfirmClicked(object sender, EventArgs e)
    {
        var selectedGroup = Groups.FirstOrDefault(g => g.IsSelected);
        if (selectedGroup != null)
        {
           
        }
    }
    public class Group
    {
        public string Name { get; set; }
        public bool IsSelected { get; set; }
    }
    private async void PopUpButto_Clicked(object sender, EventArgs e)
    {
        App.Current.MainPage = new NewGroup();
    }
    Switch switchControl = new Switch { IsToggled = true };
}

