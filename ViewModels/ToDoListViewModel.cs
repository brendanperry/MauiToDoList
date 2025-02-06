using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiToDoList.Models;
using MauiToDoList.Pages;

namespace MauiToDoList.ViewModels;

public partial class ToDoListViewModel : ObservableObject
{
    public ObservableCollection<ToDoItem> ToDoItems { get; set; } =
    [
        new() { Title = "Buy some milk", SubTitle = "2%" },
        new() { Title = "Pick up the kids", SubTitle = "From school" },
        new() { Title = "Feed the dog", SubTitle = "Before 5pm" },
        new() { Title = "Take out the trash", SubTitle = "After 6pm" },
        new() { Title = "Do the laundry", SubTitle = "Before 7pm" },
        new() { Title = "Water the plants", SubTitle = "Before 8pm" },
        new() { Title = "Mow the lawn", SubTitle = "Before 9pm" },
        new() { Title = "Clean the house", SubTitle = "Before 10pm" },
        new() { Title = "Go to bed", SubTitle = "Before 11pm" },
        new() { Title = "Sleep", SubTitle = "Before 12am" }
    ];

    [RelayCommand]
    private void AddItem()
    {
        ToDoItems.Add(new ToDoItem { Title = "New Title", SubTitle = "New Subtitle" });
    }

    [RelayCommand]
    private void DeleteItem(ToDoItem toDoItem)
    {
        ToDoItems.Remove(toDoItem);
    }

    [RelayCommand]
    private async Task TapItem(ToDoItem toDoItem)
    {
        await Shell.Current.GoToAsync(nameof(ToDoDetail), new Dictionary<string, object>
        {
            { "Item", toDoItem }
        });
    }
}