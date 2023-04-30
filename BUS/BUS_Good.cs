using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_Good
    {
        DAL_Good g;
        public BUS_Good(string goodid, string goodname, int quantity, int price)
        {
            g = new DAL_Good(goodid, goodname, quantity, price);
        }

        public void addQuery()
        {
            g.addQuery();
        }

        public void updateQuery()
        {
            g.updateQuery();
        }

        public void updateQuantityQuery()
        {
            g.updateQuantityQuery();
        }

        public void deleteQuery()
        {
            g.removeQuery();
        }

        public DataTable selectQuery()
        {
            return g.selectQuery();
        }
    }
}
