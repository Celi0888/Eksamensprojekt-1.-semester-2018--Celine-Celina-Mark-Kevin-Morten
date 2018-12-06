using System;
using System.Linq.Expressions;

namespace HelpList.Model
{
    class Student : User
    {
        //Constructor
        public Student(string firstName, string lastName, string passWord, string mail) : base(firstName, lastName, passWord, mail)
        {

        }
        public Student()
        {

        }

	    public void StudentLogin()
	    {
			
	    }
	}

}
