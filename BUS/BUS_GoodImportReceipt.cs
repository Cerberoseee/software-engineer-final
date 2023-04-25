using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_GoodImportReceipt
    {
        DAL_GoodImportReceipt gir;

         public BUS_GoodImportReceipt(string receiptid, DateTime importdate, string employeeid)
        {
            gir = new DAL_GoodImportReceipt(receiptid, importdate, employeeid);
        }

        public void addQuery()
        {
            gir.addQuery();
        }

        public void updateQuere()
        {
            gir.updateQuery();
        }

        public void deleteQuery()
        {
            gir.removeQuery();
        }

        public DataTable selectQuery()
        {
            return gir.selectQuery();
        }
    }
}
