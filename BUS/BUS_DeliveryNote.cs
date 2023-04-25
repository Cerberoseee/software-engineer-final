using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_DeliveryNote
    {
        DAL_DeliveryNote dn;

        public BUS_DeliveryNote(string noteid, string orderid, string resellerid, DateTime deliverydate, string deliveryaddress)
        {
            dn = new DAL_DeliveryNote(noteid, orderid, resellerid, deliveryaddress, deliverydate);
        }
        public void addQuery()
        {
            dn.addQuery();
        }

        public void updateQuere()
        {
            dn.updateQuery();
        }

        public void deleteQuery()
        {
            dn.removeQuery();
        }

        public DataTable selectQuery()
        {
            return dn.selectQuery();
        }
    }
}
