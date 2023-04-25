using System;

namespace DTO
{
    public class DTO_DetailOrder
    {
        private string orderID, goodID;
        private int quantity;

        public string _ORDERID
        {
            get { return orderID; }
            set { orderID = value; }
        }

        public string _GOODID
        {
            get { return goodID; }
            set { goodID = value; }
        }

        public int _QUANTITY
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public DTO_DetailOrder(string orderID, string goodID, int quantity)
        {
            this.orderID = orderID;
            this.goodID = goodID;
            this.quantity = quantity;
        }
    }
}
