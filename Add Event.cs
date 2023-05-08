using EventCalendar;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CalendarSystem
{
    public partial class AddEventForm : Form
    {
        private DateTime selectedDate;
        private List<Event> eventList;

        public AddEventForm(DateTime selectedDate, List<Event> eventList)
        {
            InitializeComponent();
            this.selectedDate = selectedDate;
            this.eventList = eventList;
            dateLabel.Text = selectedDate.ToShortDateString();

            // Populate the list of event teasers for the selected date
            foreach (Event ev in eventList)
            {
                if (ev.Date == selectedDate)
                {
                    eventsListBox.Items.Add(ev.Teaser);
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string title = titleTextBox.Text;
            DateTime startDateTime = startDateTimePicker.Value;
            DateTime endDateTime = endDateTimePicker.Value;

            // Check for conflicts with existing events
            foreach (Event ev in eventList)
            {
                if (ev.Date == selectedDate &&
                    ((startDateTime >= ev.StartDateTime && startDateTime <= ev.EndDateTime) ||
                    (endDateTime >= ev.StartDateTime && endDateTime <= ev.EndDateTime)))
                {
                    MessageBox.Show("There is a conflict with an existing event", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Add the new event to the database
            SqlConnection connection = new SqlConnection("Your connection string goes here");
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO Events (Title, Date, StartDateTime, EndDateTime) VALUES (@title, @date, @startDateTime, @endDateTime)", connection);
                command.Parameters.AddWithValue("@title", title);
                command.Parameters.AddWithValue("@date", selectedDate);
                command.Parameters.AddWithValue("@startDateTime", startDateTime);
                command.Parameters.AddWithValue("@endDateTime", endDateTime);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }

            // Update the event list with the new event
            Event newEvent = new Event(title, selectedDate, startDateTime, endDateTime);
            eventList.Add(newEvent);
            eventsListBox.Items.Add(newEvent.Teaser);

            // Close the form
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }
    }
}