using CommunityToolkit.Maui.Views;
using Microsoft.VisualBasic;
namespace TaskManager;

using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Storage;

public partial class NewTask : ContentPage
{
       
    public NewTask()
    {
        InitializeComponent();

    }

    //deadline
    private void OnSetDeadlineClicked(object sender, EventArgs e)
    {

        DateTime selectedDate = DeadlineDatePicker.Date;

        TimeSpan selectedTime = DeadlineTimePicker.Time;

        DateTime deadline = selectedDate.Date + selectedTime;

        DeadlineLabel.Text = $"Selected Deadline: {deadline:dddd, MMMM d, yyyy h:mm tt}";
    }

    //file attach
    private void OnprerequistesButtonClicked(object sender, EventArgs e)
    {
        this.ShowPopup(new File());

    }

    //couple
    private void OnSearchTextChanged(object sender, TextChangedEventArgs e)
    {
        string searchText = e.NewTextValue;
    }

    private void OnSearchButtonPressed(object sender, EventArgs e)
    {

    }
    public class Task
    {
        public string Title { get; set; }
    }

    //previous && next
    private void OnTaskTypeButtonClicked(object sender, EventArgs e)
    {
        this.ShowPopup(new TaskType());

    }

    //save button
    private async void OnSaveButtonClicked(object sender, EventArgs e)
    {
       
    }
    //description
    private void OnAddButtonClicked(object sender, EventArgs e)
    {
        this.ShowPopup(new Description());

    }
}



