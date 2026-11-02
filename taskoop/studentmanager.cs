using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace taskoop
{
    public class Studentmanager
    {
        public List<Student> Students { get; set; } = new List<Student>();
        public List<Course> Courses { get; set; } = new List<Course>();
        public List<Instructor> Instructors { get; set; } = new List<Instructor>();


        public bool Addstudent(Student student)
        {
            if (FindStudent(student.Studentid) == null)
            {
                Students.Add(student);
                return true;
            }
            return false;
        }
        public Student FindStudent(int Studentid)
        {

            foreach (var student in Students)
            {
                if (student.Studentid == Studentid)
                    return student;
            }
            return null;
        }

        public bool Addcourse(Course course)
        {
            if (Findcourse(course.Courseid) == null)
            {
                Courses.Add(course);
                return true;
            }
            return false;

        }
        public Course Findcourse(int courseid)
        {
            foreach(var course in Courses)
            {
                if (course.Courseid == courseid)
                    return course;
            }
            return null;
        }
        public bool Addinstructor( Instructor instructor)
        {
            if(Findinstructor(instructor.instructorid)==null)
            {
                Instructors.Add(instructor);
                return true;
            }
            return false;
        }
        public Instructor Findinstructor(int instructorid)
        {
            foreach( var instructor in Instructors)
            {
                if (instructor.instructorid == instructorid)
                    return instructor;
            }
            return null;
        }

        public bool Enrollstudentincourse(int studentid,int courseid)
        {
            Student Fstudent = FindStudent(studentid);
            Course Fcourse = Findcourse(courseid);
            if(Fstudent !=null && Fcourse != null)
            {
                return Fstudent.Enroll(Fcourse);
            }
            return false;
        }
    }
}
