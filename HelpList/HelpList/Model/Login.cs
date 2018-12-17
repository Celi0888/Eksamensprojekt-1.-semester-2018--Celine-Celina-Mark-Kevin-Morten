using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelpList.View;

namespace HelpList.Model
{
	class Login : User
	{
		// instant fields
		private string _mail;
		private string _password;

		// propertis
		public string Mail
		{
			get { return _mail; }
			set { _mail = value; }
		}

		public string Password
		{
			get { return _password; }
			set { _password = value; }
		}

		// constructor
		public Login(string firstName, string lastName, string password, string mail) : base(firstName, lastName,
			password, mail)
		{
			_mail = mail;
			_password = password;
		}


		// Login til studerende
		public void LoginStudent()
		{
			// lav en foreach med collector i SC (Student Collection)
			//foreach (var sc in SC)
			//{
				// lav en if statement der tjekker på om brugernavnet eksistere i Student Collection
			//}
		}

		// Login til studerende
		public void LoginTeacher()
		{
			// lav en foreach med collector i SC (Teacher Collection)
			//foreach (var sc in SC)
			//{
				// lav en if statement der tjekker på om brugernavnet eksistere i Teacher Collection
			//}
		}

		// Login til studerende
		private void LoginAdmin()
		{
			// lav en foreach med collector i AS (Admin Collection)
			//foreach (var sc in AC)
			//{
				// lav en if statement der tjekker på om brugernavnet eksistere i Admin Collection
			//}
		}
	}
}
