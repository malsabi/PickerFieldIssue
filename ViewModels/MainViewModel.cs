using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PickerFieldIssue.Models;
using System.Collections.ObjectModel;

namespace PickerFieldIssue.ViewModels;

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty]
    private ObservableCollection<ProgramModel> programs = [];

    public MainViewModel()
    {
        LoadData();
    }


    [RelayCommand]
    private static void ToggleTheme()
    {
        if (Application.Current == null)
            return;

        if (Application.Current.UserAppTheme == AppTheme.Dark)
            Application.Current.UserAppTheme = AppTheme.Light;
        else
            Application.Current.UserAppTheme = AppTheme.Dark;
    }

    private void LoadData()
    {
        for (int i = 0; i < 5; i++)
        {
            Programs.Add(new ProgramModel()
            {
                Id = i.ToString(),
                Name = "English " + (i + 1),
            });
        }
    }
}