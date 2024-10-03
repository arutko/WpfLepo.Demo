using Wpf.Ui.Controls;
using WpfLepo.Demo.ViewModels;

namespace WpfLepo.Demo.Views;

public partial class AllSamplesPage : INavigableView<AllSamplesViewModel>
{
    public AllSamplesViewModel ViewModel { get; init; }

    public AllSamplesPage(AllSamplesViewModel viewModel)
    {
        ViewModel = viewModel;
        DataContext = this;

        InitializeComponent();
    }
}