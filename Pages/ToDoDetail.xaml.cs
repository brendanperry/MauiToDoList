using MauiToDoList.ViewModels;

namespace MauiToDoList.Pages;

public partial class ToDoDetail
{
    public ToDoDetail(ToDoDetailViewModel viewModel)
    {
        InitializeComponent();

        BindingContext = viewModel;
    }
}