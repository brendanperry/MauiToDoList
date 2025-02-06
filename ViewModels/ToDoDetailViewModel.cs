using CommunityToolkit.Mvvm.ComponentModel;
using MauiToDoList.Models;

namespace MauiToDoList.ViewModels;

[QueryProperty("Item", "Item")]
public partial class ToDoDetailViewModel : ObservableObject
{
    [ObservableProperty] private ToDoItem item;
}