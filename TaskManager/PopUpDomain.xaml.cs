using TaskManager;
using CommunityToolkit.Maui.Views;
namespace TaskManager;

public partial class PopUpDomain : CommunityToolkit.Maui.Views.Popup
{
    public List<Domain> Domains { get; set; }
    public PopUpDomain()
    {
        InitializeComponent();

        Domains = new List<Domain>
        {
            new Domain { Name = "Domain 1", IsSelected = false },
            new Domain { Name = "Domain 2", IsSelected = false },
            new Domain { Name = "Domain 3", IsSelected = false },
        };

        DomainCollectionView.ItemsSource = Domains;
    }
    private async void OnConfirmClicked(object sender, EventArgs e)
    {
        var selectedDomain = Domains.FirstOrDefault(D => D.IsSelected);
        if (selectedDomain != null)
        {

        }

    }
    public class Domain
    {
        public string Name { get; set; }
        public bool IsSelected { get; set; }
    }
    private async void PopUpButto_Clicked(object sender, EventArgs e)
    {
        App.Current.MainPage = new NewMember();
    }
    Switch switchControl = new Switch { IsToggled = true };
    
}