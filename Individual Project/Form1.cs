using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace Individual_Project
{
    public partial class FormMain : Form
    {
        ArrayList eList;
        Client currentUser;
        Event selectedEvent = new Event();
        bool addEvent = false;

        public FormMain()
        {
            InitializeComponent();
            initializeTimeSections();
        }

        private void initializeTimeSections()
        {
            //textBox2.Visible = false;
            comboBoxStartTime.Items.Add("00:00");
            comboBoxStartTime.Items.Add("00:30");
            comboBoxStartTime.Items.Add("01:00");
            comboBoxStartTime.Items.Add("01:30");
            comboBoxStartTime.Items.Add("02:00");
            comboBoxStartTime.Items.Add("02:30");
            comboBoxStartTime.Items.Add("03:00");
            comboBoxStartTime.Items.Add("03:30");
            comboBoxStartTime.Items.Add("04:00");
            comboBoxStartTime.Items.Add("04:30");
            comboBoxStartTime.Items.Add("05:00");
            comboBoxStartTime.Items.Add("05:30");
            comboBoxStartTime.Items.Add("06:00");
            comboBoxStartTime.Items.Add("06:30");
            comboBoxStartTime.Items.Add("07:00");
            comboBoxStartTime.Items.Add("07:30");
            comboBoxStartTime.Items.Add("08:00");
            comboBoxStartTime.Items.Add("08:30");
            comboBoxStartTime.Items.Add("09:00");
            comboBoxStartTime.Items.Add("09:30");
            comboBoxStartTime.Items.Add("10:00");
            comboBoxStartTime.Items.Add("10:30");
            comboBoxStartTime.Items.Add("11:00");
            comboBoxStartTime.Items.Add("11:30");
            comboBoxStartTime.Items.Add("12:00");
            comboBoxStartTime.Items.Add("12:30");
            comboBoxStartTime.Items.Add("13:00");
            comboBoxStartTime.Items.Add("13:30");
            comboBoxStartTime.Items.Add("14:00");
            comboBoxStartTime.Items.Add("14:30");
            comboBoxStartTime.Items.Add("15:00");
            comboBoxStartTime.Items.Add("15:30");
            comboBoxStartTime.Items.Add("16:00");
            comboBoxStartTime.Items.Add("16:30");
            comboBoxStartTime.Items.Add("17:00");
            comboBoxStartTime.Items.Add("17:30");
            comboBoxStartTime.Items.Add("18:00");
            comboBoxStartTime.Items.Add("18:30");
            comboBoxStartTime.Items.Add("19:00");
            comboBoxStartTime.Items.Add("19:30");
            comboBoxStartTime.Items.Add("20:00");
            comboBoxStartTime.Items.Add("20:30");
            comboBoxStartTime.Items.Add("21:00");
            comboBoxStartTime.Items.Add("21:30");
            comboBoxStartTime.Items.Add("22:00");
            comboBoxStartTime.Items.Add("22:30");
            comboBoxStartTime.Items.Add("23:00");
            comboBoxStartTime.Items.Add("23:30");
            comboBoxStartTime.Items.Add("24:00");

            comboBoxEndTime.Items.Add("00:00");
            comboBoxEndTime.Items.Add("00:30");
            comboBoxEndTime.Items.Add("01:00");
            comboBoxEndTime.Items.Add("01:30");
            comboBoxEndTime.Items.Add("02:00");
            comboBoxEndTime.Items.Add("02:30");
            comboBoxEndTime.Items.Add("03:00");
            comboBoxEndTime.Items.Add("03:30");
            comboBoxEndTime.Items.Add("04:00");
            comboBoxEndTime.Items.Add("04:30");
            comboBoxEndTime.Items.Add("05:00");
            comboBoxEndTime.Items.Add("05:30");
            comboBoxEndTime.Items.Add("06:00");
            comboBoxEndTime.Items.Add("06:30");
            comboBoxEndTime.Items.Add("07:00");
            comboBoxEndTime.Items.Add("07:30");
            comboBoxEndTime.Items.Add("08:00");
            comboBoxEndTime.Items.Add("08:30");
            comboBoxEndTime.Items.Add("09:00");
            comboBoxEndTime.Items.Add("09:30");
            comboBoxEndTime.Items.Add("10:00");
            comboBoxEndTime.Items.Add("10:30");
            comboBoxEndTime.Items.Add("11:00");
            comboBoxEndTime.Items.Add("11:30");
            comboBoxEndTime.Items.Add("12:00");
            comboBoxEndTime.Items.Add("12:30");
            comboBoxEndTime.Items.Add("13:00");
            comboBoxEndTime.Items.Add("13:30");
            comboBoxEndTime.Items.Add("14:00");
            comboBoxEndTime.Items.Add("14:30");
            comboBoxEndTime.Items.Add("15:00");
            comboBoxEndTime.Items.Add("15:30");
            comboBoxEndTime.Items.Add("16:00");
            comboBoxEndTime.Items.Add("16:30");
            comboBoxEndTime.Items.Add("17:00");
            comboBoxEndTime.Items.Add("17:30");
            comboBoxEndTime.Items.Add("18:00");
            comboBoxEndTime.Items.Add("18:30");
            comboBoxEndTime.Items.Add("19:00");
            comboBoxEndTime.Items.Add("19:30");
            comboBoxEndTime.Items.Add("20:00");
            comboBoxEndTime.Items.Add("20:30");
            comboBoxEndTime.Items.Add("21:00");
            comboBoxEndTime.Items.Add("21:30");
            comboBoxEndTime.Items.Add("22:00");
            comboBoxEndTime.Items.Add("22:30");
            comboBoxEndTime.Items.Add("23:00");
            comboBoxEndTime.Items.Add("23:30");
            comboBoxEndTime.Items.Add("24:00");
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            //Add Event Button
            buttonAdd.BackColor = Color.Red;
            addEvent = true;
            emptyEventForm();

            textBoxEventStartTime.Visible = false;
            comboBoxStartTime.Visible = true;
            comboBoxStartTime.SelectedIndex = 0;
            textBoxEventEndTime.Visible = false;
            comboBoxEndTime.Visible = true;
            comboBoxEndTime.SelectedIndex = 0;
            buttonSaveEvent.Visible = true;
            buttonCancelEvent.Visible = true;
            buttonAdd.Enabled = false;
            buttonDelete.Enabled = false;
            buttonEdit.Enabled = false;
            buttonViewMonthly.Enabled = false;
        }

        // Button that saves data for add and edit events.
        private void ButtonSaveEvent_Click(object sender, EventArgs e)
        {
            String thisDate = monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd");
            //Todo: add logic to make sure start date is before end date. May want to create new error message.

            Event workEvent = new Event(textBoxEventTitle.Text, comboBoxStartTime.SelectedItem.ToString(), comboBoxEndTime.SelectedItem.ToString(),
               textBoxEventLocation.Text, thisDate, textBoxEventDescription.Text);
            
            bool noConflict = workEvent.checkConflict(eList);

            panelEvent.Visible = false;
            buttonAdd.BackColor = DefaultBackColor;
            buttonEdit.BackColor = DefaultBackColor;

            //Enable the main buttons
            buttonAdd.Enabled = true;
            buttonDelete.Enabled = true;
            buttonEdit.Enabled = true;
            buttonViewMonthly.Enabled = true;

            if (noConflict)
            {
                if (addEvent)
                {
                    Modifications.AddEvent(workEvent, currentUser.ClientID);
                    addEvent= false;
                }
                else
                {
                    
                    Modifications.EditEvent(workEvent, selectedEvent.getEventID());
                }

                ViewEvents(thisDate);
            }
            else
            {
                panelConflictError.Visible = true;
                panelEvent.Visible = false;
            }            
        }

        private void ButtonCancelEvent_Click(object sender, EventArgs e)
        {
            //Cancel Button
            panelEvent.Visible = false;
            buttonAdd.Enabled = true;
            buttonDelete.Enabled = true;
            buttonEdit.Enabled = true;
            buttonViewMonthly.Enabled = true;
            buttonAdd.BackColor = DefaultBackColor;
            buttonEdit.BackColor = DefaultBackColor;
            buttonSaveEvent.Visible = false;
            buttonCancelEvent.Visible = false;
            textBoxEventStartTime.Visible = true;
            comboBoxStartTime.Visible = false;
            textBoxEventEndTime.Visible = true;
            comboBoxEndTime.Visible = false;
            addEvent = false;

            if (eList.Count != 0 && listBoxEventsDaily.SelectedIndex >= 0)
            {
                ListBoxEventsDaily_SelectedIndexChanged(sender, e);
            }
        }

        private void ListBoxEventsDaily_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedEvent = (Event)eList[listBoxEventsDaily.SelectedIndex];
            panelEvent.Visible = true;
            textBoxEventTitle.Text = selectedEvent.getTitle();
            textBoxEventStartTime.Text = selectedEvent.getStartTime();
            textBoxEventEndTime.Text = selectedEvent.getEndTime();
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

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //Delete Event Button
            if (selectedEvent.getEventID() != 0)
            {
                buttonDelete.BackColor = Color.Red;
                panelEvent.Visible = false;
                panelDeleteConfirm.Visible = true;
            }
        }

        private void buttonCancelDelete_Click(object sender, EventArgs e)
        {
            //Cancel deleting event button
            buttonDelete.BackColor = DefaultBackColor;
            panelDeleteConfirm.Visible = false;
        }

        private void buttonConfirmDelete_Click(object sender, EventArgs e)
        {
            //Confirm deleting event button
            buttonDelete.BackColor = DefaultBackColor;
            panelDeleteConfirm.Visible = false;

            if (Modifications.DeleteEvent(selectedEvent))
            {
                ViewEvents(selectedEvent.getDate());
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            //Edit Event Button
            buttonEdit.BackColor = Color.Red;

            //Allow edits toEventForm();
            textBoxEventStartTime.Visible = false;
            comboBoxStartTime.Visible = true;

            int startTimeIndex = comboBoxEndTime.FindString(selectedEvent.getStartTime().Substring(0, 5));
            comboBoxStartTime.SelectedIndex = startTimeIndex;

            textBoxEventEndTime.Visible = false;
            comboBoxEndTime.Visible = true;

            int endTimeIndex = comboBoxEndTime.FindString(selectedEvent.getEndTime().Substring(0, 5));
            comboBoxEndTime.SelectedIndex = endTimeIndex;

            buttonSaveEvent.Visible = true;
            buttonCancelEvent.Visible = true;
            buttonAdd.Enabled = false;
            buttonDelete.Enabled = false;
            buttonEdit.Enabled = false;
            buttonViewMonthly.Enabled = false;
        }

        private void buttonContinueConflict_Click(object sender, EventArgs e)
        {
            //Continue after error button
            panelEvent.Visible = true;
            panelConflictError.Visible = false;
        }

        private void buttonCancelConfict_Click(object sender, EventArgs e)
        {
            //Cancel add event after error button
            panelEvent.Visible = false;
            panelConflictError.Visible = false;
            addEvent = false;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //Login button
            var userName = textBoxUserName.Text;
            var password = textBoxPassword.Text;

            currentUser = new Client(userName, password);

            if (currentUser.IsCredentialsGood)
            {
                panelLogin.Visible = false;
                monthCalendar1.Visible = true;
                labelEventsOn.Visible = true;
                listBoxEventsDaily.Visible = true;
                buttonAdd.Visible = true;
                buttonDelete.Visible = true;
                buttonEdit.Visible = true;
                buttonViewMonthly.Visible = true;

                if (!currentUser.IsManager) buttonTeamEvent.Visible = false;

                string todayDate = DateTime.Today.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
                ViewEvents(todayDate);
            }
            else
            {
                panelLoginError.Visible = true;
                textBoxPassword.Text= string.Empty;
            }
        }

        private void buttonTryAgainLogin_Click(object sender, EventArgs e)
        {
            //Try Again Button
            panelLoginError.Visible = false;
        }

        private void buttonViewMonthly_Click(object sender, EventArgs e)
        {
            //View Monthly Events button
            comboBoxMonth.Visible = true;
            string thisMonth = DateTime.Now.ToString("MMMM");
            string thisYear = DateTime.Now.ToString("yyyy");
            labelEventsOn.Text = "Events for the month of " + thisMonth + " " + thisYear;

            //Populate listBox1 with this month's events
            listBoxEventsDaily.Items.Clear();
            for (int i = 0; i < eList.Count; i++)
            {
                Event currentEvent = (Event)eList[i];
                String aString = currentEvent.getTitle();
                listBoxEventsDaily.Items.Add(aString);
            }
            //TODO: make this show a list of all events for the month, not just for whatever day is selected
        }

        private void comboBoxMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Select Month Drop-Down Menu
            string month = comboBoxMonth.SelectedItem.ToString();
            labelEventsOn.Text = "Events for the month of " + month + " 2023";

            //TODO: make label1 text display correct year from the dropdown list
            //TODO: add functionality of populating the listbox with the selected month's events
        }

        private void buttonTeamEvent_Click(object sender, EventArgs e)
        {
            //Set Up Team Event button
            buttonTeamEvent.Visible = false;
            panelEventTeam.Visible = true;
            panelEvent.Visible = false;
        }

        private void buttonSaveTeamEvent_Click(object sender, EventArgs e)
        {
            //Save Potential Time Slots Button
        }

        private void buttonCancelTeamEvent_Click(object sender, EventArgs e)
        {
            //Cancel Potential Time Slots Button
            panelEventTeam.Visible = false;
            buttonAdd.Enabled = true;
            buttonDelete.Enabled = true;
            buttonEdit.Enabled = true;
            buttonViewMonthly.Enabled = true;
            buttonAdd.BackColor = DefaultBackColor;
            buttonEdit.BackColor = DefaultBackColor;            
           
            if (eList.Count != 0 && listBoxEventsDaily.SelectedIndex >= 0)
            {
                ListBoxEventsDaily_SelectedIndexChanged(sender, e);
            }
        }

        private void emptyEventForm()
        {
            panelEvent.Visible = true;
            textBoxEventTitle.Text = "";
            textBoxEventStartTime.Text = "";
            textBoxEventEndTime.Text = "";
            textBoxEventLocation.Text = "";
            textBoxEventDescription.Text = "";
        }

        private void ViewEvents (string date)
        {
            labelEventsOn.Text = "Events on " + date;
            eList = Event.getEventList(date, currentUser.ClientID);
            
            listBoxEventsDaily.Items.Clear();

            for (int i = 0; i < eList.Count; i++)
            {
                Event currentEvent = (Event)eList[i];
                string aString = currentEvent.getStartTime() + "  " + currentEvent.getTitle();
                listBoxEventsDaily.Items.Add(aString);
            }
        }
    }
}
