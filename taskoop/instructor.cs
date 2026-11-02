using System;
using System.Collections.Generic;
using System.Text;

namespace taskoop
{
    public class Instructor
    {
        public int instructorid { get; set; }
        public string instructorname { get; set; }
        public string specialization { get; set; }

        public Instructor (int  Instructorid,string Instrucotname, String Specialization)
        {
            instructorid = Instructorid;
            instructorname = Instrucotname;
            specialization = Specialization;
        }
        public string Printdetails()
        {
            return $"ID: {instructorid},Name:{instructorname},Specialization:{specialization}";
        }
    }
}
