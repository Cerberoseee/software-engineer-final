using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Reseller
    {
        DTO_Reseller rs;

        public DAL_Reseller(string resellerid, string resellername, string reselleraddress, string username, string password)
        {
            rs = new DTO_Reseller(resellerid, resellername, reselleraddress, username, password);
        }

        public static string passwordHash(string password)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] inArray = HashAlgorithm.Create("SHA1").ComputeHash(bytes);
            return Convert.ToBase64String(inArray);
        }

        public void addQuery()
        {
            string sql = "insert into Reseller values (" +
                "'" + rs._RESELLERID + "', " +
                "'" + rs._RESELLERNAME + "', " +
                "'" + rs._RESELLERADDRESS+ "', " +
                "'" + rs._USERNAME + "', " +
                "'" + passwordHash(rs._PASSWORD) + "'" +
                ")";
            Connection.actionQuery(sql);
        }

        public void updateQuery()
        {
            string sql = "update Reseller set " +
                "ResellerName = '" + rs._RESELLERNAME + "', " +
                "ResellerAddress = '" + rs._RESELLERADDRESS + "', " +
                "Username = '" + rs._USERNAME + "', " +
                "Password = '" + passwordHash(rs._PASSWORD) + "' " +
                "where ResellerID = '" + rs._RESELLERID + "'";
            Connection.actionQuery(sql);
        }

        public void removeQuery()
        {
            string sql = "delete from Reseller where ResellerID = '" + rs._RESELLERID+ "'";
            Connection.actionQuery(sql);
        }

        public DataTable selectQuery()
        {
            string sql = "select * from Reseller";
            return Connection.selectQuery(sql);
        }
    }
}
