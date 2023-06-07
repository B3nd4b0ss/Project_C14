using System.Windows;
using System.Windows.Controls;
using Project_C14.Code.Classes;
using Project_C14;

namespace Project_C14.Pages.AccountSubPages;

public partial class LoginFace : Page
{
    public LoginFace()
    {
        InitializeComponent();
    }

    private void ForRegister_Click(object sender, RoutedEventArgs e)
    {
        Account.SetReg();
    }

    private void Login_Click(object sender, RoutedEventArgs e)
    {
        AccMngm.CurrentUser.Username = UsernameBox.Text;
        AccMngm.CurrentUser.Password = Hasher.HashSha512(PasswordBox.Password);

        AccMngm.Login();

        Account.UpdateFrame();
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