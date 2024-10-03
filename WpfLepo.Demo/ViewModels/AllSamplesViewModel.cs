using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows.Controls;

namespace WpfLepo.Demo.ViewModels;

public partial class AllSamplesViewModel : ObservableObject
{
    // Anchor //

    [ObservableProperty]
    private bool _isAnchorEnabled = true;

    [RelayCommand]
    private void OnAnchorCheckboxChecked(object sender)
    {
        if (sender is not CheckBox checkbox) return;
        IsAnchorEnabled = !(checkbox?.IsChecked ?? false);
    }

    // AutoSuggestBox //

    [ObservableProperty]
    private List<string> _autoSuggestBoxSuggestions =
        new()
        {
            "John",
            "Winston",
            "Adrianna",
            "Spencer",
            "Phoebe",
            "Lucas",
            "Carl",
            "Marissa",
            "Brandon",
            "Antoine",
            "Arielle",
            "Arielle",
            "Jamie",
            "Alexzander"
        };
}
