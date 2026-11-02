using System;
using System.Collections.Generic;
using System.Text;

namespace taskoop
{
    public class Student
    {
      
            public int Studentid { get; set; }
            public string Studentname { get; set; }
            public int Age { get; set; }
            public List<Course> Courses { get; set; }
            public Student(int studentid, string studentname, int age)
            {
                Studentid = studentid;
                Studentname = studentname;
                Age = age;
                Courses = new List<Course>();
            }
            public bool Enroll(Course course)
            {
                if (course != null && !Courses.Contains(course))
                {
                    Courses.Add(course);
                    return true;
                }
                return false;
            }

     
            public string printdetails()
            {
                string courseslist = Courses.Count > 0
                    ? string.Join(", ", Courses.ConvertAll(c => c.Title))
                    : "no courses enrolled";

                return $"id: {Studentid}, Name: {Studentname}, Age: {Age}, Courses: [{courseslist}]";
            }
        }
    }
