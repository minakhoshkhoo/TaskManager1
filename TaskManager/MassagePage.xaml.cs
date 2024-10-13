namespace TaskManager;
using System.Collections.ObjectModel;
public partial class MassagePage : ContentPage
{
    private ObservableCollection<string> messages;
    public MassagePage()
    {
        InitializeComponent();
        messages = new ObservableCollection<string>();
        messagesListView.ItemsSource = messages;
    }
    private void OnSendMessageClicked(object sender, EventArgs e)
    {
        var message = messageEntry.Text;

        if (!string.IsNullOrWhiteSpace(message))
        {
            messages.Add(message);
            messageEntry.Text = string.Empty;
        }
        else
        {
            // Optionally show a message to the user
            DisplayAlert("Warning", "Message cannot be empty.", "OK");
        }
    }
}