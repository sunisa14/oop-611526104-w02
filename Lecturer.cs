using System;
using System.Collections.Generic;
using System.Text;

namespace oop_6115261014_w02
{
    class Lecturer
    {
        private string lecturerName;
        private string lecturerSurname;
        private string lecturerPosition;

        public string LecturerName
        {
            get { return lecturerName; }
            set { lecturerName = value; }
        }
        public string LecturerSurname
        {
            get { return lecturerSurname; }
            set { lecturerSurname = value; }
        }
        public string LecturerPosition
        {
            get { return lecturerPosition; }
            set { lecturerPosition = value; }
        }


        public Lecturer() { }
        public Lecturer( string rn, string rs, string rp)
        {
            this.lecturerName = rn;
            this.lecturerSurname = rs;
            this.lecturerPosition = rp;
        }

    }
}