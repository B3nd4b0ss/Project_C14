using System.Windows.Controls;
using Project_C14.Pages.AccountSubPages;

namespace Project_C14.Pages;

public partial class Account : Page
{
    private bool _isLoggedIn = false; // TODO maybe autologin at start
    public Account()
    {
        InitializeComponent();
        
        if (_isLoggedIn)
        {
            AccountFrame.Content = new AccountManageFace();
        }
        else
        {
            AccountFrame.Content = new LoginFace();
        }
    }
}