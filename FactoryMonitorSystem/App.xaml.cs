using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using CommunityToolkit.Mvvm.DependencyInjection;
using MaterialDesignThemes.Wpf;
using Microsoft.Extensions.DependencyInjection;

namespace FactoryMonitorSystem
{
    /// <summary>
    /// App.xaml 的互動邏輯
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            Ioc.Default.ConfigureServices(
                new ServiceCollection()
                .AddSingleton<MainVM>()
                .AddSingleton<MainWindow>()
                .AddSingleton<PageMonitor>()
                .BuildServiceProvider());

            // 顯示主視窗
            Ioc.Default.GetService<MainWindow>().Show();
        }
    }
}
