﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratory_2_v3
{
    internal class Student
    {

        private string lastName;
        private string firstName;
        private string middleName;
        private string suffix;


        public string LastName
        {
            get => lastName;
            set 
            {
                IsNotNullOrWhiteSpace(value, "lastName");
                lastName = value;
            }
        }

        public string FirstName
        {
            get => firstName;
            set
            {
                IsNotNullOrWhiteSpace(value, "first name");
                firstName = value;
            } 
        }

        public string MiddleName
        {
            get => middleName;
            set
            {
                IsNotNullOrWhiteSpace(value, "middle name");
                middleName = value;
            }
        }

        public string Suffix
        {
            get => suffix;
            set
            {
                bool isEmpty = String.IsNullOrWhiteSpace(value);
                suffix = isEmpty ? "" : value;
            }
        }

        public string FullName
        {
            get
            {
                string middleInitial = middleName[..1];
                return $"{lastName}, {firstName} {middleInitial}. {suffix}";
            }
        }
        public bool Equals(Student newInput)
        {
            if (newInput.firstName ==
            firstName && newInput.lastName == lastName && newInput.middleName ==
            middleName && newInput.suffix == suffix)
            {
                return true;
            }

            return false;
        }
        public void CheckUniqueness(Student newInput)
        {
            if (newInput.firstName ==
            firstName && newInput.lastName == lastName && newInput.middleName ==
            middleName && newInput.suffix == suffix)
            {
                Console.WriteLine("\n!!! ERROR: STUDENT ALREADY EXISTS !!!\n");
                throw new Exception("");
            }
        }

        public void IsNotNullOrWhiteSpace(string value, string inputField)
        {
            if (String.IsNullOrWhiteSpace(value))
            {
                Console.WriteLine($"\n!!! ERROR: {inputField.ToUpper()} IS EMPTY !!!\n");
                throw new Exception("");
            }
        }

    }
}
