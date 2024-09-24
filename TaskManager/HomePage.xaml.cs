using System;
using Taskmanager;
namespace TaskManager;

public partial class HomePage : ContentPage
{
    private bool _isFlyoutVisible = false;

    public HomePage()
    {
        InitializeComponent();
    }

    private async void OnMenuClicked(object sender, EventArgs e)
    {
        if (_isFlyoutVisible)
        {
            await FlyoutMenu.TranslateTo(-250, 0, 250, Easing.SinIn);
            FlyoutMenu.IsVisible = false;
        }
        else
        {
            FlyoutMenu.IsVisible = true;
            await FlyoutMenu.TranslateTo(0, 0, 250, Easing.SinIn);
        }

        _isFlyoutVisible = !_isFlyoutVisible;
    }
    private void ProfileClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ProfilePage());
    }

    private void ProfileImageClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ProfilePage());
    }
    private void TasksImageClicked(object sender, EventArgs e)
    {

        Navigation.PushAsync(new Tasks());
    }

    private void TasksClicked(object sender, EventArgs e)
    {

        Navigation.PushAsync(new Tasks());
    }
    private void GroupsImageClicked(object sender, EventArgs e)
    {

        Navigation.PushAsync(new GroupPage());
    }

    private void GroupsClicked(object sender, EventArgs e)
    {

        Navigation.PushAsync(new GroupPage());
    }
    private void peopleButton(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MemberPage()); ;

    }

    private void domainButton(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Domain()); ;
    }

    private void taskButton(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Tasks());

    }
    private async void OnMainContentTapped(object sender, EventArgs e)
    {
        // close a menu
        await FlyoutMenu.TranslateTo(-250, 0, 250, Easing.SinIn);
        FlyoutMenu.IsVisible = false;
        _isFlyoutVisible = false;
    }

    private void Button_Clicked(object sender, EventArgs e)
    {

    }
}


