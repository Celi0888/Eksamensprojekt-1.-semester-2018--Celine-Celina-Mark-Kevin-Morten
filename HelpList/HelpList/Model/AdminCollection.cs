using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FV3.Helpers;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace HelpList.Model
{
	class AdminCollection : INotifyPropertyChanged
	{
		//instance fields
		private string _firstName;
		private string _lastName;
		private string _password;
		private string _mail;
		private ObservableCollection<Admin> _ac;

		private Admin _selectedAdmin;
		private Admin _newAdmin;

		//Properties
		public string FirstName
		{
			get { return _firstName; }
			set
			{
				_firstName = value;
				OnPropertyChanged();
			}
		}

		public string LastName
		{
			get { return _lastName; }
			set
			{
				_lastName = value;
				OnPropertyChanged();
			}
		}

		public string Mail
		{
			get { return _mail; }
			set
			{
				_mail = value;
				OnPropertyChanged();
			}
		}

		public string Password
		{
			get { return _password; }
			set
			{
				_password = value;
				OnPropertyChanged();
			}
		}

		public Admin SelectedAdmin
		{
			get { return _selectedAdmin; }
			set
			{
				_selectedAdmin = value;
				OnPropertyChanged();
			}
		}

		public Admin NewAdmin
		{
			get { return _newAdmin; }
			set
			{
				_newAdmin = value;
				OnPropertyChanged();
			}
		}

		public RelayCommand AddCommand { get; set; }
		public RelayCommand DeleteCommand { get; set; }

		//create a collection for Students.
		public ObservableCollection<Admin> AC
		{
			get { return _ac; }
			set
			{
				_ac = value;
				OnPropertyChanged();
			}
		}

		// construktor
		public AdminCollection()
		{
			AC = new ObservableCollection<Admin>
			{
				new Admin("Kirsten", "Svendsen", "adminpass", "admin@gmail.com")

			};
			AddCommand = new RelayCommand(AddAdminMethod);
			DeleteCommand = new RelayCommand(DeleteAdminMethod);
		}

		//methods
		public void AddAdminMethod()
		{
			AC.Add(new Admin(_firstName, _lastName, _password, _mail));
		}

		public void DeleteAdminMethod()
		{
			if (SelectedAdmin != null)
			{
				AC.Remove(SelectedAdmin);
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
