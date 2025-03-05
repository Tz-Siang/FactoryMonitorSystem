using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMonitorSystem
{
    public class MainVM : ObservableObject
    {
        private object _activePage = null;
        public object ActivePage { get => _activePage; set => SetProperty(ref _activePage, value); }
        public MainVM()
        {
            ActivePage = Ioc.Default.GetService<PageMonitor>();
        }
    }
}
