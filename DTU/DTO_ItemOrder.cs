using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ItemOrder
    {
        private string orderId, resellerId, orderStatus, paymentMethod;
        private DateTime createDate;


        public string _ORDERID
        {
            get { return orderId; }
            set { orderId = value; }
        }

        public string _RESELLERID
        {
            get { return resellerId; }
            set { resellerId = value; }
        }

        public string _ORDERSTATUS
        {
            get { return orderStatus; }
            set { orderStatus = value; }
        }

        public string _PAYMENTMETHOD
        {
            get { return paymentMethod; }
            set { paymentMethod = value; }
        }

        public DateTime _CREATEDATE
        {
            get { return createDate; }
            set { createDate = value; }
        }


        public DTO_ItemOrder(string orderId, string resellerId, string orderStatus, string paymentMethod, DateTime createDate)
        {
            this.orderId = orderId;
            this.resellerId = resellerId;
            this.orderStatus = orderStatus;
            this.paymentMethod = paymentMethod;
            this.createDate = createDate;
        }
    }
}
