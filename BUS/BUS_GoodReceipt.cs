using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_GoodReceipt
    {
        DAL_GoodReceipt gr;

        public BUS_GoodReceipt(string goodid, string receiptid, int quantity)
        {
            gr = new DAL_GoodReceipt(goodid, receiptid, quantity);
        }

        public void addQuery()
        {
            gr.addQuery();
        }

        public void updateQuere()
        {
            gr.updateQuery();
        }

        public void deleteQuery()
        {
            gr.removeQuery();
        }

        public DataTable selectQuery()
        {
            return gr.selectQuery();
        }
    }
}
