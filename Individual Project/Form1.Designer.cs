namespace Individual_Project
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panelEvent = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button14 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.textBoxEventDescription = new System.Windows.Forms.TextBox();
            this.textBoxEventAttendees = new System.Windows.Forms.TextBox();
            this.textBoxEventLocation = new System.Windows.Forms.TextBox();
            this.textBoxEventRemind = new System.Windows.Forms.TextBox();
            this.textBoxEventEndTime = new System.Windows.Forms.TextBox();
            this.textBoxEventStartTime = new System.Windows.Forms.TextBox();
            this.textBoxEventTitle = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.panelDeleteConfirm = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.panelConflictError = new System.Windows.Forms.Panel();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.panelLoginError = new System.Windows.Forms.Panel();
            this.button13 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.button12 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.panelEventTeam = new System.Windows.Forms.Panel();
            this.panelTimeSlotChoice = new System.Windows.Forms.Panel();
            this.button18 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label19 = new System.Windows.Forms.Label();
            this.button16 = new System.Windows.Forms.Button();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.button15 = new System.Windows.Forms.Button();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panelEvent.SuspendLayout();
            this.panelDeleteConfirm.SuspendLayout();
            this.panelConflictError.SuspendLayout();
            this.panelLogin.SuspendLayout();
            this.panelLoginError.SuspendLayout();
            this.panelEventTeam.SuspendLayout();
            this.panelTimeSlotChoice.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(9, 6);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 9;
            this.monthCalendar1.Visible = false;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.MonthCalendar1_DateChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(276, 43);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(207, 368);
            this.listBox1.TabIndex = 1;
            this.listBox1.Visible = false;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(276, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Events on 02/03/2020";
            this.label1.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add Event";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 282);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Delete Event";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 340);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "View Event";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 311);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(116, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Edit Event";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 369);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(116, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "View Monthly Events";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panelEvent
            // 
            this.panelEvent.Controls.Add(this.comboBox2);
            this.panelEvent.Controls.Add(this.button14);
            this.panelEvent.Controls.Add(this.comboBox1);
            this.panelEvent.Controls.Add(this.button7);
            this.panelEvent.Controls.Add(this.button6);
            this.panelEvent.Controls.Add(this.textBoxEventDescription);
            this.panelEvent.Controls.Add(this.textBoxEventAttendees);
            this.panelEvent.Controls.Add(this.textBoxEventLocation);
            this.panelEvent.Controls.Add(this.textBoxEventRemind);
            this.panelEvent.Controls.Add(this.textBoxEventEndTime);
            this.panelEvent.Controls.Add(this.textBoxEventStartTime);
            this.panelEvent.Controls.Add(this.textBoxEventTitle);
            this.panelEvent.Controls.Add(this.label8);
            this.panelEvent.Controls.Add(this.label7);
            this.panelEvent.Controls.Add(this.label6);
            this.panelEvent.Controls.Add(this.label5);
            this.panelEvent.Controls.Add(this.label4);
            this.panelEvent.Controls.Add(this.label3);
            this.panelEvent.Controls.Add(this.label2);
            this.panelEvent.Location = new System.Drawing.Point(537, 43);
            this.panelEvent.Name = "panelEvent";
            this.panelEvent.Size = new System.Drawing.Size(334, 468);
            this.panelEvent.TabIndex = 8;
            this.panelEvent.Visible = false;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(97, 58);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(234, 21);
            this.comboBox2.TabIndex = 15;
            this.comboBox2.Visible = false;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(81, 432);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(190, 23);
            this.button14.TabIndex = 21;
            this.button14.Text = "Set Up Team Event";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(97, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(234, 21);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.Visible = false;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(192, 400);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(116, 23);
            this.button7.TabIndex = 14;
            this.button7.Text = "Cancel";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(34, 400);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(116, 23);
            this.button6.TabIndex = 9;
            this.button6.Text = "Save";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // textBoxEventDescription
            // 
            this.textBoxEventDescription.Location = new System.Drawing.Point(21, 193);
            this.textBoxEventDescription.Multiline = true;
            this.textBoxEventDescription.Name = "textBoxEventDescription";
            this.textBoxEventDescription.Size = new System.Drawing.Size(305, 202);
            this.textBoxEventDescription.TabIndex = 13;
            // 
            // textBoxEventAttendees
            // 
            this.textBoxEventAttendees.Location = new System.Drawing.Point(97, 136);
            this.textBoxEventAttendees.Name = "textBoxEventAttendees";
            this.textBoxEventAttendees.Size = new System.Drawing.Size(190, 20);
            this.textBoxEventAttendees.TabIndex = 12;
            // 
            // textBoxEventLocation
            // 
            this.textBoxEventLocation.Location = new System.Drawing.Point(97, 110);
            this.textBoxEventLocation.Name = "textBoxEventLocation";
            this.textBoxEventLocation.Size = new System.Drawing.Size(190, 20);
            this.textBoxEventLocation.TabIndex = 11;
            // 
            // textBoxEventRemind
            // 
            this.textBoxEventRemind.Location = new System.Drawing.Point(97, 84);
            this.textBoxEventRemind.Name = "textBoxEventRemind";
            this.textBoxEventRemind.Size = new System.Drawing.Size(190, 20);
            this.textBoxEventRemind.TabIndex = 10;
            // 
            // textBoxEventEndTime
            // 
            this.textBoxEventEndTime.Location = new System.Drawing.Point(97, 58);
            this.textBoxEventEndTime.Name = "textBoxEventEndTime";
            this.textBoxEventEndTime.Size = new System.Drawing.Size(190, 20);
            this.textBoxEventEndTime.TabIndex = 9;
            // 
            // textBoxEventStartTime
            // 
            this.textBoxEventStartTime.Location = new System.Drawing.Point(97, 32);
            this.textBoxEventStartTime.Name = "textBoxEventStartTime";
            this.textBoxEventStartTime.Size = new System.Drawing.Size(190, 20);
            this.textBoxEventStartTime.TabIndex = 8;
            // 
            // textBoxEventTitle
            // 
            this.textBoxEventTitle.Location = new System.Drawing.Point(97, 6);
            this.textBoxEventTitle.Name = "textBoxEventTitle";
            this.textBoxEventTitle.Size = new System.Drawing.Size(190, 20);
            this.textBoxEventTitle.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Reminder";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Description";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Attendees";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Location";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ending Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Starting Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Title";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(9, 210);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(190, 17);
            this.listBox2.TabIndex = 15;
            this.listBox2.Visible = false;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // panelDeleteConfirm
            // 
            this.panelDeleteConfirm.Controls.Add(this.button9);
            this.panelDeleteConfirm.Controls.Add(this.button8);
            this.panelDeleteConfirm.Controls.Add(this.label9);
            this.panelDeleteConfirm.Location = new System.Drawing.Point(537, 43);
            this.panelDeleteConfirm.Name = "panelDeleteConfirm";
            this.panelDeleteConfirm.Size = new System.Drawing.Size(334, 426);
            this.panelDeleteConfirm.TabIndex = 16;
            this.panelDeleteConfirm.Visible = false;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(119, 55);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 3;
            this.button9.Text = "Confirm";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(119, 87);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 2;
            this.button8.Text = "Cancel";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(51, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(211, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Are you sure you want to delete this event?";
            // 
            // panelConflictError
            // 
            this.panelConflictError.Controls.Add(this.button11);
            this.panelConflictError.Controls.Add(this.button10);
            this.panelConflictError.Controls.Add(this.label11);
            this.panelConflictError.Controls.Add(this.label10);
            this.panelConflictError.Location = new System.Drawing.Point(529, 46);
            this.panelConflictError.Name = "panelConflictError";
            this.panelConflictError.Size = new System.Drawing.Size(334, 426);
            this.panelConflictError.TabIndex = 17;
            this.panelConflictError.Visible = false;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(119, 143);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 3;
            this.button11.Text = "Continue";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(119, 107);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 2;
            this.button10.Text = "Cancel";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(26, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(250, 16);
            this.label11.TabIndex = 1;
            this.label11.Text = "This event conflicts with an existing event.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(122, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "ERROR!";
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.panelLoginError);
            this.panelLogin.Controls.Add(this.label14);
            this.panelLogin.Controls.Add(this.label13);
            this.panelLogin.Controls.Add(this.label12);
            this.panelLogin.Controls.Add(this.textBoxPassword);
            this.panelLogin.Controls.Add(this.textBoxUserName);
            this.panelLogin.Controls.Add(this.button12);
            this.panelLogin.Location = new System.Drawing.Point(267, 146);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(375, 270);
            this.panelLogin.TabIndex = 18;
            // 
            // panelLoginError
            // 
            this.panelLoginError.Controls.Add(this.button13);
            this.panelLoginError.Controls.Add(this.label16);
            this.panelLoginError.Controls.Add(this.label15);
            this.panelLoginError.Location = new System.Drawing.Point(37, 43);
            this.panelLoginError.Name = "panelLoginError";
            this.panelLoginError.Size = new System.Drawing.Size(299, 187);
            this.panelLoginError.TabIndex = 19;
            this.panelLoginError.Visible = false;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(106, 107);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 23);
            this.button13.TabIndex = 5;
            this.button13.Text = "Try Again";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(3, 69);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(272, 16);
            this.label16.TabIndex = 4;
            this.label16.Text = "Either the username or password is incorrect.";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(107, 30);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 17);
            this.label15.TabIndex = 4;
            this.label15.Text = "ERROR!";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(54, 59);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(266, 16);
            this.label14.TabIndex = 5;
            this.label14.Text = "Please enter your username and password.";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.854546F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(70, 131);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "Password";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.854546F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(70, 97);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Username";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.AcceptsReturn = true;
            this.textBoxPassword.Location = new System.Drawing.Point(141, 128);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxPassword.TabIndex = 2;
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.AcceptsReturn = true;
            this.textBoxUserName.Location = new System.Drawing.Point(141, 94);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(100, 20);
            this.textBoxUserName.TabIndex = 1;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(150, 166);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 23);
            this.button12.TabIndex = 0;
            this.button12.Text = "Login";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "2023",
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December",
            "",
            "2024",
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.comboBox3.Location = new System.Drawing.Point(500, 6);
            this.comboBox3.MaxDropDownItems = 12;
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 20;
            this.comboBox3.Text = "Select Month";
            this.comboBox3.Visible = false;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(98, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(114, 16);
            this.label17.TabIndex = 21;
            this.label17.Text = "Team Event Form";
            // 
            // panelEventTeam
            // 
            this.panelEventTeam.Controls.Add(this.panelTimeSlotChoice);
            this.panelEventTeam.Controls.Add(this.button16);
            this.panelEventTeam.Controls.Add(this.listBox3);
            this.panelEventTeam.Controls.Add(this.button15);
            this.panelEventTeam.Controls.Add(this.comboBox4);
            this.panelEventTeam.Controls.Add(this.label18);
            this.panelEventTeam.Controls.Add(this.dateTimePicker1);
            this.panelEventTeam.Controls.Add(this.label17);
            this.panelEventTeam.Location = new System.Drawing.Point(555, 33);
            this.panelEventTeam.Name = "panelEventTeam";
            this.panelEventTeam.Size = new System.Drawing.Size(338, 475);
            this.panelEventTeam.TabIndex = 22;
            this.panelEventTeam.Visible = false;
            // 
            // panelTimeSlotChoice
            // 
            this.panelTimeSlotChoice.Controls.Add(this.button18);
            this.panelTimeSlotChoice.Controls.Add(this.button17);
            this.panelTimeSlotChoice.Controls.Add(this.checkedListBox1);
            this.panelTimeSlotChoice.Controls.Add(this.label19);
            this.panelTimeSlotChoice.Location = new System.Drawing.Point(21, 3);
            this.panelTimeSlotChoice.Name = "panelTimeSlotChoice";
            this.panelTimeSlotChoice.Size = new System.Drawing.Size(292, 383);
            this.panelTimeSlotChoice.TabIndex = 23;
            this.panelTimeSlotChoice.Visible = false;
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(144, 206);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(75, 23);
            this.button18.TabIndex = 3;
            this.button18.Text = "Cancel";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(47, 206);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(75, 23);
            this.button17.TabIndex = 2;
            this.button17.Text = "Save";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "08:00 - 10:00",
            "12:00 - 14:00",
            "14:00 - 16:00"});
            this.checkedListBox1.Location = new System.Drawing.Point(85, 36);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(102, 139);
            this.checkedListBox1.TabIndex = 1;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(75, 7);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(127, 16);
            this.label19.TabIndex = 0;
            this.label19.Text = "Possible Time Slots";
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(79, 360);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(165, 23);
            this.button16.TabIndex = 27;
            this.button16.Text = "Find Possible Time Slots";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Items.AddRange(new object[] {
            "Team Member 1",
            "Team Member 2",
            "Team Member 3"});
            this.listBox3.Location = new System.Drawing.Point(79, 183);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(165, 147);
            this.listBox3.TabIndex = 26;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(101, 139);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(117, 23);
            this.button15.TabIndex = 25;
            this.button15.Text = "Add Member";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "15 minutes",
            "30 minutes",
            "1 hour",
            "2 hours"});
            this.comboBox4.Location = new System.Drawing.Point(142, 89);
            this.comboBox4.MaxDropDownItems = 4;
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 24;
            this.comboBox4.Text = "15 minutes";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(60, 92);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(47, 13);
            this.label18.TabIndex = 23;
            this.label18.Text = "Duration";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(63, 45);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 558);
            this.Controls.Add(this.panelEvent);
            this.Controls.Add(this.panelEventTeam);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.panelDeleteConfirm);
            this.Controls.Add(this.panelConflictError);
            this.Name = "Form1";
            this.Text = "Personal Calendar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelEvent.ResumeLayout(false);
            this.panelEvent.PerformLayout();
            this.panelDeleteConfirm.ResumeLayout(false);
            this.panelDeleteConfirm.PerformLayout();
            this.panelConflictError.ResumeLayout(false);
            this.panelConflictError.PerformLayout();
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.panelLoginError.ResumeLayout(false);
            this.panelLoginError.PerformLayout();
            this.panelEventTeam.ResumeLayout(false);
            this.panelEventTeam.PerformLayout();
            this.panelTimeSlotChoice.ResumeLayout(false);
            this.panelTimeSlotChoice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panelEvent;
        private System.Windows.Forms.TextBox textBoxEventDescription;
        private System.Windows.Forms.TextBox textBoxEventAttendees;
        private System.Windows.Forms.TextBox textBoxEventLocation;
        private System.Windows.Forms.TextBox textBoxEventRemind;
        private System.Windows.Forms.TextBox textBoxEventStartTime;
        private System.Windows.Forms.TextBox textBoxEventTitle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.TextBox textBoxEventEndTime;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Panel panelDeleteConfirm;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Panel panelConflictError;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panelLoginError;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panelEventTeam;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Panel panelTimeSlotChoice;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button17;
    }
}

