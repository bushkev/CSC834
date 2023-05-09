﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace Individual_Project
{
    public partial class FormMain : Form
    {
        ArrayList eList;
        Client currentUser;
        Event selectedEvent = new Event();
        bool addEvent = false;
        List <int> clientIdsForTeamEvent; 
        List <TeamMember> membersToChooseList;

        public FormMain()
        {
            InitializeComponent();
            initializeTimeSections();
            initializeMonthSections();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            //Add Event Button
            buttonAdd.BackColor = Color.Red;
            addEvent = true;
            EmptyEventForm();

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
            
            bool noConflict = workEvent.CheckConflict(eList);

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
                    addEvent = false;
                }
                else
                {
                    Modifications.EditEvent(workEvent, selectedEvent.EventID);
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
            textBoxEventTitle.Text = selectedEvent.Title;
            textBoxEventStartTime.Text = selectedEvent.StartTime;
            textBoxEventEndTime.Text = selectedEvent.EndTime;
            textBoxEventLocation.Text = selectedEvent.Location;
            textBoxEventDescription.Text = selectedEvent.Description;
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
            if (selectedEvent.EventID != 0)
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
            buttonDeleteTeamEvent.BackColor = DefaultBackColor;
            panelDeleteConfirm.Visible = false;
        }

        private void buttonConfirmDelete_Click(object sender, EventArgs e)
        {
            //Confirm deleting event button
            buttonDelete.BackColor = DefaultBackColor;
            panelDeleteConfirm.Visible = false;
            bool success = false;

            if (selectedEvent.TeamEventID != null)
            {
                success = Modifications.DeleteTeamEvent(selectedEvent.TeamEventID);
            }
            else
            {
                success = Modifications.DeleteEvent(selectedEvent.EventID);
            }
            if (success)
            {
                ViewEvents(selectedEvent.Date);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            //Edit Event Button
            buttonEdit.BackColor = Color.Red;

            //Allow edits toEventForm();
            textBoxEventStartTime.Visible = false;
            comboBoxStartTime.Visible = true;

            int startTimeIndex = comboBoxEndTime.FindString(selectedEvent.StartTime.Substring(0, 5));
            comboBoxStartTime.SelectedIndex = startTimeIndex;

            textBoxEventEndTime.Visible = false;
            comboBoxEndTime.Visible = true;

            int endTimeIndex = comboBoxEndTime.FindString(selectedEvent.EndTime.Substring(0, 5));
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

                if (currentUser.IsManager)
                {
                    buttonTeamEvent.Visible = true;
                    buttonDeleteTeamEvent.Visible = true;
                }

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
            String thisDate = DateTime.Today.ToString("yyyy-MM-dd");

            ViewEvents(thisDate, true);
        }

        private void comboBoxMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Select Month Drop-Down Menu
            string selection = comboBoxMonth.SelectedItem.ToString();
            string month = selection.Substring(7); 
            var monthNumber = DateTime.ParseExact(month, "MMMM", CultureInfo.CurrentCulture).Month;
            string year = selection.Substring(0,4);
            string thisDate = $"{year}-{monthNumber:d2}-01)";

            ViewEvents(thisDate, true);
        }

        private void buttonTeamEvent_Click(object sender, EventArgs e)
        {
            //Add Team Event button
            //TODO: maybe set up team event box to be seperate from event add. This will mean to move the button, and add the text box and labels for description, location, and title.
            buttonTimeSlots.Enabled= false;
            panelEventTeam.Visible = true;
            panelEvent.Visible = false;
            textBoxEventTitle.Text = selectedEvent.Title;
            textBoxEventLocation.Text = selectedEvent.Location;
            textBoxEventDescription.Text = selectedEvent.Description;
            membersToChooseList = new List<TeamMember>();
            clientIdsForTeamEvent = new List<int>();

            foreach (var member in currentUser.TeamMembers)
            {
                listBoxMembersToAdd.Items.Add(member.FullName);
                membersToChooseList.Add(member);
            }
        }

        private void buttonDeleteTeamEvent_Click(object sender, EventArgs e)
        {
            //Delete Team Event button
            if (selectedEvent.EventID != 0)
            {
                buttonDeleteTeamEvent.BackColor = Color.Red;
                panelEvent.Visible = false;
                panelDeleteConfirm.Visible = true;
            }
        }

        private void buttonSaveTeamEvent_Click(object sender, EventArgs e)
        {
            //Save Potential Time Slots Button
            string selectedTime = listBoxTeamTimeAvail.SelectedItem.ToString();

            string startTime = selectedTime.Substring(0, 5);
            string endTime = selectedTime.Substring(7);

            //TODO: figure out how we want to create the event info.
            //Modifications.AddTeamEvent(workEvent, currentUser.TeamID, clientIdsForTeamEvent);
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
            panelTimeSlotChoice.Visible = false;

            if (eList.Count != 0 && listBoxEventsDaily.SelectedIndex >= 0)
            {
                ListBoxEventsDaily_SelectedIndexChanged(sender, e);
            }

            CancelTeamAdd();
        }

        private void buttonAddMembers_Click(object sender, EventArgs e)
        {
            buttonTimeSlots.Enabled = true;
            panelMembersToAdd.Visible= true;
            panelEventTeam.Visible = false;
            listBoxMembersToAdd.Items.Clear();

            if (membersToChooseList.Count == 0)
            {
                listBoxMembersToAdd.Enabled = false;
            }
            else
            {
                foreach (var member in membersToChooseList)
                {
                    listBoxMembersToAdd.Items.Add(member.FullName);
                }
            }
        }

        private void buttonTimeSlots_Click(object sender, EventArgs e)
        {
            panelEventTeam.Visible = false;
            panelTimeSlotChoice.Visible = true;
            listBoxMembersToAdd.Enabled = true;

            string date = dateTimePickerTeamEvent.Value.ToString();

            var busyTimes = Event.GetTeamBusyTimes(date, clientIdsForTeamEvent);

            GetAvailableTimes(busyTimes);

        }

        private void listBoxMembersToAdd_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = listBoxMembersToAdd.SelectedIndex;
            var item = listBoxMembersToAdd.SelectedItem;

            clientIdsForTeamEvent.Add(membersToChooseList[index].clientID);
            membersToChooseList.RemoveAt(index);

            listBoxTeamMembersAdded.Items.Add(item);

            panelMembersToAdd.Visible = false;
            panelEventTeam.Visible = true;
        }

        private void buttonCancelMemberAdd_Click(object sender, EventArgs e)
        {
            panelMembersToAdd.Visible = false;
            panelEventTeam.Visible = true;
        }

        private void initializeTimeSections()
        {
            for (int i = 0; i < 24; i++)
            {
                for (int j = 0;j <= 30; j += 30)
                {
                    comboBoxStartTime.Items.Add($"{i:D2}:{j:D2}");
                    comboBoxEndTime.Items.Add($"{i:D2}:{j:D2}");
                    comboBoxDurationTeamEvent.Items.Add($"{i:D2}:{j:D2}");
                }
            }
            comboBoxDurationTeamEvent.Items.RemoveAt(0);
            comboBoxDurationTeamEvent.SelectedIndex= 0;
        }

        // Adds months for last year, this year and next year to comboBox.
        private void initializeMonthSections()
        {
            for (int i = -1; i <= 1; i++)
            {
                for(int j = 1; j <= 12; j++)
                {
                    var month = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(j);
                    comboBoxMonth.Items.Add($"{DateTime.Today.Year + i} - {month}");
                }
            }
        }

        private void ViewEvents(string date, bool isMonthly = false)
        {
            listBoxEventsDaily.Items.Clear();

            if (isMonthly)
            {
                int monthNumber = int.Parse(date.Substring(5, 2));
                string month = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(monthNumber);
                int year = int.Parse(date.Substring(0, 4));

                labelEventsOn.Text = $"Events for the month of {month} {year}";
                eList = Event.GetMonthlyEventList(monthNumber, currentUser.ClientID);
            }
            else
            {
                labelEventsOn.Text = "Events on " + date;
                eList = Event.GetEventList(date, currentUser.ClientID);
            }

            for (int i = 0; i < eList.Count; i++)
            {
                Event currentEvent = (Event)eList[i];

                string aString = "";
                if (isMonthly) aString += $"{currentEvent.Day} at ";
                aString += $"{currentEvent.StartTime} - {currentEvent.Title}";

                listBoxEventsDaily.Items.Add(aString);
            }
        }

        private void EmptyEventForm()
        {
            panelEvent.Visible = true;
            textBoxEventTitle.Text = "";
            textBoxEventStartTime.Text = "";
            textBoxEventEndTime.Text = "";
            textBoxEventLocation.Text = "";
            textBoxEventDescription.Text = "";
        }

        private void CancelTeamAdd()
        {
            clientIdsForTeamEvent.Clear();
            membersToChooseList.Clear();

            listBoxMembersToAdd.Items.Clear();
            listBoxTeamMembersAdded.Items.Clear();
            listBoxMembersToAdd.Enabled = true;
        }

        private void GetAvailableTimes(List<Tuple<string, string>> busyTimes)
        {
            string duration = comboBoxDurationTeamEvent.SelectedItem.ToString();
            var split = duration.Split(':');
            int hours = int.Parse(split[0]);
            int minutes = int.Parse(split[1]);

            for (int i = 0; i < 24 - hours; i++)
            {
                for (int j = 0; j <=30; j += 30)
                {
                    bool addToBox = true;
                    string startTime = $"{i:D2}:{j:D2}";
                    string endTime;

                    if (j != 0 && minutes != 0)
                    {
                        endTime = $"{i + hours + 1:D2}:00";
                    }
                    else
                    {
                        endTime = $"{i + hours:D2}:{j + minutes:D2}";
                    }
                    
                    foreach (var tuple in busyTimes)
                    {
                        string busyStart = tuple.Item1;
                        string busyEnd = tuple.Item2;
                        if (endTime.CompareTo(busyStart) >= 0 || startTime.CompareTo(busyEnd) <= 0)
                            continue;
                        else addToBox = false;
                    }
                    if (addToBox)
                        listBoxTeamTimeAvail.Items.Add($"{startTime} - {endTime}");
                }
            }
        }
    }
}
