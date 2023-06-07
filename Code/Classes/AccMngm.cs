using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows;
using Newtonsoft.Json;
using Nito.AsyncEx.Synchronous;
using Project_C14.Code.Structs;

namespace Project_C14.Code.Classes;

public static class AccMngm
{
    public static bool RegisterWasSuccessfull;
    
    public static User CurrentUser = new User();

    public static void Login()
    {
        var task = CheckLogin();
        task.Wait();
    }

    public static void Register()
    {
        var task = TryRegister();
        task.Wait();
    }

    public static void Logout()
    {
        CurrentUser = new User();
    }

    public static IPAddress GetIp()
    {
        WebClient client = new WebClient();
        return IPAddress.Parse(client.DownloadString("https://api.ipify.org"));
    }

    private static async Task CheckLogin()
    {
        try
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://c14.nonamerestall.ch/api.php/");

            HttpResponseMessage response = client.GetAsync(
                $"user/login?username={CurrentUser.Username}&password={CurrentUser.Password}").Result;

            if (response.IsSuccessStatusCode)
            {
                var contents = await response.Content.ReadAsStringAsync();
                contents = contents.Trim(new Char[] { '[', ']' });
                if (contents == "")
                {
                    MessageBox.Show(
                        "Fehler bei der Anmeldung. Überprüfen Sie Ihr Passwort und versuchen Sie es erneut.");
                    return;
                }

                CurrentUser = JsonConvert.DeserializeObject<User>(contents);
                CurrentUser.LoggedIn = true;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                "Konnte Login-Daten nicht überprüfen. Bitte überprüfen Sie Ihre Internetverbindung und versuchen Sie es erneut.");
        }
    }

    public static async Task TryRegister()
    {
        try
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://c14.nonamerestall.ch/api.php/");

            HttpResponseMessage response = client.PutAsync(
                $"user/register?username={CurrentUser.Username}&password={CurrentUser.Password}&creationIp={CurrentUser.CurrentIp}", null).Result;

            if (response.IsSuccessStatusCode)
            {
                CurrentUser.LoggedIn = true;
                MessageBox.Show("Ihr Benutzeraccount wurde erfolgreich erstellt.");
                RegisterWasSuccessfull = true;
                return;
            }

            MessageBox.Show("Dieser Benutzername existiert bereits!");
            Logout();
            RegisterWasSuccessfull = false;
        }
        catch (Exception ex)
        {
            RegisterWasSuccessfull = false;
            MessageBox.Show(
                "Konnte Registrierung nicht abschliessen. Bitte überprüfen Sie Ihre Internetverbindung und versuchen Sie es erneut.");
        }
    }
}
