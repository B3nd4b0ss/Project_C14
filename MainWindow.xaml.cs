using MahApps.Metro.IconPacks;
using Project_C14.UserControls;
using System.Windows;
using System.Windows.Input;


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
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void InfoCard_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Menubutton_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void OnClick_Power(object sender, RoutedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void OnClick_Home(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void OnClick_Account(object sender, RoutedEventArgs e)
        {

        }

        private void OnClick_Settings(object sender, RoutedEventArgs e)
        {

        }

        private void OnClick_Download(object sender, RoutedEventArgs e)
        {

        }

        private void OnClick_Library(object sender, RoutedEventArgs e)
        {

        }

        private void InfoCard_Loaded_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_UngefährBerechnen(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_GenauBerechnen(object sender, RoutedEventArgs e)
        {

        }
    }
}
