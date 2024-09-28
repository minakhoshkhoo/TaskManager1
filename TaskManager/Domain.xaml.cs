using System.Collections.ObjectModel;
using TaskManager;


namespace Taskmanager;

public partial class Domain : ContentPage
{
    public Domain()
    {
        InitializeComponent();
        
    }
    private void OnCompanyButtonClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new SubdomainsPage());

    }



}