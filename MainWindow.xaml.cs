using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Project_C14.Properties;
using MahApps.Metro.IconPacks;
using Project_C14.UserControls;
using System.Windows;
using System.Windows.Input;
using Project_C14.Pages;
using Project_C14.Pages.AccountSubPages;
using Project_C14.Code.Classes;

namespace Project_C14
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static List<MainWindow> _main = new List<MainWindow>();

        public MainWindow()
        {
            InitializeComponent();
            Data.Initialize();
            Data.LoadProbes();
            MainFrame.Source = new Uri("Pages/Main.xaml", UriKind.Relative);
            _main.Add(this);
        }

        public static void UpdateTo(string PageType)
        {
            _main[0].UpdateFrame(PageType);
        }

        public void UpdateFrame(string PageType)
        {
            switch (PageType)
            {
                case "Erweiterung":
                    MainFrame.Content = new Erweiterung();
                    break;
                
                default:
                    MainFrame.Content = new Main();
                    break;
            }
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
            Data.SaveProbe();
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
            MainFrame.Content = new Account();
        }

        private void Settings_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new Settings();
        }
    }
}
