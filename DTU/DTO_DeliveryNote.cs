using System;

namespace DTO
{
    public class DTO_DeliveryNote
    {
        private string noteId, orderId, resellerId, deliveryAddress;
        private DateTime deliveryDate;

        public string _NOTEID
        {
            get { return noteId; }
            set { noteId = value; }
        }

        public string _ORDERID
        {
            get { return orderId;  }
            set { orderId = value; }
        }

        public string _RESELERID
        {
            get { return resellerId; }
            set { resellerId = value; }
        }

        public string _DELIVERYADDRESS
        {
            get { return deliveryAddress; }
            set { deliveryAddress = value; }
        }

        public DateTime _DELIVERYDATE 
        {
            get { return deliveryDate; }
            set { deliveryDate = value; }
        }

        public DTO_DeliveryNote(string noteId, string orderId, string resellerId, string deliveryAddress, DateTime deliveryDate)
        {
            this.noteId = noteId;
            this.orderId = orderId;
            this.resellerId = resellerId;
            this.deliveryAddress = deliveryAddress;
            this.deliveryDate = deliveryDate;
        }
    }
}
