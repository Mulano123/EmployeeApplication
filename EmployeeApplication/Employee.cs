using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeNamespaces
{
    public class Employee
    {
        private int employeeID;
        private string firstName;
        private string lastName;
        private string employeePosition;

        public Employee()
        {
            this.employeeID = 0;
            this.firstName = "no first name";
            this.lastName = "no last name ";
            this.employeePosition = "no position";
        }

        public Employee(int newID, string newfName, string newlName, string newPosition)
        {
            this.employeeID = newID;
            this.firstName = newfName;
            this.lastName = newlName;
            this.employeePosition = newPosition;
        }


        public int EmpID
        {
            get { return employeeID; }
            set { employeeID = value; }
        }

        public string EmployeeFirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string EmployeeLastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        
        public string Position
        { 
            get { return employeePosition; }
            set { employeePosition = value; }
        }

    }
}
