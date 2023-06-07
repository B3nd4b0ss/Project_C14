using System.Collections.Generic;
using System.Windows.Controls;
using Project_C14.Pages.AccountSubPages;

namespace Project_C14.Pages;

public partial class Account : Page
{
    private static List<Account> _accounts = new List<Account>();

    public Account()
    {
        InitializeComponent();

        InitializePage();

        _accounts.Add(this);
    }

    public void InitializePage()
    {
        if (Code.Classes.AccMngm.CurrentUser.LoggedIn)
        {
            AccountFrame.Content = new AccountManageFace();
        }
        else
        {
            AccountFrame.Content = new LoginFace();
        }
    }

    public static void UpdateFrame()
    {
        _accounts[0].InitializePage();
    }
}