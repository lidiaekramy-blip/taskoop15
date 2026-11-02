using System;
using System.Collections.Generic;
using System.Text;

namespace taskoop
{
    public class Course
    {
        public int Courseid { get; set; }
        public string Title { get; set; }
       public Instructor Instructor { get; set; }
        public Course (int  courseid, string title, Instructor instructor)

        {
            Courseid = courseid;
            Title = title;
            Instructor = instructor;
        }
        public string Printdetails()
        {
            string instructorname = Instructor != null ? Instructor.instructorname : "no instructor assigned";
            return $"CourseID:{Courseid},Title:{Title},Instructor:{instructorname}";
        }
    }
}
