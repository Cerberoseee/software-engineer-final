using DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_DeliveryNote
    {
        DTO_DeliveryNote dn;

        public DAL_DeliveryNote(string noteid, string orderid, string resellerid, string deliveryaddress, DateTime deliverydate)
        {
            dn = new DTO_DeliveryNote(noteid, orderid, resellerid, deliveryaddress, deliverydate);
        }


        public void addQuery()
        {
            string sql = "insert into DeliveryNote values (" +
                "'" + dn._NOTEID + "', " +
                "'" + dn._ORDERID + "', " +
                "'" + dn._RESELERID + "', " +
                "'" + dn._DELIVERYDATE.ToString("yyyy/MM/dd") + "', " +
                "'" + dn._DELIVERYADDRESS + "'" +
                ")";
            Connection.actionQuery(sql);
        }

        public void updateQuery()
        {
            string sql = "update DeliveryNote set " +
                "OrderID = '" + dn._ORDERID + "', " +
                "ResellerID = '" + dn._RESELERID + "', " +
                "DeliveryDate = '" + dn._DELIVERYDATE.ToString("yyyy/MM/dd") + "', " +
                "DeliveryAddress = '" + dn._DELIVERYADDRESS + "' " +
                "where NoteID = '" + dn._NOTEID + "'";
            Connection.actionQuery(sql);
        }

        public void removeQuery()
        {
            string sql = "delete from DeliveryNote where NoteID = '" + dn._NOTEID + "'";
            Connection.actionQuery(sql);
        }

        public DataTable selectQuery()
        {
            string sql = "select * from DeliveryNote";
            return Connection.selectQuery(sql);
        }
        
    }
}
