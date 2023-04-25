using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_ItemOrder
    {
        DTO_ItemOrder io;

        public DAL_ItemOrder(string orderid, string resellerid, string orderstatus, string paymentmethod, DateTime createdate) 
        {
            io = new DTO_ItemOrder(orderid, resellerid, orderstatus, paymentmethod, createdate);    
        }

        public void addQuery()
        {
            string sql = "insert into ItemOrder values (" +
                "'" + io._ORDERID+ "', " +
                "'" + io._RESELLERID + "', " +
                "'" + io._ORDERSTATUS + "', " +
                "'" + io._PAYMENTMETHOD + "', " +
                "'" + io._CREATEDATE.ToString("yyyy/MM/dd") + "' " +
                ")";
            Connection.actionQuery(sql);
        }

        public void updateQuery()
        {
            string sql = "update ItemOrder set " +
                "ResellerID = '" + io._RESELLERID + "', " +
                "OrderStatus = '" + io._ORDERSTATUS + "', " +
                "PaymentMethod = '" + io._PAYMENTMETHOD + "', " +
                "CreateDate = '" + io._CREATEDATE.ToString("yyyy/MM/dd") + "' " +
                "where OrderID = '" + io._ORDERID + "'";
            Connection.actionQuery(sql);
        }

        public void removeQuery()
        {
            string sql = "delete from ItemOrder where OrderID = '" + io._ORDERID + "'";
            Connection.actionQuery(sql);
        }

        public DataTable selectQuery()
        {
            string sql = "select * from ItemOrder";
            return Connection.selectQuery(sql);
        }
    }
}
