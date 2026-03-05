using Avalonia.Controls;
using System;
using System.Diagnostics;
using System.Linq;

namespace MonitoringSystem
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void GetProcesses_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            processesList.ItemsSource = Process.GetProcesses()
                                        .OrderBy(p => p.ProcessName)
                                        .ToList();
        }
    }
}