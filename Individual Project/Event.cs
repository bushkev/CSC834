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
    class Event
    {
        String title;
        String startTime;
        String endTime;
        String reminder;
        String location;
        String date;
        String description;
        User[] attendees;


        public Event(String t, String st, String et, String r, String l, String d, String ds)
        {
            title = t;
            startTime = st;
            endTime = et;
            reminder = r;
            location = l;
            date = d;
            description = ds;
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


        public void updateEventValue(String t, String st, String et, String r, String l, String d, String ds)
        {
            title = t;
            startTime = st;
            endTime = et;
            reminder = r;
            location = l;
            date = d;
            description = ds;
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
        public static ArrayList getEventList(string dateString)
        {
            ArrayList eventList = new ArrayList();  //a list to save the events
            //prepare an SQL query to retrieve all the events on the same, specified date
            DataTable myTable = new DataTable();
            string connStr = "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "SELECT * FROM greeneEvents WHERE eventDay=@myDate ORDER BY startTime ASC";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@myDate", dateString);
                MySqlDataAdapter myAdapter = new MySqlDataAdapter(cmd);
                myAdapter.Fill(myTable);
                Console.WriteLine("Table is ready.");
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
                newEvent.date = row["eventday"].ToString();
                newEvent.startTime = row["startTime"].ToString();
                newEvent.endTime = row["endTime"].ToString();
                //newEvent.reminder = row["reminder"].ToString();
                //newEvent.endTime = Int32.Parse(row["endTime"].ToString());
                newEvent.description = row["description"].ToString();
                newEvent.location = row["location"].ToString();
                eventList.Add(newEvent);
            }
            return eventList;  //return the event list
        }




    }
}
