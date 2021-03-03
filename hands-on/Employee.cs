using System;
using System.Collections.Generic;
using System.Text;

namespace Oop//pascal case
{
    class Employee
    { //Fields
        private int id; //camel case
        private string firstname;
        private string designation;
        private string gender;
        private string email;
        public string FirstName { get; set; }
        // above Firstname is same as below First name
        //public string FirstName
        //{
        //    get => firstname; set => firstname = value;
        //}
        // public int Id
        //{
        //     get { return Id; }
        //     set { id = value; }   
        // }
        // above ID is same as below ID

        // auto implemented properties
        public string LastName { get; set; }
        public int Id { get; set; }
        public string Designation { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }

        //constructor
        public Employee(int id, string firstname, string lastname, string designation, string gender, string email)
        {
            Id = id;
            FirstName = firstname;
            LastName = lastname;
            Designation = designation;
            Gender = gender;
            Email = email;
        
        }
        //methods
        public void Display() //pascal case
        {
            Console.Write("Enter employee info");
            Console.WriteLine("Employee info is :"+FirstName +"\n"+ LastName + "\n" + Designation + "\n" + Gender + "\n" + Email);
           


        }
        public int CalculateSalary()
        { 
        return 0;
        }
        public void SwipeIn()
        { 
        
        
        }


    }
}
