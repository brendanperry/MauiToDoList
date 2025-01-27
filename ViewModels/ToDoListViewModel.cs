using System.Collections.ObjectModel;
using System.Windows.Input;
using MauiToDoList.Models;

namespace MauiToDoList.ViewModels;

public class ToDoListViewModel
{
    public ToDoListViewModel()
    {
        AddItemCommand = new Command(() =>
        {
            ToDoItems.Add(new ToDoItem { Title = "New Title", SubTitle = "New Subtitle" });
        });

        DeleteItemCommand = new Command(toDoItem =>
        {
            if (toDoItem is ToDoItem item)
                ToDoItems.Remove(item);
        });
    }

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

    public ICommand AddItemCommand { private set; get; }
    public ICommand DeleteItemCommand { private set; get; }
}