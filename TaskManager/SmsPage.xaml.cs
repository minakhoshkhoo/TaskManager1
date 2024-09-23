using System;
namespace TaskManager;

public partial class SmsPage : ContentPage
{
	public SmsPage()
	{
		InitializeComponent();
	}
    protected override void OnAppearing()
    {
        base.OnAppearing();
        timerFunc();
    }
    private void timerFunc()
    {
        for (int i = 3; i >= 0; i--)
        {
            for (int j = 59; j >= 0; j--)
            {
                timerLabel.Text = $"{i}:{j}";
                Task.Delay(1000);
            }
        }
    }
    private void doneButton(object sender, EventArgs e)
    {
        App.Current.MainPage = new  NavigationPage (new HomePage());

    }
}