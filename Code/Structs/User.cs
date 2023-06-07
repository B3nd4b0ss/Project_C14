using System;

namespace NNR_3.Structs
{
	public struct User
	{
		private string _username;
		private string _name;
		private string _userID;
		private string _randomID;
        private string _password;
		private bool _isLoggedIn;

        public string Username
		{
			get { return _username; }
			set { _username = value; }
		}

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		public string UserID
		{
			get { return _userID; }
			set { _userID = value; }
		}

		public string RandomID
		{
			get { return _randomID; }
			set { _randomID = value; }
		}

		public string Password
		{
			get { return _password; }
			set { _password = value; }
		}

		public bool LoggedIn
		{
			get { return _isLoggedIn; }
			set { _isLoggedIn = value; }
		}
	}
}

