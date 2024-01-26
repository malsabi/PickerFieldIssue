using PickerFieldIssue.ViewModels;

namespace PickerFieldIssue;

public partial class MainPage : ContentPage
{
    public MainPage(MainViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}