using System;
using System.Windows;
using System.Windows.Controls;

namespace Project_C14;

public partial class Settings : Page
{
    
    public Settings()
    {
        InitializeComponent();
    }

    public void ThemeToggleButton_Click(object sender, RoutedEventArgs e)
    {
        if (ThemeToggleButton.IsChecked == true)
        {
            // Dark theme is selected
            Application.Current.Resources.MergedDictionaries.Clear();
            Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary() { Source = new Uri("Themes/Dark.xaml", UriKind.Relative) });
        }
        else
        {
            // Light theme is selected
            Application.Current.Resources.MergedDictionaries.Clear();
            Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary() { Source = new Uri("Themes/Light.xaml", UriKind.Relative) });
        }
    }


}