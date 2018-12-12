using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpList.Model
{
    class Login
    {
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
