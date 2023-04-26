using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Good
    {
        DTO_Good g;

        public DAL_Good(string goodid, string goodname, int quantity, int price) {
            g = new DTO_Good(goodid, goodname, quantity, price);
        }

        public void addQuery()
        {
            DataTable dt = this.selectQuery();

            DataRow[] rows = dt.Select("GoodID = '" + g._GOODID + "'");
            string sql;
            if (rows.Length != 0)
            {
                sql = "update Good set " +
                "GoodName = '" + g._GOODNAME + "', " +
                "Quantity = " + (Int32.Parse(rows[0]["Quantity"].ToString()) + g._QUANTITY) + ", " +
                "Price = " + g._PRICE + " " +
                "where GoodID = '" + g._GOODID + "'";
            } else
            {
               sql = "insert into Good values (" +
                   "'" + g._GOODID + "', " +
                   "'" + g._GOODNAME + "', " +
                   " " + g._QUANTITY + ", " +
                   " " + g._PRICE + " " +
                   ")";
            }

           
            Connection.actionQuery(sql);
        }

        public void updateQuery()
        {
            string sql = "update Good set " +
                "GoodName = '" + g._GOODNAME + "', " +
                "Quantity = " + g._QUANTITY + ", " +
                "Price = " + g._PRICE + " " +
                "where GoodID = '" + g._GOODID + "'";
            Connection.actionQuery(sql);
        }

        public void removeQuery()
        {
            string sql = "delete from Good where GoodID = '" + g._GOODID + "'";
            Connection.actionQuery(sql);
        }

        public DataTable selectQuery()
        {
            string sql = "select * from Good";
            return Connection.selectQuery(sql);
        }
    }
}
