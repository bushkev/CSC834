using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace Individual_Project
{
    public partial class Form1 : Form
    {
        ArrayList eList;
        Client currentUser;
        Event selectedEvent = new Event();

        public Form1()
        {
            InitializeComponent();
            initializeTimeSections();
        }

        private void initializeTimeSections()
        {
            //textBox2.Visible = false;
            comboBox1.Items.Add("00:00");
            comboBox1.Items.Add("00:30");
            comboBox1.Items.Add("01:00");
            comboBox1.Items.Add("01:30");
            comboBox1.Items.Add("02:00");
            comboBox1.Items.Add("02:30");
            comboBox1.Items.Add("03:00");
            comboBox1.Items.Add("03:30");
            comboBox1.Items.Add("04:00");
            comboBox1.Items.Add("04:30");
            comboBox1.Items.Add("05:00");
            comboBox1.Items.Add("05:30");
            comboBox1.Items.Add("06:00");
            comboBox1.Items.Add("06:30");
            comboBox1.Items.Add("07:00");
            comboBox1.Items.Add("07:30");
            comboBox1.Items.Add("08:00");
            comboBox1.Items.Add("08:30");
            comboBox1.Items.Add("09:00");
            comboBox1.Items.Add("09:30");
            comboBox1.Items.Add("10:00");
            comboBox1.Items.Add("10:30");
            comboBox1.Items.Add("11:00");
            comboBox1.Items.Add("11:30");
            comboBox1.Items.Add("12:00");
            comboBox1.Items.Add("12:30");
            comboBox1.Items.Add("13:00");
            comboBox1.Items.Add("13:30");
            comboBox1.Items.Add("14:00");
            comboBox1.Items.Add("14:30");
            comboBox1.Items.Add("15:00");
            comboBox1.Items.Add("15:30");
            comboBox1.Items.Add("16:00");
            comboBox1.Items.Add("16:30");
            comboBox1.Items.Add("17:00");
            comboBox1.Items.Add("17:30");
            comboBox1.Items.Add("18:00");
            comboBox1.Items.Add("18:30");
            comboBox1.Items.Add("19:00");
            comboBox1.Items.Add("19:30");
            comboBox1.Items.Add("20:00");
            comboBox1.Items.Add("20:30");
            comboBox1.Items.Add("21:00");
            comboBox1.Items.Add("21:30");
            comboBox1.Items.Add("22:00");
            comboBox1.Items.Add("22:30");
            comboBox1.Items.Add("23:00");
            comboBox1.Items.Add("23:30");
            comboBox1.Items.Add("24:00");

            comboBox2.Items.Add("00:00");
            comboBox2.Items.Add("00:30");
            comboBox2.Items.Add("01:00");
            comboBox2.Items.Add("01:30");
            comboBox2.Items.Add("02:00");
            comboBox2.Items.Add("02:30");
            comboBox2.Items.Add("03:00");
            comboBox2.Items.Add("03:30");
            comboBox2.Items.Add("04:00");
            comboBox2.Items.Add("04:30");
            comboBox2.Items.Add("05:00");
            comboBox2.Items.Add("05:30");
            comboBox2.Items.Add("06:00");
            comboBox2.Items.Add("06:30");
            comboBox2.Items.Add("07:00");
            comboBox2.Items.Add("07:30");
            comboBox2.Items.Add("08:00");
            comboBox2.Items.Add("08:30");
            comboBox2.Items.Add("09:00");
            comboBox2.Items.Add("09:30");
            comboBox2.Items.Add("10:00");
            comboBox2.Items.Add("10:30");
            comboBox2.Items.Add("11:00");
            comboBox2.Items.Add("11:30");
            comboBox2.Items.Add("12:00");
            comboBox2.Items.Add("12:30");
            comboBox2.Items.Add("13:00");
            comboBox2.Items.Add("13:30");
            comboBox2.Items.Add("14:00");
            comboBox2.Items.Add("14:30");
            comboBox2.Items.Add("15:00");
            comboBox2.Items.Add("15:30");
            comboBox2.Items.Add("16:00");
            comboBox2.Items.Add("16:30");
            comboBox2.Items.Add("17:00");
            comboBox2.Items.Add("17:30");
            comboBox2.Items.Add("18:00");
            comboBox2.Items.Add("18:30");
            comboBox2.Items.Add("19:00");
            comboBox2.Items.Add("19:30");
            comboBox2.Items.Add("20:00");
            comboBox2.Items.Add("20:30");
            comboBox2.Items.Add("21:00");
            comboBox2.Items.Add("21:30");
            comboBox2.Items.Add("22:00");
            comboBox2.Items.Add("22:30");
            comboBox2.Items.Add("23:00");
            comboBox2.Items.Add("23:30");
            comboBox2.Items.Add("24:00");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Add Event Button
            button1.BackColor = Color.Red;
            emptyEventForm();

            textBoxEventStartTime.Visible = false;
            comboBox1.Visible = true;
            comboBox1.SelectedIndex = 0;
            textBoxEventEndTime.Visible = false;
            comboBox2.Visible = true;
            comboBox2.SelectedIndex = 0;
            button6.Visible = true;
            button7.Visible = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            String thisDate = monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd");

            //Todo: add logic to make sure start date is before end date. May want to create new error message.

            Event newEvent = new Event(textBoxEventTitle.Text, comboBox1.SelectedItem.ToString(), comboBox2.SelectedItem.ToString(),
               textBoxEventRemind.Text, textBoxEventLocation.Text, thisDate, textBoxEventDescription.Text);
            bool noConflict = newEvent.checkConflict(eList);

            panelEvent.Visible = false;
            button1.BackColor = DefaultBackColor;
            button4.BackColor = DefaultBackColor;

            //Enable the 5 main buttons
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;

            if (noConflict)
            {
                if (Modifications.AddEvent(newEvent, currentUser.ClientID))
                {
                    {
                        ViewEvents(thisDate);
                    }
                }
            }
            else
            {
                panelConflictError.Visible = true;
                panelEvent.Visible = false;
            }            
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedEvent = (Event)eList[listBox1.SelectedIndex];
            panelEvent.Visible = true;
            textBoxEventTitle.Text = selectedEvent.getTitle();
            textBoxEventStartTime.Text = selectedEvent.getStartTime();
            textBoxEventEndTime.Text = selectedEvent.getEndTime();
            textBoxEventRemind.Text = selectedEvent.getReminder();
            textBoxEventLocation.Text = selectedEvent.getLocation();
            textBoxEventDescription.Text = selectedEvent.getDescription();
        }

        private void MonthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            //Turn off event panel if selecting a different date
            panelEvent.Visible = false;
            String thisDate = monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd");
            ViewEvents(thisDate);
        }

        private void emptyEventForm()
        {
            panelEvent.Visible = true;
            textBoxEventTitle.Text = "";
            textBoxEventStartTime.Text = "";
            textBoxEventEndTime.Text = "";
            textBoxEventRemind.Text = "";
            textBoxEventLocation.Text = "";
            textBoxEventAttendees.Text = "";
            textBoxEventDescription.Text = "";
        }
        private void Button7_Click(object sender, EventArgs e)
        {
            //Cancel Button
            panelEvent.Visible = false;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button1.BackColor = DefaultBackColor;
            button4.BackColor = DefaultBackColor;
            button6.Visible = false;
            button7.Visible = false;
            textBoxEventStartTime.Visible = true;
            comboBox1.Visible = false;
            textBoxEventEndTime.Visible = true;
            comboBox2.Visible = false;
            if (eList.Count != 0 && listBox1.SelectedIndex >= 0)
            {
                ListBox1_SelectedIndexChanged(sender, e);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //TODO: delete this button if it is unnecessary
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Delete Event Button
            if (selectedEvent.getEventID() != 0)
            {
                button2.BackColor = Color.Red;
                panelEvent.Visible = false;
                panelDeleteConfirm.Visible = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Cancel deleting event button
            button2.BackColor = DefaultBackColor;
            panelDeleteConfirm.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //Confirm deleting event button
            button2.BackColor = DefaultBackColor;
            panelDeleteConfirm.Visible = false;

            if (Modifications.DeleteEvent(selectedEvent))
            {
                ViewEvents(selectedEvent.getDate());
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //Cancel add event after error button
            panelEvent.Visible = false;
            panelConflictError.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Edit Event Button
            button4.BackColor = Color.Red;

            //Allow edits toEventForm();
            emptyEventForm();
            textBoxEventStartTime.Visible = false;
            comboBox1.Visible = true;
            comboBox1.SelectedIndex = 0;
            textBoxEventEndTime.Visible = false;
            comboBox2.Visible = true;
            comboBox2.SelectedIndex = 0;
            button6.Visible = true;
            button7.Visible = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;

            //TODO: add functionality for editing events
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            //Continue after error button
            panelEvent.Visible = true;
            panelConflictError.Visible = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //Login button
            var userName = textBoxUserName.Text;
            var password = textBoxPassword.Text;

            currentUser = new Client(userName, password);

            if (currentUser.IsCredentialsGood)
            {
                panelLogin.Visible = false;
                monthCalendar1.Visible = true;
                label1.Visible = true;
                listBox1.Visible = true;
                button1.Visible = true;
                button2.Visible = true;
                button4.Visible = true;
                button5.Visible = true;

                if (!currentUser.IsManager) button14.Visible = false;

                string todayDate = DateTime.Today.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
                ViewEvents(todayDate);
            }
            else
            {
                panelLoginError.Visible = true;
                textBoxPassword.Text= string.Empty;
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            //Try Again Button
            panelLoginError.Visible = false;
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //View Monthly Events button
            comboBox3.Visible = true;
            string thisMonth = DateTime.Now.ToString("MMMM");
            string thisYear = DateTime.Now.ToString("yyyy");
            label1.Text = "Events for the month of " + thisMonth + " " + thisYear;

            //Populate listBox1 with this month's events
            listBox1.Items.Clear();
            for (int i = 0; i < eList.Count; i++)
            {
                Event currentEvent = (Event)eList[i];
                String aString = currentEvent.getTitle();
                listBox1.Items.Add(aString);
            }
            //TODO: make this show a list of all events for the month, not just for whatever day is selected
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Select Month Drop-Down Menu
            string month = comboBox3.SelectedItem.ToString();
            label1.Text = "Events for the month of " + month + " 2023";

            //TODO: make label1 text display correct year from the dropdown list
            //TODO: add functionality of populating the listbox with the selected month's events
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //Set Up Team Event button
            button14.Visible = false;
            panelEventTeam.Visible = true;
            panelEvent.Visible = false;
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            //Find Possible Time Slots Button            
            panelTimeSlotChoice.Visible = true;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //Save Potential Time Slots Button
        }

        private void button18_Click(object sender, EventArgs e)
        {
            //Cancel Potential Time Slots Button
            panelTimeSlotChoice.Visible = false;
            panelEventTeam.Visible = false;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button1.BackColor = DefaultBackColor;
            button4.BackColor = DefaultBackColor;            
           
            if (eList.Count != 0 && listBox1.SelectedIndex >= 0)
            {
                ListBox1_SelectedIndexChanged(sender, e);
            }
        }

        private void ViewEvents (string date)
        {
            label1.Text = "Events on " + date;
            eList = Event.getEventList(date, currentUser.ClientID);
            
            listBox1.Items.Clear();

            for (int i = 0; i < eList.Count; i++)
            {
                Event currentEvent = (Event)eList[i];
                string aString = currentEvent.getStartTime() + "  " + currentEvent.getTitle();
                listBox1.Items.Add(aString);
            }
        }
    }
}
