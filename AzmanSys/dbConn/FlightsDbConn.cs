using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzmanSys
{
    class FlightsDbConn : dbConn
    {
        public void insertFlight(string FlightID, string F_Depar_DateTime, string F_Arrival_DateTime, string F_Departure_City, string F_Arrival_City, string F_Price, string F_Adult_Price, string F_Child_Price, string F_Infant_Price)
        {
            MySqlCommand comm =conn.CreateCommand();
            comm.CommandText = "INSERT INTO `tblFlight`(`FlightID`, `F_Depar_DateTime`, `F_Arrival_DateTime`, `F_Departure_City`, `F_Arrival_City`, `F_Price`, `F_Adult_Price`, `F_ChildPrice`, `F_Infant_Price`) VALUES "+" (NULL, @F_Depar_DateTime, @F_Arrival_DateTime, @F_Departure_City, @F_Arrival_City, @F_Price, @F_Adult_Price, @F_Child_Price, @F_Infant_Price);";
            comm.Parameters.AddWithValue("@F_Depar_DateTime", F_Depar_DateTime);
            comm.Parameters.AddWithValue("@F_Arrival_DateTime", F_Arrival_DateTime);
            comm.Parameters.AddWithValue("@F_Departure_City", F_Departure_City);
            comm.Parameters.AddWithValue("@F_Arrival_City", F_Arrival_City);
            comm.Parameters.AddWithValue("@F_Price", F_Price);
            comm.Parameters.AddWithValue("@F_Adult_Price", F_Adult_Price);
            comm.Parameters.AddWithValue("@F_Child_Price", F_Child_Price);
            comm.Parameters.AddWithValue("@F_Infant_Price", F_Infant_Price);
            comm.ExecuteNonQuery();
            connClose();
        }


        public void updateFlight(String FlightID, string F_Depar_DateTime, string F_Arrival_DateTime, string F_Departure_City, string F_Arrival_City, string F_Price, string F_Adult_Price, string F_Child_Price, string F_Infant_Price)
        {
            MySqlCommand comm= conn.CreateCommand();
            comm.CommandText = "UPDATE `tblFlight` SET `F_Depar_DateTime`=@F_Depar_DateTime,`F_Arrival_DateTime`=@F_Arrival_DateTime,`F_Departure_City`=@F_Departure_City," +"`F_Arrival_City`=@F_Arrival_City, `F_Price` =@F_Price, `F_Adult_Price`=@F_Adult_Price, `F_Child_Price`=@F_Child_Price, `F_Infant_Price`=@F_Infant_Price WHERE FlightID = @FlightID";
            comm.Parameters.AddWithValue("@FlightID", FlightID);
            comm.Parameters.AddWithValue("@F_Depar_DateTime", F_Depar_DateTime);
            comm.Parameters.AddWithValue("@F_Arrival_DateTime", F_Arrival_DateTime);
            comm.Parameters.AddWithValue("@F_Departure_City", F_Departure_City);
            comm.Parameters.AddWithValue("@F_Arrival_City", F_Arrival_City);
            comm.Parameters.AddWithValue("@F_Price", F_Price);
            comm.Parameters.AddWithValue("@F_Adult_Price", F_Adult_Price);
            comm.Parameters.AddWithValue("F_Child_Price", F_Child_Price);
            comm.Parameters.AddWithValue("F_Infant_Price", F_Infant_Price);
            comm.ExecuteNonQuery();
            connClose();
        }

        public void deleteBooking(string FlightID)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "DELETE FROM `tblBooking` WHERE `FlightID` = @FlightID";
            comm.Parameters.AddWithValue("@FlightID", FlightID);
            comm.ExecuteNonQuery();
            connClose();
        }
    }
}
