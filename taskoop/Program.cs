using System.ComponentModel.Design;

namespace taskoop
{
     class Program
    {
        static void Main(string[] args)
        {
            Studentmanager manager = new Studentmanager();
            bool working = true;
            while (working)
            {
                Console.WriteLine("---  Choose an option --- ");
                Console.WriteLine("1:add student");
                Console.WriteLine("2: view all students");
                Console.WriteLine("3: search for student by ID ");
                Console.WriteLine("4: add new course");
                Console.WriteLine("5: add new instructor");
                Console.WriteLine("6: enroll a student in course");
                Console.WriteLine("7: view all courses ");
                Console.WriteLine("8: view all instructors");
                Console.WriteLine("9: find course by ID ");
                Console.WriteLine("10: Check if the student enrolled in specific course ");
                Console.WriteLine("11: Return the instructor name by course name");
                Console.WriteLine("12: Exit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        {
                            Console.WriteLine("Enter student Name:");
                                string sName = Console.ReadLine();
                            Console.WriteLine("Enter student ID :");
                            int sId = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter student Age:"); 
                            int sAge = int.Parse(Console.ReadLine());
                            if (manager.Addstudent(new Student(sId, sName, sAge)))
                            {
                                Console.WriteLine("student added successfully");
                            }
                            else
                                Console.WriteLine("student already exist");
                            break;

                        }

                    case "2":
                        {
                            Console.WriteLine("All studentss:");
                            foreach (Student student in manager.Students)
                            {
                                Console.WriteLine(student.printdetails());

                            }
                            break;
                        }
                        case "3":
                        {
                            Console.WriteLine("Enter student id to search for:");
                            int ID = int.Parse(Console.ReadLine());

                            Student findstudent = manager.FindStudent(ID);
                            if (findstudent != null)
                            {

                                Console.WriteLine("student exist :" + findstudent.printdetails());
                            }
                            else
                                Console.WriteLine("Student does not exist");


                            break;
                        }
                    case "4":
                        {
                            Console.WriteLine("Enter course name");
                            string cName= Console.ReadLine();
                            Console.WriteLine("Enter course id ");
                            int cId = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter course's instructor's Id");
                            int cInstId= int.Parse(Console.ReadLine());
                            Instructor inst = manager.Findinstructor(cInstId);

                            if (inst != null)
                            {
                                if (manager.Addcourse(new Course(cId, cName,inst )))
                                {
                                    Console.WriteLine("Course added successfully");

                                }
                                else
                                    Console.WriteLine("Course name already exist");
                            }
                            else
                                Console.WriteLine("Instructor not found");
                            break;
                        }
                    case "5":
                        {
                            Console.WriteLine("Enter instructor's name");
                            string iName = Console.ReadLine();
                            Console.WriteLine("Enter instructor's ID");
                            int iID = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter instructor's Specialization");
                            string iSPecialization = Console.ReadLine();

                            if(manager.Addinstructor(new Instructor(iID, iName, iSPecialization)))
                            { 
                                Console.WriteLine("instructor added successfully");
                            }
                            else
                                Console.WriteLine(" this instructor already exist");
                             

                            break;
                        }

                    case "6":
                        {
                            Console.WriteLine("Enter student Id");
                            int sID = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter course Id");
                            int cID = int.Parse(Console.ReadLine());
                            if (manager.Enrollstudentincourse(sID, cID))
                            {

                                Console.WriteLine("Student enrolled successfully");
                            }
                            else
                                Console.WriteLine("something is null or already enrolled");

                            break;
                        }
                    case "7":
                        {
                            Console.WriteLine("All courses :");
                            foreach(Course course in manager.Courses)
                            {
                                Console.WriteLine(course.Printdetails);
                            }
                               

                            break;
                        }
                    case "8":
                        {
                            Console.WriteLine("All instructors");
                            foreach(Instructor inst in manager.Instructors)
                            {
                                Console.WriteLine(inst.Printdetails);
                            }
                            break;
                        }
                    case "9":
                        {
                            Console.WriteLine("Enter Course ID");
                            int cID =int.Parse(Console.ReadLine());
                            Course findcourse = manager.Findcourse(cID);
                            if (findcourse != null)
                            {
                                Console.WriteLine(findcourse.Printdetails());
                            }

                            break;
                        }
                    case "10":
                        {
                            Console.WriteLine("Enter student Id");
                            int sID =int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter course Id");
                            int cID=int.Parse(Console.ReadLine());
                            Student student= manager.FindStudent(sID);
                            Course course=manager.Findcourse(cID);
                            if (student != null && course != null)
                            {
                                if(student.Enroll(course)==false)
                                {
                                    Console.WriteLine("YES student is enrolled in this course");
                                }
                                else
                                {
                                    Console.WriteLine("NO student is not Enrolled in this course");
                                    student.Courses.Remove(course);
                                }

                            }
                            else
                                Console.WriteLine("Student or Course not found");

                            break;
                        }
                    case "11":
                        {
                            Console.WriteLine("Enter course name");
                            string cName=Console.ReadLine();

                            bool findcourse = false;
                            foreach (Course c in manager.Courses)
                            {
                                if (c.Title == cName)
                                {
                                    findcourse = true;
                                    if (c.Instructor != null)
                                    {
                                        Console.WriteLine("Instructor:" + c.Instructor.instructorname);
                                    }
                                    else
                                        Console.WriteLine("No instructor assigned");

                                    break;
                                }
                            }

                            if (!findcourse)
                            {
                                Console.WriteLine("course not found");
                            }

                            break;
                        }

                    case "12":
                        {
                            working = false;

                            break;
                        }

                    default:
                        Console.WriteLine("Invalid choice. try again");
                        break;
                }


            }




        }
    }
}
