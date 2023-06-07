using System.Windows;
using System.Windows.Controls;
using Project_C14.Code.Classes;

namespace Project_C14.Pages.AccountSubPages;

public partial class RegisterFace : Page
{
    public RegisterFace()
    {
        InitializeComponent();
    }

    private void ForLogin_Click(object sender, System.Windows.RoutedEventArgs e)
    {
        Account.SetLog();
    }

    private void Register_Click(object sender, System.Windows.RoutedEventArgs e)
    {
        if (PasswordBox.Password.Length >= 5 && UsernameBox.Text.Length >= 5)
        {
            AccMngm.CurrentUser.Username = UsernameBox.Text;
            AccMngm.CurrentUser.Password = Hasher.HashSha512(PasswordBox.Password);
            AccMngm.CurrentUser.CurrentIp = AccMngm.GetIp();
            
            AccMngm.Register();
            if (AccMngm.RegisterWasSuccessfull)
                Account.UpdateFrame();
            else
                Account.SetReg();
        }
        else
        {
            MessageBox.Show(
                "Bitte wählen Sie einen Benutzernamen und ein Passwort welche beide mindestens fünf Zeichen beinhalten.");
        }
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