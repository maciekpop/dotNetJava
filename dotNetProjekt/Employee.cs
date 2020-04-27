using System;
using System.Collections.Generic;
using System.Text;

namespace dotNetProjekt
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public int PhoneNumber { get; set; }

        public string Email { get; set; }

        public string Position { get; set; }

        public override string ToString()
        {
            return $"{EmployeeId} {FirstName} {LastName} {Address} {PhoneNumber} {Email} {Position}";
        }

    }
}
