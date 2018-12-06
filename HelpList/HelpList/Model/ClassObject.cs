﻿namespace HelpList.Model
{
    class ClassObject
    {
        //Instance fields
        private string _className;
        private string _classRoom;

        //Properties
        public string ClassName
        {
            get { return _className; }
            set { _className = value; }
        }
        public string ClassRoom
        {
            get { return _classRoom; }
            set { _classRoom = value; }
        }

        //Constructor
        public ClassObject(string className, string classRoom)
        {
            _className = className;
            _classRoom = classRoom;
        }
        public ClassObject()
        {

        }
        public override string ToString()
        {
            return $"{nameof(ClassName)}: {ClassName}, {nameof(ClassRoom)}: {ClassRoom}";
        }

    }
}
