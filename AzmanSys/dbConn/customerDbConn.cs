using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace AzmanSys
{
    class customerDbConn: dbConn
    {
        public void insertCustomer(string CustID, string CusFName, string CusLName, string CusAge, string CusGender, string CusNationality, string CusAddress, string CusTelNum, string CusEmail)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText ="INSERT INTO `tblCustomer` (`CustID`, `CusFName`, `CusLName`, `CusAge`, `CusGender`, `CusNationality`, `CusAddress`, `CusTelNum`, `CusEmail`) VALUES (NULL,@CusFName, @CusLName, @CusAge, @CusGender, @CusNationality, @CusAddress, @CusTelNum, @CusEmail);";
            comm.Parameters.AddWithValue("CustomerID", CustID);
            comm.Parameters.AddWithValue("@CusFName", CusFName);
            comm.Parameters.AddWithValue("@CusLName", CusLName);
            comm.Parameters.AddWithValue("@CusAge", CusAge);
            comm.Parameters.AddWithValue("@CusGender", CusGender);
            comm.Parameters.AddWithValue("@CusNationality", CusNationality);
            comm.Parameters.AddWithValue("@CusAddress", CusAddress);
            comm.Parameters.AddWithValue("@CusTelNum", CusTelNum);
            comm.Parameters.AddWithValue("@CusEmail", CusEmail);
            comm.ExecuteNonQuery();
            connClose();
        }

        public void updateCustomer(string CustID, string CusFName, string CusLName, string CusAge, string CusGender, string CusNationality, string CusAddress, string CusTelNum, string CusEmail)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "UPDATE `tblCustomer` SET `CustID` =@CustID, `CusFName` =@CusFName, `CusLName` =@CusLName, `CusAge` =@CusAge, `CusGender` =@CusGender, `CusNationality` =@CusNationality, `CusAddress` =@CusAddress, `CusTelNum` =@CusTelNum, `CusEmail` =@CusEmail WHERE CustomerID =@CustomerID";
            comm.Parameters.AddWithValue("@CustID",CustID);
            comm.Parameters.AddWithValue("@CusFName", CusFName);
            comm.Parameters.AddWithValue("@CusLName", CusLName);
            comm.Parameters.AddWithValue("@CusAge", CusAge);
            comm.Parameters.AddWithValue("@CusGender", CusGender);
            comm.Parameters.AddWithValue("@CusNationality", CusNationality);
            comm.Parameters.AddWithValue("@CusAddress", CusAddress);
            comm.Parameters.AddWithValue("@CusTelNum", CusTelNum);
            comm.Parameters.AddWithValue("@CusEmail", CusEmail);
            comm.ExecuteNonQuery();
            connClose();
        }

        public void deleteCustomer(string CustID)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "DELETE FROM `tblCustomer` WHERE CustID = @CustID";
            comm.Parameters.AddWithValue("@CustID", CustID);
            comm.ExecuteNonQuery();
            connClose();
        }
    }
}
