using System.Collections.ObjectModel;

namespace TaskManager;

public partial class SubdomainsPage : ContentPage
{
    public ObservableCollection<dynamic> Subdomains { get; set; }

    public SubdomainsPage()
    {
        InitializeComponent();
        Subdomains = new ObservableCollection<dynamic>
            {
                new { Name = "Taskmanager Development Team 1", Description = "Tasks : Build the Base Of Taskmanager ", NumberOfMembers = "Number of members : 3", Members = "SajjadSharify , MinaKoshkhoo , Maedeh Ayoubinia " ,Taskcompletestatus =" 90 % " },
                new { Name = "Taskmanager Development Team 2", Description = "Tasks : Make UI For App ", NumberOfMembers = "Number Of Memebrs: 3", Members = "Member one, Member Two, Member Three" ,Taskcompletestatus =" n % " },
                new { Name = "Taskmanager Development Team 3", Description = "Tasks : Handle Process of App", NumberOfMembers = " Number Of Members: 3 ", Members = "Member One , Memebr Two , Member Three", Taskcompletestatus = " m % " },
                new { Name = "Subdomain 4", Description = "Description of Subdomain 4", NumberOfMembers = "3", Members = "Kim, Lee, Mike" ,Taskcompletestatus =" Task Complete Status " },
                new { Name = "Subdomain 5", Description = "Description of Subdomain 5", NumberOfMembers = "7", Members = "Nancy, Owen, Peter, Quincy, Rachel, Sam, Tom" ,Taskcompletestatus =" Task Complete Status " },
                new { Name = "Subdomain 6", Description = "Description of Subdomain 6", NumberOfMembers = "2", Members = "Uma, Victor", Taskcompletestatus = " Task Complete Status " },
                new { Name = "Subdomain 7", Description = "Description of Subdomain 7", NumberOfMembers = "5", Members = "Wendy, Xavier, Yara, Zack, Amy" ,Taskcompletestatus =" Task Complete Status " },
                new { Name = "Subdomain 8", Description = "Description of Subdomain 8", NumberOfMembers = "8", Members = "Ben, Chris, Diana, Evan, Fiona, George, Hazel, Ivy" ,Taskcompletestatus =" Task Complete Status " },
                new { Name = "Subdomain 9", Description = "Description of Subdomain 9", NumberOfMembers = "4", Members = "Jake, Karl, Liam, Mia" ,Taskcompletestatus =" Task Complete Status " }
            };


        BindingContext = this;
    }
}