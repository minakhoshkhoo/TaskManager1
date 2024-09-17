using System;
using Taskmanager;
namespace TaskManager;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
	}
    private async void groupButton(object sender, EventArgs e)
    {
        Navigation.PushAsync(new GroupPage());
    }

    private async void peopleButton(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MemberPage());
    }

    private async void domainButton(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Domain());

    }

    private async void tasksButton(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Tasks());
    }
}
