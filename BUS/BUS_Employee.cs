using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_Employee
    {
        DAL_Employee emp;
        
        public BUS_Employee(string employeeid, string employeename, string employeerole, string username, string password)
        {
            emp = new DAL_Employee(employeeid, employeename, employeerole, username, password);
        }

        public void addQuery()
        {
            emp.addQuery();
        }

        public void updateQuery()
        {
            emp.updateQuery();
        }

        public void deleteQuery()
        {
            emp.removeQuery();
        }

        public DataTable selectQuery()
        {
            return emp.selectQuery();
        }
    }
}
