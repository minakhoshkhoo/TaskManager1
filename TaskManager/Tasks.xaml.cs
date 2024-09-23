using CommunityToolkit.Maui.Views;
using System.Collections.ObjectModel;
using System.Diagnostics;
using static Taskmanager.Domain;

namespace TaskManager;

public partial class Tasks : ContentPage
{
    int count = 0;
    public List<TaskItem> TaskList { get; set; }
    
    public ObservableCollection<TaskItem> FilteredTaskItem { get; set; }

    public Tasks()
    {
        InitializeComponent();

        TaskList = new List<TaskItem>()
        {
            new TaskItem { Name = "Task 1" ,IsSelected = false},
            new TaskItem { Name = "Task 2",IsSelected = false },
            new TaskItem { Name = "Task 3",IsSelected = false },
            new TaskItem { Name = "Task 4",IsSelected = false },
            new TaskItem { Name = "Task 4",IsSelected = false },
            new TaskItem { Name = "Task 4",IsSelected = false },
            new TaskItem { Name = "Task 4",IsSelected = false },
            new TaskItem { Name = "Task 4",IsSelected = false },
            new TaskItem { Name = "Task 4",IsSelected = false },
            new TaskItem { Name = "Task 4",IsSelected = false },
            new TaskItem { Name = "Task 4",IsSelected = false },
            new TaskItem { Name = "Task 4",IsSelected = false },
            new TaskItem { Name = "Task 4",IsSelected = false },
            new TaskItem { Name = "Task 4",IsSelected = false },
        };

        FilteredTaskItem = new ObservableCollection<TaskItem>(TaskList);

        TaskCollectionView.ItemsSource = FilteredTaskItem;
        
    }



    private async void OnAddTaskClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new NewTask());
    }
    public class TaskItem
    {
        public string Name { get; set; }
        public bool IsSelected { get; set; }
    }
    private async void OnAddButtonClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new NewTask());
    }
    
    private void OnSearchTextChanged(object sender, TextChangedEventArgs e)
    {
        var searchText = e.NewTextValue?.ToLower() ?? string.Empty;

        
        FilteredTaskItem.Clear();

        
        if (string.IsNullOrWhiteSpace(searchText))
        {
            foreach (var task in TaskList)
            {
                FilteredTaskItem.Add(task);
            }
        }
        else
        {
            
            var filteredResults = TaskList.Where(t => t.Name.ToLower().Contains(searchText));
            foreach (var task in filteredResults)
            {
                FilteredTaskItem.Add(task);
            }
        }
    }

    }






























//private void PopUpButton_Clicked(object sender, EventArgs e)
//{
//    App.Current.MainPage = new Tasks();
//}

//private void OnAddButtonClicked(object sender, EventArgs e)
//{
//    this.ShowPopup(new NewTask());
//}
