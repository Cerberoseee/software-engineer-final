using System;

namespace DTO
{
    public class DTO_Employee
    {
        private string employeeID, employeeName, employeeRole, username, password;
    
        public string _EMPLOYEEID
        {
            get { return employeeID; }
            set { employeeID = value; }
        }

        public string _EMPLOYEENAME
        {
            get { return employeeName; }
            set { employeeName = value; }
        }

        public string _EMPLOYEEROLE
        {
            get { return employeeRole; }
            set { employeeRole = value; }
        }

        public string _USERNAME
        {
            get { return username; }
            set { username = value; }
        }

        public string _PASSWORD
        {
            get { return password; }
            set { password = value; }
        }

        public DTO_Employee(string employeeID, string employeeName, string employeeRole, string username, string password)
        {
            this.employeeID = employeeID;
            this.employeeName = employeeName;
            this.employeeRole = employeeRole;
            this.username = username;
            this.password = password;
        }
    }
}
