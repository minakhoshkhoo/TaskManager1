namespace TaskManager;
using CommunityToolkit.Maui.Views;

public partial class File : CommunityToolkit.Maui.Views.Popup
{
	public File()
	{
		InitializeComponent();
	}
    private async void OnAttachFileClicked(object sender, EventArgs e)
    {
        try
        {
            var result = await FilePicker.PickAsync(new PickOptions
            {
                PickerTitle = "Select a file"

            });

            if (result != null)
            {
                prerequisteLbel.Text = $"Selected file: {result.FileName}";
            }


        }
        catch (Exception ex)
        {
            prerequisteLbel.Text = $"Error picking file: {ex.Message}";
        }



    }
    private async void PopUpButto_Clicked(object sender, EventArgs e)
    {
        App.Current.MainPage = new NewTask();
    }
}