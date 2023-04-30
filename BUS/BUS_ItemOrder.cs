using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_ItemOrder
    {
        DAL_ItemOrder io;

        public BUS_ItemOrder(string orderid, string resellerid, string orderstatus, string paymentmethod, DateTime createdate)
        {
            io = new DAL_ItemOrder(orderid, resellerid, orderstatus, paymentmethod, createdate);
        }

        public void addQuery()
        {
            io.addQuery();
        }

        public void updateQuery()
        {
            io.updateQuery();
        }

        public void deleteQuery()
        {
            io.removeQuery();
        }

        public DataTable selectQuery()
        {
            return io.selectQuery();
        }
    }
}
