using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO 
{
    public class DTO_Reseller
    {
        private string resellerId, resellerName, resellerAddress, username, password;
    
        public string _RESELLERID
        {
            get { return resellerId; }
            set { resellerId = value; }
        }

        public string _RESELLERNAME
        {
            get { return resellerName; }
            set { resellerName = value; }
        }

        public string _RESELLERADDRESS
        {
            get { return resellerAddress; }
            set { resellerAddress = value; }
        }

        public string _USERNAME
        {
            get { return username; }
            set { username = value; }
        }

        public string _PASSWORD
        {
            get { return password; }
            set { password = value; }
        }

        public DTO_Reseller(string resellerId, string resellerName, string resellerAddress, string username, string password)
        {
            this.resellerId = resellerId;
            this.resellerName = resellerName;
            this.resellerAddress = resellerAddress;
            this.username = username;
            this.password = password;
        }
    }
}
