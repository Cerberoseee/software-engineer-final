using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_GoodImportReceipt
    {
        DTO_GoodImportedReceipt gir;

        public DAL_GoodImportReceipt(string receiptid, DateTime importdate, string employeeid)
        {
            gir = new DTO_GoodImportedReceipt(receiptid, employeeid, importdate);
        }

        public void addQuery()
        {
            string sql = "insert into GoodImportedReceipt values (" +
                "'" + gir._RECEIPTID + "', " +
                "'" + gir._IMPORTDATE.ToString("yyyy/MM/dd") + "', " +
                "'" + gir._EMPLOYEEID+ "'" +
                ")";
            Connection.actionQuery(sql);
        }

        public void updateQuery()
        {
            string sql = "update GoodImportedReceipt set " +
                "ImportDate = '" + gir._IMPORTDATE.ToString("yyyy/MM/dd") + "', " +
                "EmployeeID = '" + gir._EMPLOYEEID + "' " +
                "where ReceiptID = '" + gir._RECEIPTID + "'";
            Connection.actionQuery(sql);
        }

        public void removeQuery()
        {
            string sql = "delete from GoodImportedReceipt where ReceiptID = '" + gir._RECEIPTID + "'";
            Connection.actionQuery(sql);
        }

        public DataTable detailQuery()
        {
            string sql = "select * from GoodImportedReceipt GIR join GoodReceipt GR on GIR.ReceiptID = GR.ReceiptID join Good G on GR.GoodID = G.GoodID";
            return Connection.selectQuery(sql);
        }

        public DataTable selectQuery()
        {
            string sql = "select * from GoodImportedReceipt";
            return Connection.selectQuery(sql);
        }
    }
}
