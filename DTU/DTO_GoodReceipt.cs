using System;

namespace DTO
{
    public class DTO_GoodReceipt
    {
        private string goodId, receiptId;
        private int quantity;

        public string _GOODID
        {
            get { return goodId; }
            set { goodId = value; }
        }

        public string _RECEIPTID
        {
            get { return receiptId; }
            set { receiptId = value; }
        }

        public int _QUANTITY
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public DTO_GoodReceipt(string goodId, string receiptId, int quantity)
        {
            this.goodId = goodId;
            this.receiptId = receiptId;
            this.quantity = quantity;
        }
    }
}
