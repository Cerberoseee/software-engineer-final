using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_GoodReceipt
    {
        DTO_GoodReceipt gr;

        public DAL_GoodReceipt(string goodid, string receiptid, int quantity)
        {
            gr = new DTO_GoodReceipt(goodid, receiptid, quantity);
        }

        public void addQuery()
        {
            string sql = "insert into GoodReceipt values (" +
                "'" + gr._GOODID + "', " +
                "'" + gr._RECEIPTID + "', " +
                " " + gr._QUANTITY + " " +
                ")";
            Connection.actionQuery(sql);
        }

        public void updateQuery()
        {
            string sql = "update GoodReceipt set " +
                "Quantity = '" + gr._QUANTITY+ "' " +
                "where GoodID = '" + gr._GOODID + "' and ReceiptID = '" + gr._RECEIPTID + "'";
            Connection.actionQuery(sql);
        }

        public void removeQuery()
        {
            string sql = "delete from GoodReceipt where GoodID = '" + gr._GOODID + "' and ReceiptID = '" + gr._RECEIPTID + "'";
            Connection.actionQuery(sql);
        }

        public DataTable selectQuery()
        {
            string sql = "select * from GoodReceipt";
            return Connection.selectQuery(sql);
        }
    }
}
