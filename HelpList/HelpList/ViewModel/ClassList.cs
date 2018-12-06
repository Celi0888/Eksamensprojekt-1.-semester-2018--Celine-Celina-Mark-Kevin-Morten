using HelpList.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace HelpList.ViewModel
{
    class ClassList : INotifyPropertyChanged
    {
        //instance fields
        private string _className;
        private string _classRoom;


        private StudentClass _selectedClass;
        private StudentClass _newClass;


        //Properties
        public string ClassName
        {
            get { return _className; }
            set
            {
                _className = value;
                OnPropertyChanged();
            }
        }
        public string ClassRoom
        {
            get { return _classRoom; }
            set
            {
                _classRoom = value;
                OnPropertyChanged();
            }
        }

        public StudentClass SelectedClass
        {
            get { return _selectedClass; }
            set
            {
                _selectedClass = value;
                OnPropertyChanged();
            }
        }
        public StudentClass NewClass
        {
            get { return _newClass; }
            set
            {
                _newClass = value;
                OnPropertyChanged();
            }
        }

        //create a collection for users.
        public ObservableCollection<StudentClass> ClassCollection { get; set; }

        //constructor
        public ClassList()
        {
            ClassCollection = new ObservableCollection<StudentClass>();
            ClassCollection.Add(new StudentClass("1a", "Room 1"));
            ClassCollection.Add(new StudentClass("1b", "Room 2"));
            ClassCollection.Add(new StudentClass("1c", "Room 3"));
        }
        //methods
        public void AddClass()
        {

        }
        public void DeleteClass()
        {
            if (SelectedClass != null)
            {
                ClassCollection.Remove(SelectedClass);
            }

        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }



    }
}
