using CommunityToolkit.Maui.Views;
using System.Collections.ObjectModel;

namespace TaskManager;

public partial class GroupPage : ContentPage
{

    public List<GroupItem> GroupList { get; set; } 
    public ObservableCollection<GroupItem> FilteredGroupItem { get; set; }
    public GroupPage()
	{
		InitializeComponent();
        GroupList = new List<GroupItem>()
        {
            new GroupItem { Name = "Group 1" },
            new GroupItem { Name = "Group 2" },
            new GroupItem { Name = "Group 3" },
            new GroupItem { Name = "Group 4" }
            
        };
        FilteredGroupItem = new ObservableCollection<GroupItem>(GroupList);

        
        GroupCollectionView.ItemsSource = FilteredGroupItem;
    }

    private void OnSearchTextChanged(object sender, TextChangedEventArgs e)
    {
        
        var searchText = e.NewTextValue?.ToLower() ?? string.Empty;

      
        FilteredGroupItem.Clear();

        
        if (string.IsNullOrWhiteSpace(searchText))
        {
            foreach (var group in GroupList)
            {
                FilteredGroupItem.Add(group);
            }
        }
        else
        {
            
            var filteredResults = GroupList.Where(g => g.Name.ToLower().Contains(searchText));
            foreach (var group in filteredResults)
            {
                FilteredGroupItem.Add(group);
            }
        }
    }

    
    public class GroupItem
    {
        public string Name { get; set; }
    }

    private async void OnAddButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new NewGroup());
    }
    //private void OnSearchTextChanged(object sender, TextChangedEventArgs e)
    //{
    //    string searchText = e.NewTextValue;
    //}

    private void OnSearchButtonPressed(object sender, EventArgs e)
    {

    }

}