using System.Collections.Generic;
using System.Windows.Controls;
using Project_C14.Pages.AccountSubPages;

namespace Project_C14.Pages;

public partial class Account : Page
{
    private static Account _account = new();

    public Account()
    {
        InitializeComponent();

        InitializePage();

        _account = this;
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
        _account.InitializePage();
    }

    public static void SetReg()
    {
        _account.SetRegister();
    }

    public static void SetLog()
    {
        _account.SetLogin();
    }

    public void SetRegister()
    {
        AccountFrame.Content = new RegisterFace();
    }

    public void SetLogin()
    {
        AccountFrame.Content = new LoginFace();
    }
}