using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

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
                cmd.Parameters.AddWithValue("@eventName", currentEvent.Title);
                cmd.Parameters.AddWithValue("@startTime", currentEvent.StartTime);
                cmd.Parameters.AddWithValue("@endTime", currentEvent.EndTime);
                cmd.Parameters.AddWithValue("@location", currentEvent.Location);
                cmd.Parameters.AddWithValue("@description", currentEvent.Description);
                cmd.Parameters.AddWithValue("@eventDay", currentEvent.Date);
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

        public static bool DeleteEvent(int eventId)
        {
            bool success = true;
            MySqlConnection conn = new MySqlConnection(GlobalVariables.ConnString);

            try
            {
                conn.Open();

                string sqlQuery = $"Delete from {GlobalVariables.EventsTableName} " +
                    $" Where eventID=@eventID";

                MySqlCommand cmd = new MySqlCommand(sqlQuery, conn);
                cmd.Parameters.AddWithValue("@eventID", eventId);

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
                cmd.Parameters.AddWithValue("@eventName", currentEvent.Title);
                cmd.Parameters.AddWithValue("@startTime", currentEvent.StartTime);
                cmd.Parameters.AddWithValue("@endTime", currentEvent.EndTime);
                cmd.Parameters.AddWithValue("@location", currentEvent.Location);
                cmd.Parameters.AddWithValue("@description", currentEvent.Description);
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

        public static bool AddTeamEvent(Event currentEvent, int teamID, List<int> clientIDs)
        {
            bool success = true;
            MySqlConnection conn = new MySqlConnection(GlobalVariables.ConnString);

            try
            {
                conn.Open();

                DataTable myTable = new DataTable();

                #region Get max team event ID
                string getTeamEventIdQuery = $"select MAX(teamEventID) as maxTeamEventID from {GlobalVariables.EventsTableName}";
                MySqlCommand getMaxTeamEventIdCmd = new MySqlCommand(getTeamEventIdQuery, conn);

                int teamEventID = Convert.ToInt32(getMaxTeamEventIdCmd.ExecuteScalar()) + 1;
                #endregion

                #region insert events
                string sqlQuery = $"insert into {GlobalVariables.EventsTableName} " +
                        $" (eventName, startTime, endTime, location, description, eventDay, clientID, teamEventID)" +
                        $" Values ( @eventName, @startTime, @endTime, @location, @description, @eventDay, @clientID, @teamEventID )";

                MySqlCommand cmd = new MySqlCommand(sqlQuery, conn);
                cmd.Parameters.AddWithValue("@eventName", currentEvent.Title);
                cmd.Parameters.AddWithValue("@startTime", currentEvent.StartTime);
                cmd.Parameters.AddWithValue("@endTime", currentEvent.EndTime);
                cmd.Parameters.AddWithValue("@location", currentEvent.Location);
                cmd.Parameters.AddWithValue("@description", currentEvent.Description);
                cmd.Parameters.AddWithValue("@eventDay", currentEvent.Date);
                cmd.Parameters.AddWithValue("@teamEventID", teamEventID);
                cmd.Parameters.Add("@clientID", MySqlDbType.Int32);

                foreach (int item in clientIDs)
                {
                    cmd.Parameters["@clientID"].Value = item;
                    cmd.ExecuteNonQuery();
                }
                #endregion

            }
            catch (Exception ex)
            {
                Console.WriteLine($"error: {ex.Message}");
                success = false;
            }
            conn.Close();

            return success;
        }

        public static bool DeleteTeamEvent(string tEventId)
        {
            bool success = true;
            MySqlConnection conn = new MySqlConnection(GlobalVariables.ConnString);

            try
            {
                int teamEventID = int.Parse(tEventId);
                conn.Open();

                string sqlQuery = $"Delete from {GlobalVariables.EventsTableName} " +
                    $" Where teamEventID=@teamEventID";

                MySqlCommand cmd = new MySqlCommand(sqlQuery, conn);
                cmd.Parameters.AddWithValue("@teamEventID", teamEventID);

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
