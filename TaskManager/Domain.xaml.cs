using System.Collections.ObjectModel;
using TaskManager;


namespace Taskmanager;

public partial class Domain : ContentPage
{
    public Domain()
    {
        InitializeComponent();
        
    }

    private void nextcompanyButton(object sender, EventArgs e)
    {

    }
    private void OnSearchTextChanged(object sender, TextChangedEventArgs e)
    {


    }
    private void OnAddTaskButtonClicked(object sender, EventArgs e)
    {


    }
    private void OnCompanyButtonClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new SubdomainsPage());

    }



}