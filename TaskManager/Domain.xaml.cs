using System.Collections.ObjectModel;
using TaskManager;


namespace Taskmanager;

public partial class Domain : ContentPage
{
    public Domain()
    {
        InitializeComponent();
        BindingContext = new TasksViewModel();
    }
    private async void cpsaButton(object sender, EventArgs e)
    {
        //await Navigation.PushAsync(new CPSADomain());
    }

    private void nextcompanyButton(object sender, EventArgs e)
    {

    }

    public class TasksViewModel
    {
        public ObservableCollection<TaskItem> Tasks { get; set; }

        public TasksViewModel()
        {
            Tasks = new ObservableCollection<TaskItem>
            {
                new TaskItem { Title = "Task 1", IsCompleted=false },
                new TaskItem { Title = "Task 2", IsCompleted = true },
                new TaskItem { Title = "Task 3", IsCompleted = false },

            };
        }
    }

    public class TaskItem
    {
        public string Title { get; set; }
        public bool IsCompleted { get; set; }
    }

    private void OnSearchTextChanged(object sender, TextChangedEventArgs e)
    {


    }
    private void OnAddTaskButtonClicked(object sender, EventArgs e)
    {


    }
    private void OnAddDomainClicked(object sender, EventArgs e)
    {


    }



}