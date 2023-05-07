using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual_Project
{
    public class Event
    {
        String title;
        String startTime;
        String endTime;
        String reminder;
        String location;
        String date;
        String description;
        Client[] attendees;
        string teamID;
        int eventID;


        public Event(String t, String st, String et, String r, String l, String d, String ds, string tm = null)
        {
            title = t;
            startTime = st;
            endTime = et;
            reminder = r;
            location = l;
            date = d;
            description = ds;
            teamID = tm;
        }

        public Event()
        {

        }

        public bool checkConflict(ArrayList eList)
        {
            if (eList.Count == 0)
                return true;
            for (int i=0; i<eList.Count; i++)
            {
                Event thisEvent = (Event)eList[i];

                if (startTime.CompareTo(thisEvent.getEndTime()) > 0 || endTime.CompareTo(thisEvent.getStartTime()) < 0)
                    continue;
                else
                    return false;
            }
            return true;
        }


        public void updateEventValue(String t, String st, String et, String r, String l, String d, String ds, string tm = null)
        {
            title = t;
            startTime = st;
            endTime = et;
            reminder = r;
            location = l;
            date = d;
            description = ds;
            teamID = tm;
        }
        public String getStartTime()
        {
            return startTime;
        }

        public String getEndTime()
        {
            return endTime;
        }

        public String getReminder()
        {
            return reminder;
        }

        public String getLocation()
        {
            return location;
        }
        public String getTitle()
        {
            return title;
        }

        public String getDescription()
        {
            return description;
        }
        public String getDate()
        {
            return date;
        }

        public string getTeamID()
        {
            return teamID;
        }

        public int getEventID()
        {
            return eventID;
        }

        public static ArrayList getEventList(string dateString, int clientID)
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
                newEvent.teamID = row["teamID"].ToString();
                newEvent.eventID = Convert.ToInt32(row["eventID"]);

                eventList.Add(newEvent);
            }
            return eventList;  //return the event list
        }




    }
}
