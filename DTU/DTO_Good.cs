using System;

namespace DTO
{
    public class DTO_Good
    {
        private string goodId, goodName;
        private int quantity, price;

        public string _GOODID
        {
            get { return goodId; }
            set { goodId = value; }
        }

        public string _GOODNAME
        {
            get { return goodName; }
            set { goodName = value; }
        }

        public int _QUANTITY
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public int _PRICE
        {
            get { return price; }
            set { price = value; }
        }

        public DTO_Good(string goodId, string goodName, int quantity, int price)
        {
            this.goodId = goodId;
            this.goodName = goodName;
            this.quantity = quantity;
            this.price = price;
        }
    }
}
