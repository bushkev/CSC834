using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Drawing;
using Calendar_Project;

namespace CalendarSystem
{
    public partial class MainForm : Form
    {
        private readonly SqlConnection sqlConnection = new SqlConnection("Server=localhost;Database=YourDatabaseName;Trusted_Connection=True;");

        private readonly DateTimePicker dateTimePicker = new DateTimePicker();
        private readonly ListBox listBoxEvents = new ListBox();

        private readonly string currentUser;
        private readonly string userType;

        public MainForm(string currentUser, string userType)
        {
            this.currentUser = currentUser;
            this.userType = userType;

            InitializeComponent();

            BindEventsToList();
        }

        private void InitializeComponent()
        {
            // Set the properties of the dateTimePicker
            dateTimePicker.Format = DateTimePickerFormat.Short;
            dateTimePicker.Location = new Point(10, 10);
            dateTimePicker.ValueChanged += new EventHandler(dateTimePicker_ValueChanged);
            Controls.Add(dateTimePicker);

            // Add the button to add events
            Button buttonAddEvent = new Button();
            buttonAddEvent.Text = "Add Event";
            buttonAddEvent.Location = new Point(10, 40);
            buttonAddEvent.Click += new EventHandler(buttonAddEvent_Click);
            Controls.Add(buttonAddEvent);

            // Add the team event button for managers
            if (userType == "Manager")
            {
                Button buttonSetUpTeamEvent = new Button();
                buttonSetUpTeamEvent.Text = "Set up team event";
                buttonSetUpTeamEvent.Location = new Point(10, 120);
                buttonSetUpTeamEvent.Click += new EventHandler(buttonSetUpTeamEvent_Click);
                Controls.Add(buttonSetUpTeamEvent);
            }

            // Bind the events to the list on the form
            listBoxEvents.DataSource = null;
            listBoxEvents.DisplayMember = "event_name";
            listBoxEvents.ValueMember = "event_id";
            listBoxEvents.Location = new Point(150, 10);
            listBoxEvents.Size = new Size(400, 300);
            Controls.Add(listBoxEvents);
        }

        private void BindEventsToList()
        {
            // Open the SQL connection
            sqlConnection.Open();

            // Select the events for the selected date
            string query = "SELECT * FROM events WHERE event_date = @eventDate";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@eventDate", dateTimePicker.Value);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            // Bind the data to a list on the form
            listBoxEvents.DataSource = dataTable;

            // Close the SQL connection
            sqlConnection.Close();
        }

        private void buttonAddEvent_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm(sqlConnection, currentUser);
            eventForm.ShowDialog();
            BindEventsToList();
        }

        private void buttonSetUpTeamEvent_Click(object sender, EventArgs e)
        {
            TeamEventForm teamEventForm = new TeamEventForm(sqlConnection);
            teamEventForm.ShowDialog();
            BindEventsToList();
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            BindEventsToList();
        }
    }
}
