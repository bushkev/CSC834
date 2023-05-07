using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Individual_Project
{
    public static class Modifications
    {
        public static bool AddEvent(Event currentEvent, int clientID)
        {
            bool success = true;
            MySqlConnection conn = new MySqlConnection(GlobalVariables.ConnString);

            try
            {
                conn.Open();

                string sqlQuery = $"insert into {GlobalVariables.EventsTableName} " +
                    $" (eventName, startTime, endTime, location, description, eventDay, clientID)" +
                    $" Values ( @eventName, @startTime, @endTime, @location, @description, @eventDay, @clientID )";

                MySqlCommand cmd = new MySqlCommand(sqlQuery, conn);
                cmd.Parameters.AddWithValue("@eventName", currentEvent.getTitle());
                cmd.Parameters.AddWithValue("@startTime", currentEvent.getStartTime());
                cmd.Parameters.AddWithValue("@endTime", currentEvent.getEndTime());
                cmd.Parameters.AddWithValue("@location", currentEvent.getLocation());
                cmd.Parameters.AddWithValue("@description", currentEvent.getDescription());
                cmd.Parameters.AddWithValue("@eventDay", currentEvent.getDate());
                cmd.Parameters.AddWithValue("@clientID", clientID);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"error: {ex.Message}");
                success = false;
            }
            conn.Close();

            return success;
        }

        public static bool DeleteEvent(Event currentEvent)
        {
            bool success = true;
            MySqlConnection conn = new MySqlConnection(GlobalVariables.ConnString);

            try
            {
                conn.Open();

                string sqlQuery = $"Delete from {GlobalVariables.EventsTableName} " +
                    $" Where eventID=@eventID";

                MySqlCommand cmd = new MySqlCommand(sqlQuery, conn);
                cmd.Parameters.AddWithValue("@eventID", currentEvent.getEventID());

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"error: {ex.Message}");
                success = false;
            }
            conn.Close();

            return success;
        }

        public static bool EditEvent(Event currentEvent, int eventID)
        {
            bool success = true;
            MySqlConnection conn = new MySqlConnection(GlobalVariables.ConnString);

            try
            {
                conn.Open();

                string sqlQuery = $"Update {GlobalVariables.EventsTableName} " +
                    $" Set eventName = @eventName," +
                    $" startTime = @startTime," +
                    $" endTime = @endTime," +
                    $" location = @location," +
                    $" description = @description" +
                    $" Where eventID = @eventID";

                MySqlCommand cmd = new MySqlCommand(sqlQuery, conn);
                cmd.Parameters.AddWithValue("@eventName", currentEvent.getTitle());
                cmd.Parameters.AddWithValue("@startTime", currentEvent.getStartTime());
                cmd.Parameters.AddWithValue("@endTime", currentEvent.getEndTime());
                cmd.Parameters.AddWithValue("@location", currentEvent.getLocation());
                cmd.Parameters.AddWithValue("@description", currentEvent.getDescription());
                cmd.Parameters.AddWithValue("@eventID", eventID);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"error: {ex.Message}");
                success = false;
            }
            conn.Close();

            return success;
        }
    }
}
