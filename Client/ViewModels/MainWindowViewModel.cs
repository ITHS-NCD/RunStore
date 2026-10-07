using System;
using Client.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Client.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    private readonly HomeViewModel _homeView = new();
    private readonly ProductsViewModel _productView = new();
    private readonly SettingsViewModel _settingsView = new();

    [ObservableProperty]
    public partial ViewModelBase CurrentView { get; set; }

    public MainWindowViewModel()
    {
        CurrentView = _homeView;
    }

    [RelayCommand]
    private void GoToHome() => CurrentView = _homeView;

    [RelayCommand]
    private void GoToProducts() => CurrentView = _productView;

    [RelayCommand]
    private void GoToSettings() => CurrentView = _settingsView;

}