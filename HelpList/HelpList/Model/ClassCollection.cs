using FV3.Helpers;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace HelpList.Model
{
    class ClassCollection : INotifyPropertyChanged
    {
        //instance fields
        private string _className;
        private string _classRoom;
        private ObservableCollection<ClassObject> _cc;

        private ClassObject _selectedClass;
        private ClassObject _newClass;


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

        public ClassObject SelectedClass
        {
            get { return _selectedClass; }
            set
            {
                _selectedClass = value;
                OnPropertyChanged();
            }
        }
        public ClassObject NewClass
        {
            get { return _newClass; }
            set
            {
                _newClass = value;
                OnPropertyChanged();
            }
        }

        public RelayCommand AddCommand { get; set; }
        public RelayCommand DeleteCommand { get; set; }


        //create a collection for users.
        public ObservableCollection<ClassObject> CC
        {
            get { return _cc; }
            set
            {
                _cc = value;
                OnPropertyChanged();
            }
        }


        //constructor
        public ClassCollection()
        {
            CC = new ObservableCollection<ClassObject>
            {
                new ClassObject("1a", "Room 1"),
                new ClassObject("1b", "Room 2"),
                new ClassObject("1c", "Room 3")
            };

            _newClass = new ClassObject();

            AddCommand = new RelayCommand(AddClassMethod);
            DeleteCommand = new RelayCommand(DeleteClassMethod);

        }
        //methods
        public void AddClassMethod()
        {
            CC.Add(new ClassObject(_className, _classRoom));
        }
        public void DeleteClassMethod()
        {
            if (SelectedClass != null)
            {
                CC.Remove(SelectedClass);
            }

        }




        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
