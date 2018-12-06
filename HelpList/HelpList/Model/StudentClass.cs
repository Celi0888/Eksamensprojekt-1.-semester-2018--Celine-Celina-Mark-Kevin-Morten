namespace HelpList.Model
{
    class StudentClass
    {
        //Instance fields
        private string _className;
        private string _classRoom;

        //Properties
        public string ClassName { get; set; }
        public string ClassRoom { get; set; }

        //Constructor
        public StudentClass(string className, string classRoom)
        {
            _className = className;
            _classRoom = classRoom;
		}

    }
}
