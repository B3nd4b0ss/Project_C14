using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Nito.AsyncEx.Synchronous;
using NNR_3.Structs;

namespace Project_C14.Code.Classes;

public class AccMngm
{
    public static User CurrentUser = new User();

    public static void Login()
    {
        var task = CheckLogin();
        task.Wait();
    }

    public static void Logout()
    {
        CurrentUser = new User();
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
                    return;
                }

                CurrentUser = JsonConvert.DeserializeObject<User>(contents);
                CurrentUser.LoggedIn = true;
            }
        }
        catch (Exception ex)
        {
            return;
        }
    }
}
