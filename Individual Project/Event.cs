﻿using MySql.Data.MySqlClient;
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
        public String getStartTime()
        {
            return startTime;
        }

        public String getEndTime()
        {
            return endTime;
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

        public string getTeamEventID()
        {
            return teamEventID;
        }

        public int getEventID()
        {
            return eventID;
        }
        #endregion

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


        public void updateEventValue(String t, String st, String et, String l, String d, String ds, string te = null)
        {
            title = t;
            startTime = st;
            endTime = et;
            location = l;
            date = d;
            description = ds;
            teamEventID = te;
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
                newEvent.teamEventID = row["teamEventID"].ToString();
                newEvent.eventID = Convert.ToInt32(row["eventID"]);

                eventList.Add(newEvent);
            }
            return eventList;  //return the event list
        }

        public List<Tuple<string, string>> GetTeamTimes (string eventDate, int teamID)
        {
            List<Tuple<string, string>> busyTimes = new List<Tuple<string, string>>();
            MySqlConnection conn = new MySqlConnection(GlobalVariables.ConnString);

            try
            {
                conn.Open();

                DataTable myTable = new DataTable();
                string sqlQuerry = $"SELECT distinct startTime, endTime from bgcclients c" +
                                    $" JOIN bgcevents e ON c.clientID = e.ClientID" +
                                    $" Where teamID = @teamID" +
                                    $" AND eventday = @date" +
                                    $" ORDER BY startTime";

                MySqlCommand cmd = new MySqlCommand(sqlQuerry, conn);
                cmd.Parameters.AddWithValue("@teamID", teamID);
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
    }
}
