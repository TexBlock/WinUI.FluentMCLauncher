using Microsoft.UI.Xaml.Controls;

using WinUI.MCLauncher.ViewModels;

namespace WinUI.MCLauncher.Views;

public sealed partial class MainPage : Page
{
    public MainViewModel ViewModel
    {
        get;
    }

    public MainPage()
    {
        ViewModel = App.GetService<MainViewModel>();
        InitializeComponent();
    }
}
