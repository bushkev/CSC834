using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;

namespace Individual_Project
{
    public class Event
    {
        String title;
        String startTime;
        String endTime;
        String location;
        String date;
        String description;
        int day;
        int month;
        string teamEventID;
        int eventID;

        public Event() { }

        public Event(String t, String st, String et, String l, String d, String ds, string te = null)
        {
            title = t;
            startTime = st;
            endTime = et;
            location = l;
            date = d;
            description = ds;
            teamEventID = te;
        }

        #region getters
        public string StartTime { get => startTime.Substring(0,5); }
        public string EndTime { get => endTime.Substring(0, 5); }
        public string Location { get => location; }
        public string Title { get => title; }
        public string Description { get => description; }
        public string Date { get => date; }
        public string TeamEventID { get => teamEventID; }
        public int EventID { get => eventID; }
        public int Day { get => int.Parse(date.Substring(8)); }
        public int Month { get => int.Parse(date.Substring(5, 2)); }
        #endregion

        public bool CheckConflict(ArrayList eList)
        {
            if (eList.Count == 0)
                return true;
            for (int i=0; i<eList.Count; i++)
            {
                Event thisEvent = (Event)eList[i];

                if (startTime.CompareTo(thisEvent.EndTime) >= 0 || endTime.CompareTo(thisEvent.StartTime) <= 0)
                    continue;
                else
                    return false;
            }
            return true;
        }


        public void UpdateEventValue(String t, String st, String et, String l, String d, String ds, string te = null)
        {
            title = t;
            startTime = st;
            endTime = et;
            location = l;
            date = d;
            description = ds;
            teamEventID = te;
            title = t;
            
            if (string.IsNullOrEmpty(startTime))
            {
                startTime = st;
            }
            
            if (string.IsNullOrEmpty(endTime))
            {
                endTime = et;
            }
        }

        public static ArrayList GetEventList(string dateString, int clientID)
        {
            ArrayList eventList = new ArrayList();  //a list to save the events

            //prepare an SQL query to retrieve all the events on the same, specified date
            DataTable myTable = new DataTable();
            MySqlConnection conn = new MySqlConnection(GlobalVariables.ConnString);
            try
            {
                conn.Open();
                string sql = $"SELECT * FROM {GlobalVariables.EventsTableName} " +
                                $"WHERE eventDay=@myDate " +
                                $"AND clientID=@clientID " +
                                $"ORDER BY startTime ASC";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@myDate", dateString);
                cmd.Parameters.AddWithValue("@clientID", clientID);
                MySqlDataAdapter myAdapter = new MySqlDataAdapter(cmd);
                myAdapter.Fill(myTable);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();

            //convert the retrieved data to events and save them to the list
            foreach (DataRow row in myTable.Rows)
            {
                Event newEvent = new Event();
                newEvent.title = row["eventname"].ToString();
                newEvent.date = ((DateTime) row["eventday"]).ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
                newEvent.startTime = row["startTime"].ToString();
                newEvent.endTime = row["endTime"].ToString();
                newEvent.description = row["description"].ToString();
                newEvent.location = row["location"].ToString();
                newEvent.teamEventID = row["teamEventID"].ToString();
                newEvent.eventID = Convert.ToInt32(row["eventID"]);

                eventList.Add(newEvent);
            }
            return eventList;  //return the event list
        }

        public static List<Tuple<string, string>> GetTeamBusyTimes (string eventDate, List<int> clientIds)
        {
            List<Tuple<string, string>> busyTimes = new List<Tuple<string, string>>();
            MySqlConnection conn = new MySqlConnection(GlobalVariables.ConnString);

            try
            {
                conn.Open();

                string inClause = " ";
                foreach (var client in clientIds)
                {
                    inClause += $" {client},";
                }
                inClause = inClause.Trim(',');

                DataTable myTable = new DataTable();
                string sqlQuerry = $"SELECT distinct startTime, endTime from {GlobalVariables.EventsTableName}" +
                                    $" Where clientID IN ({inClause})" +
                                    $" AND eventday = @date" +
                                    $" ORDER BY startTime";

                MySqlCommand cmd = new MySqlCommand(sqlQuerry, conn);
                cmd.Parameters.AddWithValue("@date", eventDate);

                MySqlDataAdapter myAdapter = new MySqlDataAdapter(cmd);
                myAdapter.Fill(myTable);

                foreach (DataRow row in myTable.Rows )
                {
                    var tuple = Tuple.Create(row["startTime"].ToString(), row["endTime"].ToString());
                    busyTimes.Add(tuple);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"error: {ex.Message}");
            }
            conn.Close();

            return busyTimes;
        }

        public static ArrayList GetMonthlyEventList(int month, int clientID)
        {
            ArrayList eventList = new ArrayList();  //a list to save the events

            //prepare an SQL query to retrieve all the events on the same, specified date
            DataTable myTable = new DataTable();
            MySqlConnection conn = new MySqlConnection(GlobalVariables.ConnString);
            try
            {
                conn.Open();
                string sql = $"SELECT * FROM {GlobalVariables.EventsTableName}" +
                                $" WHERE MONTH(eventday) = @month" +
                                $" AND clientID=@clientID" +
                                $" ORDER BY startTime DESC";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@month", month);
                cmd.Parameters.AddWithValue("@clientID", clientID);
                MySqlDataAdapter myAdapter = new MySqlDataAdapter(cmd);
                myAdapter.Fill(myTable);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();

            //convert the retrieved data to events and save them to the list
            foreach (DataRow row in myTable.Rows)
            {
                Event newEvent = new Event();
                newEvent.title = row["eventname"].ToString();
                newEvent.date = ((DateTime)row["eventday"]).ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
                newEvent.startTime = row["startTime"].ToString();
                newEvent.endTime = row["endTime"].ToString();
                newEvent.description = row["description"].ToString();
                newEvent.location = row["location"].ToString();
                newEvent.teamEventID = row["teamEventID"].ToString();
                newEvent.eventID = Convert.ToInt32(row["eventID"]);

                eventList.Add(newEvent);
            }
            return eventList;  //return the event list
        }
    }
}
