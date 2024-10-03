using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows;
using Wpf.Ui.Controls;

namespace WpfLepo.Demo.ViewModels;

public abstract class ViewModel : ObservableObject, INavigationAware
{
    public virtual async Task OnNavigatedToAsync()
    {
        using CancellationTokenSource cts = new();
        await DispatchAsync(OnNavigatedTo, cts.Token);
    }

    public virtual void OnNavigatedTo() { }

    public virtual async Task OnNavigatedFromAsync()
    {
        using CancellationTokenSource cts = new();
        await DispatchAsync(OnNavigatedFrom, cts.Token);
    }

    public virtual void OnNavigatedFrom() { }

    protected static async Task DispatchAsync(Action action, CancellationToken cancellationToken)
    {
        if (cancellationToken.IsCancellationRequested)
        {
            return;
        }

        await Application.Current.Dispatcher.InvokeAsync(action);
    }
}