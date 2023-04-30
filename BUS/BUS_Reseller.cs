using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_Reseller
    {
        DAL_Reseller rs;

        public BUS_Reseller(string resellerid, string resellername, string reselleraddress, string username, string password)
        {
            rs = new DAL_Reseller(resellerid, resellername, reselleraddress, username, password);
        }

        public void addQuery()
        {
            rs.addQuery();
        }

        public void updateQuery()
        {
            rs.updateQuery();
        }

        public void deleteQuery()
        {
            rs.removeQuery();
        }

        public DataTable selectQuery()
        {
            return rs.selectQuery();
        }
    }
}
