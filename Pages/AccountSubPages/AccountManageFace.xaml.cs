using System.Windows.Controls;
using Project_C14.Code.Classes;

namespace Project_C14.Pages.AccountSubPages;

public partial class AccountManageFace : Page
{
    public AccountManageFace()
    {
        InitializeComponent();
    }

    private void PullProbes_Click(object sender, System.Windows.RoutedEventArgs e)
    {
        Data.PullProbes();
    }

    private void PushProbes_Click(object sender, System.Windows.RoutedEventArgs e)
    {
        Data.PushProbes();
    }

    private void Logout_Click(object sender, System.Windows.RoutedEventArgs e)
    {
        AccMngm.Logout();
    }
}