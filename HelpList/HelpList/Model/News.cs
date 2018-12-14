using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpList.Model
{
    class News
    {
        private string _title;
        private string _newsContent;
        private DateTime _date;

        public News(string title, string newsContent)
        {
            _title = title;
            _newsContent = newsContent;
            _date = DateTime.Now;
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public string NewsContent
        {
            get { return _newsContent; }
            set { _newsContent = value; }
        }

        public DateTime Date
        {
            get { return _date; }
        }
    }
}
