using MauiToDoList.ViewModels;

namespace MauiToDoList.Pages;

public partial class ToDoList
{
    public ToDoList()
    {
        InitializeComponent();
        BindingContext = new ToDoListViewModel();
    }
}