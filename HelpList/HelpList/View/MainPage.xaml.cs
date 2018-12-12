using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using HelpList.View;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace HelpList
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class MainPage : Page
	{
		public MainPage()
		{
			this.InitializeComponent();
		}
		// Login til studerende
		private void LoginStudent_Click(object o)
		{
			string textBoxMail = TextBox_Email.Text;
			string textBoxPassword = TextBox_Code.Text;
			if ((textBoxMail.Contains("student")) && (textBoxPassword.Contains("student")))
			{
				this.Frame.Navigate(typeof(HomePageStudent));
			}
		}

		// Login til studerende
		private void LoginTeacher_Click(object o)
		{
			//string textBoxMail = TextBox_Email.Text;
			//string textBoxPassword = TextBox_Code.Text;
			//if ((textBoxMail.Text == "Teacher") && (textBoxPassword.Text == "teacher"))
			//{
			//	this.Frame.Navigate(typeof(HomePageStudent));
			//}
		}

		// Login til studerende
		private void LoginAdmin_Click(object o)
		{
			//string textBoxMail = TextBox_Email.Text;
			//string textBoxPassword = TextBox_Code.Text;
			//if ((textBoxMail.Text == "Admin") && (textBoxPassword.Text == "admin"))
			//{
			//	this.Frame.Navigate(typeof(HomePageStudent));
			//}
		}
	}
}
