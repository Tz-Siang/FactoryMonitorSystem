﻿using CommunityToolkit.Mvvm.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FactoryMonitorSystem
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        //public MainWindow(MainVM mainVM)
        public MainWindow()
        {
            InitializeComponent();

            //if (mainVM == Ioc.Default.GetService<MainVM>())

            //DataContext = mainVM;
            DataContext = Ioc.Default.GetService<MainVM>();
        }
    }
}
