using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
// Internal class that manages students and their registration
{
    internal class StudentManagementSystem
    {
        private List<Student> students;

        // Constructor to initialize students list
        public StudentManagementSystem()
        {
            students = new List<Student>();
        }

        public void Run()
        {
            while (true)
            {
                Console.WriteLine(" Welcome to our student system");
                Console.Write("enter the service you want,press 1 f0r service 1 ,2 for service 2 or 3 to exit ");

                Console.WriteLine("1. Register a Student");
                Console.WriteLine("2. Display All Students");
                Console.WriteLine("3. Exit");

                // Get user input and execute corresponding method
                int choice;
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        default:
                            Console.WriteLine("enter the service you want,press 1 f0r service 1 ,2 for service 2 or 3 to exit ");
                            break;
                        case 1:
                            RegisterStudent();
                            break;
                        case 2:
                            DisplayAllStudents();
                            break;
                        case 3:
                            Environment.Exit(0);
                            break;
                        
                    }
                }
                else
                {
                    Console.WriteLine("service not avvailable.");
                }

                Console.WriteLine();
            }
        }
        //method to register new student
        private void RegisterStudent()
        // Get input from user and create new student object
        {
            Console.WriteLine("Register Student");
            Console.Write("Student ID: ");
            int studentID = int.Parse(Console.ReadLine());

            Console.Write("Student Name: ");
            string studentName = Console.ReadLine();

            Console.Write("Surname: ");
            string surname = Console.ReadLine();

            Console.Write("Gender: ");
            string gender = Console.ReadLine();

            Console.Write("Email address: ");
            string email = Console.ReadLine();

            Console.Write("Date of Birth (yyyy-mm-dd): ");
            DateTime dob = DateTime.Parse(Console.ReadLine());

            Console.Write("Phone Number: ");
            string phoneNumber = Console.ReadLine();

            Console.Write(" Which qualification do you want, Degree or Diploma: ");
            string qualification = Console.ReadLine();

            Student student = new Student(studentID, studentName, surname, gender, email, dob, phoneNumber, qualification);
            Console.WriteLine($"Discount: R{student.Discount}");

            students.Add(student);
            Console.WriteLine("Student registered successfully!");
        }
        //method to display registered students//
        private void DisplayAllStudents()
        {
            Console.WriteLine("Registered Students ");
            if (students.Count == 0)
            {
                Console.WriteLine(" 0 students registered .");
            }
            else
            {
                foreach (var student in students)
                {
                    Console.WriteLine($"Student ID: {student.StudentID}");
                    Console.WriteLine($"Name: {student.StudentName} {student.Surname}");
                    Console.WriteLine($"Gender: {student.Gender}");
                    Console.WriteLine($"Email: {student.Email}");
                    Console.WriteLine($"Date of Birth: {student.DOB:yyyy-MM-dd}");
                    Console.WriteLine($"Phone Number: {student.PhoneNumber}");
                    Console.WriteLine($"Qualification: {student.Qualification}");
                    Console.WriteLine($"Discount: R{student.Discount}");
                    Console.WriteLine("------------------------------------");
                }

            }

        }
    }
}
