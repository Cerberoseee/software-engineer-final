using DTO;
using System.Data;

namespace DAL
{
    public class DAL_DetailOrder
    {
        DTO_DetailOrder dor;

        public DAL_DetailOrder(string orderid, string goodid, int quantity)
        {
            dor = new DTO_DetailOrder(orderid, goodid, quantity);
        }

        public void addQuery()
        {
            string sql = "insert into DetailOrder values (" +
                " '" + dor._ORDERID + "', " +
                " '" + dor._GOODID + "', " +
                " " + dor._QUANTITY + "" +
                ")";
            Connection.actionQuery(sql);
        }

        public void updateQuery()
        {
            string sql = "update DetailOrder set " +
                "GoodID = '" + dor._GOODID + "', " +
                "Quantity = " + dor._QUANTITY + " " +
                "where OrderID = '" + dor._ORDERID + "' ";
            Connection.actionQuery(sql);
        }

        public void removeQuery()
        {
            string sql = "delete from DetailOrder where OrderID = '" + dor._ORDERID + "'";
            Connection.actionQuery(sql);
        }

        public DataTable selectQuery()
        {
            string sql = "select * from DetailOrder";
            return Connection.selectQuery(sql);
        }
    }
}
