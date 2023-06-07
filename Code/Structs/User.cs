using Project_C14.Code.Structs;
using System.Collections.Generic;
using System.Net;

namespace Project_C14.Code.Structs;

public struct User
{
	public string Username { get; set; }

	public List<Probe> UserProbes { get; set; }

	public string Password { get; set; }

	public IPAddress CurrentIp { get; set; }

	public bool LoggedIn { get; set; }
}