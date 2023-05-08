using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Controls;
using System.Windows.Forms;

namespace CalendarSystem 
{
    public partial class Form1 : Form
    {
        private string connectionString = "Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;";
        private DateTime selectedDate;
        private int selectedEventId;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialize the calendar control
            Calendar.MaxSelectionCount = 1;
            Calendar.SelectionStart = DateTime.Today;
            Calendar.SelectionEnd = DateTime.Today;
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            // Update the selected date
            selectedDate = e.Start;

            // Retrieve all events for the selected date
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM events WHERE date = @date", connection);
            command.Parameters.AddWithValue("@date", selectedDate);
            SqlDataReader reader = command.ExecuteReader();

            // Create a list of event teasers
            List<string> eventTeasers = new List<string>();
            while (reader.Read())
            {
                string eventTeaser = $"{reader["name"]} ({reader["time"]})";
                eventTeasers.Add(eventTeaser);
            }
            reader.Close();
            connection.Close();

            // Display the event teasers to the user
            listBox1.DataSource = eventTeasers;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Retrieve the selected event ID from the list box
            if (listBox1.SelectedIndex != -1)
            {
                string eventTeaser = listBox1.SelectedItem.ToString();
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM events WHERE name = @name AND date = @date", connection);
                command.Parameters.AddWithValue("@name", eventTeaser.Split(' ')[0]);
                command.Parameters.AddWithValue("@date", selectedDate);
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                selectedEventId = (int)reader["id"];
                reader.Close();
                connection.Close();
            }
        }

        private void deleteEventButton_Click(object sender, EventArgs e)
        {
            // Check if the event is a team event
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM events WHERE id = @id", connection);
            command.Parameters.AddWithValue("@id", selectedEventId);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            bool isTeamEvent = (bool)reader["is_team_event"];
            reader.Close();
            connection.Close();

            if (isTeamEvent)
            {
                MessageBox.Show("You cannot delete a team event.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this event?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Delete the event from the database
                    connection.Open();
                    command = new SqlCommand("DELETE FROM events WHERE id = @id", connection);
                    command.Parameters.AddWithValue("@id", selectedEventId);
                    command.ExecuteNonQuery();
                    connection.Close();

                    // Refresh the event list
                    monthCalendar1_DateSelected(this, new DateRangeEventArgs(selectedDate, selectedDate));
                }
            }
        }
    }
}
        }

        private void calendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            // Update event list when date is selected on calendar
            UpdateEventList();
        }

        private void Form1_Load(object sender, EventArgs e) =>
            // Update event list when form is loaded
            UpdateEventList();
    }

}

