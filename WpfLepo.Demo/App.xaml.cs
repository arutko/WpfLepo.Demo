using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Windows;
using Wpf.Ui;
using WpfLepo.Demo.Services;
using WpfLepo.Demo.ViewModels;
using WpfLepo.Demo.Views;

namespace WpfLepo.Demo;

public partial class App : Application
{
    protected override void OnStartup(StartupEventArgs e)
    {
        var builder = new HostBuilder()
            .ConfigureAppConfiguration(config =>
            {
                config.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            })
            .ConfigureServices((_, services) =>
            {
                services.AddTransient<MainWindow>();
                services.AddSingleton<MainWindow>();
                services.AddSingleton<MainWindowViewModel>();
                services.AddSingleton<IPageService, PageService>();

                // inject View and ViewModel
                services.AddSingleton<MainWindow>();
                services.AddSingleton<MainWindowViewModel>();
                services.AddSingleton<HomePage>();
                services.AddSingleton<HomePageModel>();
                services.AddSingleton<DesignGuidancePage>();
                services.AddSingleton<DesignGuidancePageModel>();
                services.AddSingleton<SettingsPage>();
                services.AddSingleton<SettingsPageModel>();
                services.AddSingleton<AllSamplesPage>();
                services.AddSingleton<AllSamplesViewModel>();
            });

        var host = builder.Build();

        using var scope = host.Services.CreateScope();

        var services = scope.ServiceProvider;

        try
        {
            var frm = services.GetRequiredService<MainWindow>();
            frm.Show();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occured: {ex.Message}");
        }
    }
}
