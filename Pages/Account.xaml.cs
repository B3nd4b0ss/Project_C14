using System.Windows.Controls;
using Project_C14.Pages.AccountSubPages;

namespace Project_C14.Pages;

public partial class Account : Page
{
    public Account()
    {
        InitializeComponent();
        
        if (Code.Classes.AccMngm.CurrentUser.LoggedIn)
        {
            AccountFrame.Content = new AccountManageFace();
        }
        else
        {
            AccountFrame.Content = new LoginFace();
        }
    }
}