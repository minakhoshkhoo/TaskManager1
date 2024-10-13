using System;
namespace TaskManager
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
        }
        string username = "mina";
        string password = "8282";
        private void PasswordShow(object sender, EventArgs e)
        {
            passwordEntry.IsPassword = !passwordEntry.IsPassword;
        }
        private void LoginButton(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(userNameEntry.Text) && !string.IsNullOrEmpty(passwordEntry.Text))
            {
                if (userNameEntry.Text == username && passwordEntry.Text == password)
                {
                    App.Current.MainPage = new SmsPage();
                }
                else
                {
                    DisplayAlert("Heey", "Something wrong", "...");
                }

                App.Current.MainPage = new SmsPage();
            }
            else
            {
                DisplayAlert("Heey", "Something wrong", "...");
            }
        }
    }
}

