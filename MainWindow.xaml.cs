using System;
using System.Threading;
using MahApps.Metro.IconPacks;
using Project_C14.UserControls;
using System.Windows;
using System.Windows.Input;
using Project_C14.Pages;
using Project_C14.Pages.AccountSubPages;


namespace Project_C14
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Code.Classes.Data.Initialize();
            MainFrame.Source = new Uri("Pages/Main.xaml", UriKind.Relative);
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }
        

        private void OnClick_Power(object sender, RoutedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void OnClick_Home(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new Main();
        }
        

        private void OnClick_Download(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new Download();
        }

        private void OnClick_Library(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new Library();
        }
        
        

        private void Erweiterung_OnClick(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new Erweiterung();
        }
        

        private void Account_Click(object sender, RoutedEventArgs e)
        {
            AccountFrame.Content = new LoginFace();
        }

        private void Settings_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new Settings();
        }
    }
}
