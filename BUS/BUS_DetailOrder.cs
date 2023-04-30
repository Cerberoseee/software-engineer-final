using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_DetailOrder
    {
        DAL_DetailOrder dor;
        public BUS_DetailOrder(string orderid, string goodid, int quantity)
        {
            dor = new DAL_DetailOrder(orderid, goodid, quantity);
        }

        public void addQuery()
        {
            dor.addQuery();
        }

        public void updateQuery()
        {
            dor.updateQuery();
        }

        public void deleteQuery()
        {
            dor.removeQuery();
        }

        public DataTable selectQuery()
        {
            return dor.selectQuery();
        }
    }
}
