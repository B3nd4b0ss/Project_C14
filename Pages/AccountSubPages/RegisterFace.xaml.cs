using System.Windows;
using System.Windows.Controls;

namespace Project_C14.Pages.AccountSubPages;

public partial class RegisterFace : Page
{
    public RegisterFace()
    {
        InitializeComponent();
    }

    private void ForLogin_Click(object sender, System.Windows.RoutedEventArgs e)
    {

    }

    private void Register_Click(object sender, System.Windows.RoutedEventArgs e)
    {

    }

    private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
    {
        if (PasswordBox.Password.Length > 0)
        {
            TTPTextBlock.Visibility = Visibility.Collapsed;
        }
        else
        {
            TTPTextBlock.Visibility = Visibility.Visible;
        }
    }
}