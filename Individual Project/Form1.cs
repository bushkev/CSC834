using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Individual_Project
{
    public partial class Form1 : Form
    {
        ArrayList eList;
        public Form1()
        {
            InitializeComponent();
            DateTime thisDay = DateTime.Today;
            String dateString = thisDay.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
            //dateString = dateString.Substring(0, 4) + "-" + dateString.Substring(4, 2) + "-" + dateString.Substring(6);
            //Console.Out.WriteLine("dateString: " + dateString);
            label1.Text = "Events on " + dateString;
            eList = Event.getEventList(dateString);
            button6.Visible = false;
            button7.Visible = false;
            //ListBox1_SelectedIndexChanged();
            for (int i = 0; i < eList.Count; i++)
            {
                Event currentEvent = (Event)eList[i];
                String aString = currentEvent.getStartTime() + "  " + currentEvent.getTitle();
                listBox1.Items.Add(aString);
            }
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
            /*
            panel1.Visible = true;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            */
            emptyEventForm();
            textBox2.Visible = false;
            comboBox1.Visible = true;
            comboBox1.SelectedIndex = 0;
            textBox3.Visible = false;
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
            Event newEvent = new Event();

            newEvent.updateEventValue(textBox1.Text, comboBox1.SelectedItem.ToString(), textBox3.Text,
               textBox4.Text, textBox5.Text, thisDate, textBox7.Text);
            bool noConflict = newEvent.checkConflict(eList);
            Console.WriteLine("Conflict = " + noConflict);
            panel1.Visible = false;
            button1.BackColor = DefaultBackColor;
            button4.BackColor = DefaultBackColor;

            //Enable the 5 main buttons
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;

            //TODO: add functionality for saving the event to the database and checking for conflicts

            //For testing purposes enable error panel
            panel3.Visible = true;
            panel1.Visible = false;
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        //private void ListBox1_SelectedIndexChanged()
        {
            Event currentEvent = (Event)eList[listBox1.SelectedIndex];
            panel1.Visible = true;
            textBox1.Text = currentEvent.getTitle();
            textBox2.Text = currentEvent.getStartTime();
            textBox3.Text = currentEvent.getEndTime();
            textBox4.Text = currentEvent.getReminder();
            textBox5.Text = currentEvent.getLocation();
            textBox7.Text = currentEvent.getDescription();
        }

        private void MonthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            //Turn off panel 1 if selecting a different date
            panel1.Visible = false;
            //String thisDate = monthCalendar1.SelectionRange.Start.ToShortDateString();
            String thisDate = monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd");
            label1.Text = "Events on " + thisDate;
            //label1.BackColor = Color.Yellow;
            eList = Event.getEventList(thisDate);
            button6.Visible = false;
            button7.Visible = false;
            //ListBox1_SelectedIndexChanged();
            listBox1.Items.Clear();
            for (int i = 0; i < eList.Count; i++)
            {
                Event currentEvent = (Event)eList[i];
                String aString = currentEvent.getStartTime() + "  " + currentEvent.getEndTime() + "  " + currentEvent.getTitle();
                listBox1.Items.Add(aString);
            }
        }

        private void emptyEventForm()
        {
            panel1.Visible = true;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
        }
        private void Button7_Click(object sender, EventArgs e)
        {
            //Cancel Button
            panel1.Visible = false;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button1.BackColor = DefaultBackColor;
            button4.BackColor = DefaultBackColor;
            button6.Visible = false;
            button7.Visible = false;
            textBox2.Visible = true;
            comboBox1.Visible = false;
            textBox3.Visible = true;
            comboBox2.Visible = false;
            if (eList.Count != 0)
            {
                ListBox1_SelectedIndexChanged(sender, e);
            }
            else
            {
                emptyEventForm();
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
            button2.BackColor = Color.Red;
            panel1.Visible = false;
            panel2.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Cancel deleting event button
            button2.BackColor = DefaultBackColor;
            panel2.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //Confirm deleting event button
            button2.BackColor = DefaultBackColor;
            panel2.Visible = false;
            //TODO: add functionality for deleting an event
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //Cancel add event after error button
            panel1.Visible = false;
            panel3.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Edit Event Button
            button4.BackColor = Color.Red;

            //Allow edits toEventForm();
            emptyEventForm();
            textBox2.Visible = false;
            comboBox1.Visible = true;
            comboBox1.SelectedIndex = 0;
            textBox3.Visible = false;
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
            panel1.Visible = true;
            panel3.Visible = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //Login button
            panel4.Visible = false;
            monthCalendar1.Visible = true;
            label1.Visible = true;
            listBox1.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
            button4.Visible = true;
            button5.Visible = true;

            //TODO: add functionality for checking password credentials
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            //Try Again Button
            panel5.Visible = false;
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
            panel6.Visible = true;
            panel1.Visible = false;
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            //Find Possible Time Slots Button            
            panel7.Visible = true;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            //Cancel Potential Time Slots Button
            panel7.Visible = false;
            panel6.Visible = false;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button1.BackColor = DefaultBackColor;
            button4.BackColor = DefaultBackColor;            
           
            if (eList.Count != 0)
            {
                ListBox1_SelectedIndexChanged(sender, e);
            }
            else
            {
                emptyEventForm();
            }
        }
    }
}
