using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using Wpf.Ui.Controls;
using WpfLepo.Demo.Views;

namespace WpfLepo.Demo.ViewModels;

public partial class MainWindowViewModel : ObservableObject
{
    [ObservableProperty]
    private ObservableCollection<object> _navigationItems = [];

    public MainWindowViewModel()
    {
        NavigationItems =
        [
            new NavigationViewItem()
            {
                Content = "Home",
                Icon = new SymbolIcon { Symbol = SymbolRegular.Home24 },
                TargetPageType = typeof(HomePage)
            },
            new NavigationViewItem()
            {
                Content = "Design Guidance",
                TargetPageType = typeof(DesignGuidancePage)
            },
        ];
    }
}
