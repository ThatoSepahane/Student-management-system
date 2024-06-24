﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Student
    {
         
       public int StudentID { get; set; }
        public string StudentName { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public DateTime DOB { get; set; }
        public string PhoneNumber { get; set; }
        public string Qualification { get; set; }
        public decimal Discount { get; set; }

        public Student(int studentID, string studentName, string surname, string gender, string email, DateTime dob, string phoneNumber, string qualification)
        {
            StudentID = studentID;
            StudentName = studentName;
            Surname = surname;
            Gender = gender;
            Email = email;
            DOB = dob;
            PhoneNumber = phoneNumber;
            Qualification = qualification;
            CalculateDiscount();
        }

        private void CalculateDiscount()
            //method to calculate fees and discountts//
        {
            int age = DateTime.Today.Year - DOB.Year;
            decimal baseFee = Qualification == "Degree" ? 85000 : 45000;

            if (age > 25)
            {
                Discount = Gender == "Female" ? baseFee * 0.3m : baseFee * 0.19m;
            }
            else
            {
                Discount = 0;
            }
        }
    }

}

