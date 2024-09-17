using CommunityToolkit.Maui.Views;
using System.Formats.Tar;
namespace TaskManager;

public partial class NewGroup : CommunityToolkit.Maui.Views.Popup
{
    public NewGroup()
    {
        InitializeComponent();
    }
    private  void PopUpButto_Clicked(object sender, EventArgs e)
    {
        App.Current.MainPage = new GroupPage();
    }
    //private void OnAddClicked(object sender, EventArgs e)
    //{
        //var name = NameEntry.Text;
        //var description = DescriptionEntry.Text;
        //var taskName = TaskEntry.Text;
        //Console.WriteLine($"Name:{name},Description:{description},Task:{taskName}");
        //if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(taskName))
        //{
            //return;
        //}
    //}
}