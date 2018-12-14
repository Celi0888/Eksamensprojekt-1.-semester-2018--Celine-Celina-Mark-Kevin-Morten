using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FV3.Helpers;
using HelpList.Model;

namespace HelpList.ViewModel
{
    class NewsVM
    {
        private string _title;
        private string _newsContent;
        private DateTime _date;

        public NewsVM(string title, string newsContent)
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

        public RelayCommand AddCommand { get; set; }
        public RelayCommand RemoveCommand { get; set; }

        #region For Singleton

        private ObservableCollection<News> _newsCollection;

        public void AddNews()
        {
            _newsCollection.Add(new News(Title, NewsContent));
        }

        public void RemoveNews()
        {
        }

        #endregion

    }
}
