using System;
using System.Linq;
using System.Threading;
using Project_C14.Properties;
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
            AccountFrame.Content = new Main();
            MainFrame.Content = new Main();
        }


        private void OnClick_Download(object sender, RoutedEventArgs e)
        {
            AccountFrame.Content = new Download();
            MainFrame.Content = new Download();
        }

        private void OnClick_Library(object sender, RoutedEventArgs e)
        {
            AccountFrame.Content = new Library();
            MainFrame.Content = new Library();
        }



        private void Erweiterung_OnClick(object sender, RoutedEventArgs e)
        {
            AccountFrame.Content = new Erweiterung();
            MainFrame.Content = new Erweiterung();
        }


        private void Account_Click(object sender, RoutedEventArgs e)
        {
            AccountFrame.Content = new Account();
            MainFrame.Content = new Account();
        }

        private void Settings_Click(object sender, RoutedEventArgs e)
        {
            AccountFrame.Content = new Settings();
            MainFrame.Content = new Settings();
        }
    }
}
