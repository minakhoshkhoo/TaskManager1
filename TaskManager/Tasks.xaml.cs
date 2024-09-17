using System.Collections.ObjectModel;

namespace TaskManager;

public partial class Tasks : ContentPage
{
    public ObservableCollection<Task> Task { get; set; } = new ObservableCollection<Task>();
    public ObservableCollection<TaskItem> TaskS { get; }

    public class TaskItem
    {
        public string ImageSource { get; set; }
        public string TaskDescription { get; set; }
    }

    public Tasks()
    {
        InitializeComponent();

        TaskS = new ObservableCollection<TaskItem>
        {
            new TaskItem { ImageSource = "image1.png", TaskDescription = "Task 1" },
            new TaskItem { ImageSource = "image1.png", TaskDescription = "Task 2" }
        };
        BindingContext = this;
    }



    private void OnAddButtonClicked(object sender, EventArgs e)
    {

    }


}