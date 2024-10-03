using System.Windows;
using Wpf.Ui;
using WpfLepo.Demo.ViewModels;

namespace WpfLepo.Demo;

public partial class MainWindow : Window
{
    public MainWindow(IPageService pageService, MainWindowViewModel model)
    {
        DataContext = model;
        InitializeComponent();

        RootNavigationView.SetPageService(pageService);
    }
}