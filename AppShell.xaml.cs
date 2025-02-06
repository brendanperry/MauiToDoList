using MauiToDoList.Pages;

namespace MauiToDoList;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute(nameof(ToDoDetail), typeof(ToDoDetail));
    }
}