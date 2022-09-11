using Microsoft.UI.Xaml.Controls;

using WinUI.MCLauncher.ViewModels;

namespace WinUI.MCLauncher.Views;

public sealed partial class BlankPage : Page
{
    public BlankViewModel ViewModel
    {
        get;
    }

    public BlankPage()
    {
        ViewModel = App.GetService<BlankViewModel>();
        InitializeComponent();
    }
}
