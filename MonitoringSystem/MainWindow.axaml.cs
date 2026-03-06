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
            processesList.ItemsSource = Process.GetProcesses()
                                        .OrderBy(p => p.ProcessName)
                                        .ToList();
        }

        private void GetProcesses_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            var selectedItem = processesList.SelectedItem as Process;

            if (selectedItem != null)
            {
                try
                {
                    selectedItem.Kill();
                    processesList.ItemsSource = Process.GetProcesses()
                                        .OrderBy(p => p.ProcessName)
                                        .ToList();
                }
                catch (System.Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
            }
        }
    }
}