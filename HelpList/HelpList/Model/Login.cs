using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpList.Model
{
    class Login : User
    {// instant fields
        private string _mail;
        private string _password;

        // properties med observablecollection for teacher, student og admin
        public StudentCollection LoginSC { get; set; }
        public AdminCollection LoginAC { get; set; }
        public TeacherCollection LoginTC { get; set; }

        // constructor
        public Login(string firstName, string lastName, string password, string mail) : base(firstName, lastName,
            password, mail)
        {
            _mail = mail;
            _password = password;
            LoginSC = new StudentCollection();

        }


        // Login til studerende
        public void LoginStudent()
        {
            // lav en foreach med collector i SC (Student Collection)
            foreach (var sc in LoginSC.SC)
            {
                // lav en if statement der tjekker på om brugernavnet eksistere i Student Collection
                if (Mail.Equals(LoginSC.Mail) && PassWord.Equals(LoginSC.Password))
                {
                    // gå til HomePageStudent
                    ((Frame)Window.Current.Content).Navigate(typeof(HomePageStudent));
                }
            }
        }

        // Login til Teacher
        public void LoginTeacher()
        {
            //lav en foreach med collector i SC(Teacher Collection)
            foreach (var tc in LoginTC.TC)
            {
                // lav en if statement der tjekker på om brugernavnet eksistere i Teacher Collection
                if (Mail.Equals(LoginTC.Mail) && PassWord.Equals(LoginTC.Password))
                {
                    // gå til HomePageTeacher
                    ((Frame)Window.Current.Content).Navigate(typeof(HomePageTeacher));

                }
            }
        }

        // Login til Admin
        public void LoginAdmin()
        {
            // lav en foreach med collector i AS (Admin Collection)
            foreach (var ac in LoginAC.AC)
            {
                // lav en if statement der tjekker på om brugernavnet eksistere i Admin Collection
                if (Mail.Equals(LoginAC.Mail) && PassWord.Equals(LoginAC.Password))
                {
                    // gå til HomePageAdmin
                    ((Frame)Window.Current.Content).Navigate(typeof(HomePageAdmin));

                }
            }
        }

    }
}
