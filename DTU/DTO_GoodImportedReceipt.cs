using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_GoodImportedReceipt
    {
        private string receiptId, employeeId;
        private DateTime importDate;

        public string _RECEIPTID
        {
            get { return receiptId; }
            set { receiptId = value; }
        }

        public string _EMPLOYEEID
        {
            get { return employeeId; }
            set { employeeId = value; }
        }

        public DateTime _IMPORTDATE
        {
            get { return importDate; }
            set { importDate = value; }
        }

        public DTO_GoodImportedReceipt(string receiptId, string employeeId, DateTime importDate)
        {
            this.receiptId = receiptId;
            this.employeeId = employeeId;
            this.importDate = importDate;
        }
    }
}
