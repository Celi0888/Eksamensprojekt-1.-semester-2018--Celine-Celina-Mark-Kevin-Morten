using System;
using System.Linq.Expressions;
using HelpList.View;

namespace HelpList.Model
{
    class Student : User
    {
        //Constructor
        public Student(string firstName, string lastName, string passWord, string mail) : base(firstName, lastName, passWord, mail)
        {

        }
		
	}

}
