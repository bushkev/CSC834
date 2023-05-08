namespace Individual_Project
{
    partial class FormMain
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
            this.listBoxEventsDaily = new System.Windows.Forms.ListBox();
            this.labelEventsOn = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonViewMonthly = new System.Windows.Forms.Button();
            this.panelEvent = new System.Windows.Forms.Panel();
            this.labelEndTime = new System.Windows.Forms.Label();
            this.comboBoxEndTime = new System.Windows.Forms.ComboBox();
            this.buttonTeamEvent = new System.Windows.Forms.Button();
            this.comboBoxStartTime = new System.Windows.Forms.ComboBox();
            this.buttonCancelEvent = new System.Windows.Forms.Button();
            this.buttonSaveEvent = new System.Windows.Forms.Button();
            this.textBoxEventDescription = new System.Windows.Forms.TextBox();
            this.textBoxEventLocation = new System.Windows.Forms.TextBox();
            this.textBoxEventEndTime = new System.Windows.Forms.TextBox();
            this.textBoxEventStartTime = new System.Windows.Forms.TextBox();
            this.textBoxEventTitle = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelLocation = new System.Windows.Forms.Label();
            this.labelStartTime = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelConflictError = new System.Windows.Forms.Panel();
            this.buttonContinueConflict = new System.Windows.Forms.Button();
            this.buttonCancelConfict = new System.Windows.Forms.Button();
            this.labelConflictErrorMessage = new System.Windows.Forms.Label();
            this.labelConflictErrorTitle = new System.Windows.Forms.Label();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.panelLoginError = new System.Windows.Forms.Panel();
            this.buttonTryAgainLogin = new System.Windows.Forms.Button();
            this.labelErrorMessage = new System.Windows.Forms.Label();
            this.labelLoginErrorTitle = new System.Windows.Forms.Label();
            this.labelEnterCreds = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.comboBoxMonth = new System.Windows.Forms.ComboBox();
            this.labelDeleteConfirm = new System.Windows.Forms.Label();
            this.buttonCancelDelete = new System.Windows.Forms.Button();
            this.panelEventTeam = new System.Windows.Forms.Panel();
            this.buttonTimeSlots = new System.Windows.Forms.Button();
            this.buttonAddMembers = new System.Windows.Forms.Button();
            this.listBoxTeamMembersAdded = new System.Windows.Forms.ListBox();
            this.comboBoxDurationTeamEvent = new System.Windows.Forms.ComboBox();
            this.labelDuration = new System.Windows.Forms.Label();
            this.dateTimePickerTeamEvent = new System.Windows.Forms.DateTimePicker();
            this.labelEventForm = new System.Windows.Forms.Label();
            this.buttonCancelTeamEvent = new System.Windows.Forms.Button();
            this.buttonSaveTeamEvent = new System.Windows.Forms.Button();
            this.buttonConfirmDelete = new System.Windows.Forms.Button();
            this.panelDeleteConfirm = new System.Windows.Forms.Panel();
            this.panelTimeSlotChoice = new System.Windows.Forms.Panel();
            this.labelTimeSlotTitle = new System.Windows.Forms.Label();
            this.listBoxMembersToAdd = new System.Windows.Forms.ListBox();
            this.panelMembersToAdd = new System.Windows.Forms.Panel();
            this.buttonCancelMemberAdd = new System.Windows.Forms.Button();
            this.labelChooseMembersToAdd = new System.Windows.Forms.Label();
            this.listBoxTeamTimeAvail = new System.Windows.Forms.ListBox();
            this.buttonDeleteTeamEvent = new System.Windows.Forms.Button();
            this.panelEvent.SuspendLayout();
            this.panelConflictError.SuspendLayout();
            this.panelLogin.SuspendLayout();
            this.panelLoginError.SuspendLayout();
            this.panelEventTeam.SuspendLayout();
            this.panelDeleteConfirm.SuspendLayout();
            this.panelTimeSlotChoice.SuspendLayout();
            this.panelMembersToAdd.SuspendLayout();
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
            // listBoxEventsDaily
            // 
            this.listBoxEventsDaily.FormattingEnabled = true;
            this.listBoxEventsDaily.Location = new System.Drawing.Point(276, 43);
            this.listBoxEventsDaily.Name = "listBoxEventsDaily";
            this.listBoxEventsDaily.Size = new System.Drawing.Size(207, 368);
            this.listBoxEventsDaily.TabIndex = 1;
            this.listBoxEventsDaily.Visible = false;
            this.listBoxEventsDaily.SelectedIndexChanged += new System.EventHandler(this.ListBoxEventsDaily_SelectedIndexChanged);
            // 
            // labelEventsOn
            // 
            this.labelEventsOn.AutoSize = true;
            this.labelEventsOn.Location = new System.Drawing.Point(276, 9);
            this.labelEventsOn.Name = "labelEventsOn";
            this.labelEventsOn.Size = new System.Drawing.Size(116, 13);
            this.labelEventsOn.TabIndex = 2;
            this.labelEventsOn.Text = "Events on 02/03/2020";
            this.labelEventsOn.Visible = false;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(9, 195);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(227, 40);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Add Event";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Visible = false;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(9, 241);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(227, 40);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Delete Event";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Visible = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(9, 287);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(227, 40);
            this.buttonEdit.TabIndex = 6;
            this.buttonEdit.Text = "Edit Event";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Visible = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonViewMonthly
            // 
            this.buttonViewMonthly.Location = new System.Drawing.Point(9, 333);
            this.buttonViewMonthly.Name = "buttonViewMonthly";
            this.buttonViewMonthly.Size = new System.Drawing.Size(227, 40);
            this.buttonViewMonthly.TabIndex = 7;
            this.buttonViewMonthly.Text = "View Monthly Events";
            this.buttonViewMonthly.UseVisualStyleBackColor = true;
            this.buttonViewMonthly.Visible = false;
            this.buttonViewMonthly.Click += new System.EventHandler(this.buttonViewMonthly_Click);
            // 
            // panelEvent
            // 
            this.panelEvent.Controls.Add(this.labelEndTime);
            this.panelEvent.Controls.Add(this.comboBoxEndTime);
            this.panelEvent.Controls.Add(this.comboBoxStartTime);
            this.panelEvent.Controls.Add(this.buttonCancelEvent);
            this.panelEvent.Controls.Add(this.buttonSaveEvent);
            this.panelEvent.Controls.Add(this.textBoxEventDescription);
            this.panelEvent.Controls.Add(this.textBoxEventLocation);
            this.panelEvent.Controls.Add(this.textBoxEventEndTime);
            this.panelEvent.Controls.Add(this.textBoxEventStartTime);
            this.panelEvent.Controls.Add(this.textBoxEventTitle);
            this.panelEvent.Controls.Add(this.labelDescription);
            this.panelEvent.Controls.Add(this.labelLocation);
            this.panelEvent.Controls.Add(this.labelStartTime);
            this.panelEvent.Controls.Add(this.labelTitle);
            this.panelEvent.Location = new System.Drawing.Point(553, 58);
            this.panelEvent.Name = "panelEvent";
            this.panelEvent.Size = new System.Drawing.Size(334, 389);
            this.panelEvent.TabIndex = 8;
            this.panelEvent.Visible = false;
            // 
            // labelEndTime
            // 
            this.labelEndTime.AutoSize = true;
            this.labelEndTime.Location = new System.Drawing.Point(15, 61);
            this.labelEndTime.Name = "labelEndTime";
            this.labelEndTime.Size = new System.Drawing.Size(66, 13);
            this.labelEndTime.TabIndex = 2;
            this.labelEndTime.Text = "Ending Time";
            // 
            // comboBoxEndTime
            // 
            this.comboBoxEndTime.FormattingEnabled = true;
            this.comboBoxEndTime.Location = new System.Drawing.Point(97, 58);
            this.comboBoxEndTime.Name = "comboBoxEndTime";
            this.comboBoxEndTime.Size = new System.Drawing.Size(226, 21);
            this.comboBoxEndTime.TabIndex = 15;
            this.comboBoxEndTime.Visible = false;
            // 
            // buttonTeamEvent
            // 
            this.buttonTeamEvent.Location = new System.Drawing.Point(9, 379);
            this.buttonTeamEvent.Name = "buttonTeamEvent";
            this.buttonTeamEvent.Size = new System.Drawing.Size(227, 40);
            this.buttonTeamEvent.TabIndex = 21;
            this.buttonTeamEvent.Text = "Add Team Event";
            this.buttonTeamEvent.UseVisualStyleBackColor = true;
            this.buttonTeamEvent.Visible = false;
            this.buttonTeamEvent.Click += new System.EventHandler(this.buttonTeamEvent_Click);
            // 
            // comboBoxStartTime
            // 
            this.comboBoxStartTime.FormattingEnabled = true;
            this.comboBoxStartTime.Location = new System.Drawing.Point(97, 31);
            this.comboBoxStartTime.Name = "comboBoxStartTime";
            this.comboBoxStartTime.Size = new System.Drawing.Size(226, 21);
            this.comboBoxStartTime.TabIndex = 10;
            this.comboBoxStartTime.Visible = false;
            // 
            // buttonCancelEvent
            // 
            this.buttonCancelEvent.Location = new System.Drawing.Point(197, 353);
            this.buttonCancelEvent.Name = "buttonCancelEvent";
            this.buttonCancelEvent.Size = new System.Drawing.Size(116, 23);
            this.buttonCancelEvent.TabIndex = 14;
            this.buttonCancelEvent.Text = "Cancel";
            this.buttonCancelEvent.UseVisualStyleBackColor = true;
            this.buttonCancelEvent.Click += new System.EventHandler(this.ButtonCancelEvent_Click);
            // 
            // buttonSaveEvent
            // 
            this.buttonSaveEvent.Location = new System.Drawing.Point(39, 353);
            this.buttonSaveEvent.Name = "buttonSaveEvent";
            this.buttonSaveEvent.Size = new System.Drawing.Size(116, 23);
            this.buttonSaveEvent.TabIndex = 9;
            this.buttonSaveEvent.Text = "Save";
            this.buttonSaveEvent.UseVisualStyleBackColor = true;
            this.buttonSaveEvent.Click += new System.EventHandler(this.ButtonSaveEvent_Click);
            // 
            // textBoxEventDescription
            // 
            this.textBoxEventDescription.Location = new System.Drawing.Point(18, 139);
            this.textBoxEventDescription.Multiline = true;
            this.textBoxEventDescription.Name = "textBoxEventDescription";
            this.textBoxEventDescription.Size = new System.Drawing.Size(305, 202);
            this.textBoxEventDescription.TabIndex = 13;
            // 
            // textBoxEventLocation
            // 
            this.textBoxEventLocation.Location = new System.Drawing.Point(97, 86);
            this.textBoxEventLocation.Name = "textBoxEventLocation";
            this.textBoxEventLocation.Size = new System.Drawing.Size(190, 20);
            this.textBoxEventLocation.TabIndex = 11;
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
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(15, 113);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(60, 13);
            this.labelDescription.TabIndex = 5;
            this.labelDescription.Text = "Description";
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Location = new System.Drawing.Point(15, 89);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(48, 13);
            this.labelLocation.TabIndex = 3;
            this.labelLocation.Text = "Location";
            // 
            // labelStartTime
            // 
            this.labelStartTime.AutoSize = true;
            this.labelStartTime.Location = new System.Drawing.Point(15, 35);
            this.labelStartTime.Name = "labelStartTime";
            this.labelStartTime.Size = new System.Drawing.Size(69, 13);
            this.labelStartTime.TabIndex = 1;
            this.labelStartTime.Text = "Starting Time";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(15, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(27, 13);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Title";
            // 
            // panelConflictError
            // 
            this.panelConflictError.Controls.Add(this.buttonContinueConflict);
            this.panelConflictError.Controls.Add(this.buttonCancelConfict);
            this.panelConflictError.Controls.Add(this.labelConflictErrorMessage);
            this.panelConflictError.Controls.Add(this.labelConflictErrorTitle);
            this.panelConflictError.Location = new System.Drawing.Point(529, 46);
            this.panelConflictError.Name = "panelConflictError";
            this.panelConflictError.Size = new System.Drawing.Size(334, 426);
            this.panelConflictError.TabIndex = 17;
            this.panelConflictError.Visible = false;
            // 
            // buttonContinueConflict
            // 
            this.buttonContinueConflict.Location = new System.Drawing.Point(119, 143);
            this.buttonContinueConflict.Name = "buttonContinueConflict";
            this.buttonContinueConflict.Size = new System.Drawing.Size(75, 23);
            this.buttonContinueConflict.TabIndex = 3;
            this.buttonContinueConflict.Text = "Continue";
            this.buttonContinueConflict.UseVisualStyleBackColor = true;
            this.buttonContinueConflict.Click += new System.EventHandler(this.buttonContinueConflict_Click);
            // 
            // buttonCancelConfict
            // 
            this.buttonCancelConfict.Location = new System.Drawing.Point(119, 107);
            this.buttonCancelConfict.Name = "buttonCancelConfict";
            this.buttonCancelConfict.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelConfict.TabIndex = 2;
            this.buttonCancelConfict.Text = "Cancel";
            this.buttonCancelConfict.UseVisualStyleBackColor = true;
            this.buttonCancelConfict.Click += new System.EventHandler(this.buttonCancelConfict_Click);
            // 
            // labelConflictErrorMessage
            // 
            this.labelConflictErrorMessage.AutoSize = true;
            this.labelConflictErrorMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConflictErrorMessage.Location = new System.Drawing.Point(26, 64);
            this.labelConflictErrorMessage.Name = "labelConflictErrorMessage";
            this.labelConflictErrorMessage.Size = new System.Drawing.Size(250, 16);
            this.labelConflictErrorMessage.TabIndex = 1;
            this.labelConflictErrorMessage.Text = "This event conflicts with an existing event.";
            // 
            // labelConflictErrorTitle
            // 
            this.labelConflictErrorTitle.AutoSize = true;
            this.labelConflictErrorTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConflictErrorTitle.ForeColor = System.Drawing.Color.Red;
            this.labelConflictErrorTitle.Location = new System.Drawing.Point(122, 29);
            this.labelConflictErrorTitle.Name = "labelConflictErrorTitle";
            this.labelConflictErrorTitle.Size = new System.Drawing.Size(67, 17);
            this.labelConflictErrorTitle.TabIndex = 0;
            this.labelConflictErrorTitle.Text = "ERROR!";
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.panelLoginError);
            this.panelLogin.Controls.Add(this.labelEnterCreds);
            this.panelLogin.Controls.Add(this.labelPassword);
            this.panelLogin.Controls.Add(this.labelUserName);
            this.panelLogin.Controls.Add(this.textBoxPassword);
            this.panelLogin.Controls.Add(this.textBoxUserName);
            this.panelLogin.Controls.Add(this.buttonLogin);
            this.panelLogin.Location = new System.Drawing.Point(267, 146);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(375, 270);
            this.panelLogin.TabIndex = 18;
            // 
            // panelLoginError
            // 
            this.panelLoginError.Controls.Add(this.buttonTryAgainLogin);
            this.panelLoginError.Controls.Add(this.labelErrorMessage);
            this.panelLoginError.Controls.Add(this.labelLoginErrorTitle);
            this.panelLoginError.Location = new System.Drawing.Point(37, 43);
            this.panelLoginError.Name = "panelLoginError";
            this.panelLoginError.Size = new System.Drawing.Size(299, 187);
            this.panelLoginError.TabIndex = 19;
            this.panelLoginError.Visible = false;
            // 
            // buttonTryAgainLogin
            // 
            this.buttonTryAgainLogin.Location = new System.Drawing.Point(106, 107);
            this.buttonTryAgainLogin.Name = "buttonTryAgainLogin";
            this.buttonTryAgainLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonTryAgainLogin.TabIndex = 5;
            this.buttonTryAgainLogin.Text = "Try Again";
            this.buttonTryAgainLogin.UseVisualStyleBackColor = true;
            this.buttonTryAgainLogin.Click += new System.EventHandler(this.buttonTryAgainLogin_Click);
            // 
            // labelErrorMessage
            // 
            this.labelErrorMessage.AutoSize = true;
            this.labelErrorMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErrorMessage.Location = new System.Drawing.Point(3, 69);
            this.labelErrorMessage.Name = "labelErrorMessage";
            this.labelErrorMessage.Size = new System.Drawing.Size(272, 16);
            this.labelErrorMessage.TabIndex = 4;
            this.labelErrorMessage.Text = "Either the username or password is incorrect.";
            // 
            // labelLoginErrorTitle
            // 
            this.labelLoginErrorTitle.AutoSize = true;
            this.labelLoginErrorTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginErrorTitle.ForeColor = System.Drawing.Color.Red;
            this.labelLoginErrorTitle.Location = new System.Drawing.Point(107, 30);
            this.labelLoginErrorTitle.Name = "labelLoginErrorTitle";
            this.labelLoginErrorTitle.Size = new System.Drawing.Size(67, 17);
            this.labelLoginErrorTitle.TabIndex = 4;
            this.labelLoginErrorTitle.Text = "ERROR!";
            // 
            // labelEnterCreds
            // 
            this.labelEnterCreds.AutoSize = true;
            this.labelEnterCreds.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnterCreds.Location = new System.Drawing.Point(54, 59);
            this.labelEnterCreds.Name = "labelEnterCreds";
            this.labelEnterCreds.Size = new System.Drawing.Size(266, 16);
            this.labelEnterCreds.TabIndex = 5;
            this.labelEnterCreds.Text = "Please enter your username and password.";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.854546F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(70, 131);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(53, 13);
            this.labelPassword.TabIndex = 4;
            this.labelPassword.Text = "Password";
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.854546F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.Location = new System.Drawing.Point(70, 97);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(55, 13);
            this.labelUserName.TabIndex = 3;
            this.labelUserName.Text = "Username";
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
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(150, 166);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // comboBoxMonth
            // 
            this.comboBoxMonth.FormattingEnabled = true;
            this.comboBoxMonth.Location = new System.Drawing.Point(500, 6);
            this.comboBoxMonth.MaxDropDownItems = 12;
            this.comboBoxMonth.Name = "comboBoxMonth";
            this.comboBoxMonth.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMonth.TabIndex = 20;
            this.comboBoxMonth.Text = "Select Month";
            this.comboBoxMonth.Visible = false;
            this.comboBoxMonth.SelectedIndexChanged += new System.EventHandler(this.comboBoxMonth_SelectedIndexChanged);
            // 
            // labelDeleteConfirm
            // 
            this.labelDeleteConfirm.AutoSize = true;
            this.labelDeleteConfirm.Location = new System.Drawing.Point(51, 16);
            this.labelDeleteConfirm.Name = "labelDeleteConfirm";
            this.labelDeleteConfirm.Size = new System.Drawing.Size(211, 13);
            this.labelDeleteConfirm.TabIndex = 1;
            this.labelDeleteConfirm.Text = "Are you sure you want to delete this event?";
            // 
            // buttonCancelDelete
            // 
            this.buttonCancelDelete.Location = new System.Drawing.Point(119, 87);
            this.buttonCancelDelete.Name = "buttonCancelDelete";
            this.buttonCancelDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelDelete.TabIndex = 2;
            this.buttonCancelDelete.Text = "Cancel";
            this.buttonCancelDelete.UseVisualStyleBackColor = true;
            this.buttonCancelDelete.Click += new System.EventHandler(this.buttonCancelDelete_Click);
            // 
            // panelEventTeam
            // 
            this.panelEventTeam.Controls.Add(this.buttonTimeSlots);
            this.panelEventTeam.Controls.Add(this.buttonAddMembers);
            this.panelEventTeam.Controls.Add(this.listBoxTeamMembersAdded);
            this.panelEventTeam.Controls.Add(this.comboBoxDurationTeamEvent);
            this.panelEventTeam.Controls.Add(this.labelDuration);
            this.panelEventTeam.Controls.Add(this.dateTimePickerTeamEvent);
            this.panelEventTeam.Controls.Add(this.labelEventForm);
            this.panelEventTeam.Location = new System.Drawing.Point(558, 43);
            this.panelEventTeam.Name = "panelEventTeam";
            this.panelEventTeam.Size = new System.Drawing.Size(338, 368);
            this.panelEventTeam.TabIndex = 22;
            this.panelEventTeam.Visible = false;
            // 
            // buttonTimeSlots
            // 
            this.buttonTimeSlots.Location = new System.Drawing.Point(79, 309);
            this.buttonTimeSlots.Name = "buttonTimeSlots";
            this.buttonTimeSlots.Size = new System.Drawing.Size(166, 24);
            this.buttonTimeSlots.TabIndex = 27;
            this.buttonTimeSlots.Text = "Find Possible Time Slots";
            this.buttonTimeSlots.UseVisualStyleBackColor = true;
            this.buttonTimeSlots.Click += new System.EventHandler(this.buttonTimeSlots_Click);
            // 
            // buttonAddMembers
            // 
            this.buttonAddMembers.Location = new System.Drawing.Point(101, 121);
            this.buttonAddMembers.Name = "buttonAddMembers";
            this.buttonAddMembers.Size = new System.Drawing.Size(128, 23);
            this.buttonAddMembers.TabIndex = 26;
            this.buttonAddMembers.Text = "Add member";
            this.buttonAddMembers.UseVisualStyleBackColor = true;
            this.buttonAddMembers.Click += new System.EventHandler(this.buttonAddMembers_Click);
            // 
            // listBoxTeamMembersAdded
            // 
            this.listBoxTeamMembersAdded.FormattingEnabled = true;
            this.listBoxTeamMembersAdded.Location = new System.Drawing.Point(79, 158);
            this.listBoxTeamMembersAdded.Name = "listBoxTeamMembersAdded";
            this.listBoxTeamMembersAdded.Size = new System.Drawing.Size(166, 134);
            this.listBoxTeamMembersAdded.TabIndex = 25;
            // 
            // comboBoxDurationTeamEvent
            // 
            this.comboBoxDurationTeamEvent.FormattingEnabled = true;
            this.comboBoxDurationTeamEvent.Location = new System.Drawing.Point(142, 89);
            this.comboBoxDurationTeamEvent.MaxDropDownItems = 4;
            this.comboBoxDurationTeamEvent.Name = "comboBoxDurationTeamEvent";
            this.comboBoxDurationTeamEvent.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDurationTeamEvent.TabIndex = 24;
            // 
            // labelDuration
            // 
            this.labelDuration.AutoSize = true;
            this.labelDuration.Location = new System.Drawing.Point(60, 92);
            this.labelDuration.Name = "labelDuration";
            this.labelDuration.Size = new System.Drawing.Size(47, 13);
            this.labelDuration.TabIndex = 23;
            this.labelDuration.Text = "Duration";
            // 
            // dateTimePickerTeamEvent
            // 
            this.dateTimePickerTeamEvent.Location = new System.Drawing.Point(63, 45);
            this.dateTimePickerTeamEvent.Name = "dateTimePickerTeamEvent";
            this.dateTimePickerTeamEvent.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerTeamEvent.TabIndex = 22;
            // 
            // labelEventForm
            // 
            this.labelEventForm.AutoSize = true;
            this.labelEventForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEventForm.Location = new System.Drawing.Point(98, 9);
            this.labelEventForm.Name = "labelEventForm";
            this.labelEventForm.Size = new System.Drawing.Size(114, 16);
            this.labelEventForm.TabIndex = 21;
            this.labelEventForm.Text = "Team Event Form";
            // 
            // buttonCancelTeamEvent
            // 
            this.buttonCancelTeamEvent.Location = new System.Drawing.Point(172, 247);
            this.buttonCancelTeamEvent.Name = "buttonCancelTeamEvent";
            this.buttonCancelTeamEvent.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelTeamEvent.TabIndex = 3;
            this.buttonCancelTeamEvent.Text = "Cancel";
            this.buttonCancelTeamEvent.UseVisualStyleBackColor = true;
            this.buttonCancelTeamEvent.Click += new System.EventHandler(this.buttonCancelTeamEvent_Click);
            // 
            // buttonSaveTeamEvent
            // 
            this.buttonSaveTeamEvent.Location = new System.Drawing.Point(75, 247);
            this.buttonSaveTeamEvent.Name = "buttonSaveTeamEvent";
            this.buttonSaveTeamEvent.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveTeamEvent.TabIndex = 2;
            this.buttonSaveTeamEvent.Text = "Save";
            this.buttonSaveTeamEvent.UseVisualStyleBackColor = true;
            this.buttonSaveTeamEvent.Click += new System.EventHandler(this.buttonSaveTeamEvent_Click);
            // 
            // buttonConfirmDelete
            // 
            this.buttonConfirmDelete.Location = new System.Drawing.Point(119, 55);
            this.buttonConfirmDelete.Name = "buttonConfirmDelete";
            this.buttonConfirmDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonConfirmDelete.TabIndex = 3;
            this.buttonConfirmDelete.Text = "Confirm";
            this.buttonConfirmDelete.UseVisualStyleBackColor = true;
            this.buttonConfirmDelete.Click += new System.EventHandler(this.buttonConfirmDelete_Click);
            // 
            // panelDeleteConfirm
            // 
            this.panelDeleteConfirm.Controls.Add(this.buttonConfirmDelete);
            this.panelDeleteConfirm.Controls.Add(this.buttonCancelDelete);
            this.panelDeleteConfirm.Controls.Add(this.labelDeleteConfirm);
            this.panelDeleteConfirm.Location = new System.Drawing.Point(537, 43);
            this.panelDeleteConfirm.Name = "panelDeleteConfirm";
            this.panelDeleteConfirm.Size = new System.Drawing.Size(334, 426);
            this.panelDeleteConfirm.TabIndex = 16;
            this.panelDeleteConfirm.Visible = false;
            // 
            // panelTimeSlotChoice
            // 
            this.panelTimeSlotChoice.Controls.Add(this.listBoxTeamTimeAvail);
            this.panelTimeSlotChoice.Controls.Add(this.labelTimeSlotTitle);
            this.panelTimeSlotChoice.Controls.Add(this.buttonCancelTeamEvent);
            this.panelTimeSlotChoice.Controls.Add(this.buttonSaveTeamEvent);
            this.panelTimeSlotChoice.Location = new System.Drawing.Point(550, 33);
            this.panelTimeSlotChoice.Name = "panelTimeSlotChoice";
            this.panelTimeSlotChoice.Size = new System.Drawing.Size(346, 423);
            this.panelTimeSlotChoice.TabIndex = 23;
            this.panelTimeSlotChoice.Visible = false;
            // 
            // labelTimeSlotTitle
            // 
            this.labelTimeSlotTitle.AutoSize = true;
            this.labelTimeSlotTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimeSlotTitle.Location = new System.Drawing.Point(106, 36);
            this.labelTimeSlotTitle.Name = "labelTimeSlotTitle";
            this.labelTimeSlotTitle.Size = new System.Drawing.Size(127, 16);
            this.labelTimeSlotTitle.TabIndex = 22;
            this.labelTimeSlotTitle.Text = "Possible Time Slots";
            // 
            // listBoxMembersToAdd
            // 
            this.listBoxMembersToAdd.FormattingEnabled = true;
            this.listBoxMembersToAdd.Location = new System.Drawing.Point(61, 41);
            this.listBoxMembersToAdd.Name = "listBoxMembersToAdd";
            this.listBoxMembersToAdd.Size = new System.Drawing.Size(167, 160);
            this.listBoxMembersToAdd.TabIndex = 28;
            this.listBoxMembersToAdd.SelectedIndexChanged += new System.EventHandler(this.listBoxMembersToAdd_SelectedIndexChanged);
            // 
            // panelMembersToAdd
            // 
            this.panelMembersToAdd.Controls.Add(this.buttonCancelMemberAdd);
            this.panelMembersToAdd.Controls.Add(this.labelChooseMembersToAdd);
            this.panelMembersToAdd.Controls.Add(this.listBoxMembersToAdd);
            this.panelMembersToAdd.Location = new System.Drawing.Point(572, 127);
            this.panelMembersToAdd.Name = "panelMembersToAdd";
            this.panelMembersToAdd.Size = new System.Drawing.Size(298, 248);
            this.panelMembersToAdd.TabIndex = 24;
            this.panelMembersToAdd.Visible = false;
            // 
            // buttonCancelMemberAdd
            // 
            this.buttonCancelMemberAdd.Location = new System.Drawing.Point(61, 207);
            this.buttonCancelMemberAdd.Name = "buttonCancelMemberAdd";
            this.buttonCancelMemberAdd.Size = new System.Drawing.Size(166, 30);
            this.buttonCancelMemberAdd.TabIndex = 30;
            this.buttonCancelMemberAdd.Text = "Cancel";
            this.buttonCancelMemberAdd.UseVisualStyleBackColor = true;
            this.buttonCancelMemberAdd.Click += new System.EventHandler(this.buttonCancelMemberAdd_Click);
            // 
            // labelChooseMembersToAdd
            // 
            this.labelChooseMembersToAdd.AutoSize = true;
            this.labelChooseMembersToAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChooseMembersToAdd.Location = new System.Drawing.Point(55, 16);
            this.labelChooseMembersToAdd.Name = "labelChooseMembersToAdd";
            this.labelChooseMembersToAdd.Size = new System.Drawing.Size(183, 16);
            this.labelChooseMembersToAdd.TabIndex = 29;
            this.labelChooseMembersToAdd.Text = "Select a team member to add";
            // 
            // listBoxTeamTimeAvail
            // 
            this.listBoxTeamTimeAvail.FormattingEnabled = true;
            this.listBoxTeamTimeAvail.Location = new System.Drawing.Point(109, 69);
            this.listBoxTeamTimeAvail.Name = "listBoxTeamTimeAvail";
            this.listBoxTeamTimeAvail.Size = new System.Drawing.Size(124, 134);
            this.listBoxTeamTimeAvail.TabIndex = 23;
            // 
            // buttonDeleteTeamEvent
            // 
            this.buttonDeleteTeamEvent.Location = new System.Drawing.Point(9, 425);
            this.buttonDeleteTeamEvent.Name = "buttonDeleteTeamEvent";
            this.buttonDeleteTeamEvent.Size = new System.Drawing.Size(227, 40);
            this.buttonDeleteTeamEvent.TabIndex = 25;
            this.buttonDeleteTeamEvent.Text = "Delete Team Event";
            this.buttonDeleteTeamEvent.UseVisualStyleBackColor = true;
            this.buttonDeleteTeamEvent.Visible = false;
            this.buttonDeleteTeamEvent.Click += new System.EventHandler(this.buttonDeleteTeamEvent_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 486);
            this.Controls.Add(this.buttonDeleteTeamEvent);
            this.Controls.Add(this.panelEvent);
            this.Controls.Add(this.comboBoxMonth);
            this.Controls.Add(this.buttonTeamEvent);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.buttonViewMonthly);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelEventsOn);
            this.Controls.Add(this.listBoxEventsDaily);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.panelDeleteConfirm);
            this.Controls.Add(this.panelConflictError);
            this.Controls.Add(this.panelMembersToAdd);
            this.Controls.Add(this.panelEventTeam);
            this.Controls.Add(this.panelTimeSlotChoice);
            this.Name = "FormMain";
            this.Text = "Personal Calendar";
            this.panelEvent.ResumeLayout(false);
            this.panelEvent.PerformLayout();
            this.panelConflictError.ResumeLayout(false);
            this.panelConflictError.PerformLayout();
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.panelLoginError.ResumeLayout(false);
            this.panelLoginError.PerformLayout();
            this.panelEventTeam.ResumeLayout(false);
            this.panelEventTeam.PerformLayout();
            this.panelDeleteConfirm.ResumeLayout(false);
            this.panelDeleteConfirm.PerformLayout();
            this.panelTimeSlotChoice.ResumeLayout(false);
            this.panelTimeSlotChoice.PerformLayout();
            this.panelMembersToAdd.ResumeLayout(false);
            this.panelMembersToAdd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ListBox listBoxEventsDaily;
        private System.Windows.Forms.Label labelEventsOn;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonViewMonthly;
        private System.Windows.Forms.Panel panelEvent;
        private System.Windows.Forms.TextBox textBoxEventDescription;
        private System.Windows.Forms.TextBox textBoxEventLocation;
        private System.Windows.Forms.TextBox textBoxEventStartTime;
        private System.Windows.Forms.TextBox textBoxEventTitle;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.Label labelEndTime;
        private System.Windows.Forms.Label labelStartTime;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonCancelEvent;
        private System.Windows.Forms.Button buttonSaveEvent;
        private System.Windows.Forms.TextBox textBoxEventEndTime;
        private System.Windows.Forms.ComboBox comboBoxStartTime;
        private System.Windows.Forms.ComboBox comboBoxEndTime;
        private System.Windows.Forms.Panel panelConflictError;
        private System.Windows.Forms.Button buttonContinueConflict;
        private System.Windows.Forms.Button buttonCancelConfict;
        private System.Windows.Forms.Label labelConflictErrorMessage;
        private System.Windows.Forms.Label labelConflictErrorTitle;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelEnterCreds;
        private System.Windows.Forms.Panel panelLoginError;
        private System.Windows.Forms.Button buttonTryAgainLogin;
        private System.Windows.Forms.Label labelErrorMessage;
        private System.Windows.Forms.Label labelLoginErrorTitle;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox comboBoxMonth;
        private System.Windows.Forms.Button buttonTeamEvent;
        private System.Windows.Forms.Label labelDeleteConfirm;
        private System.Windows.Forms.Button buttonCancelDelete;
        private System.Windows.Forms.Panel panelEventTeam;
        private System.Windows.Forms.Button buttonCancelTeamEvent;
        private System.Windows.Forms.ComboBox comboBoxDurationTeamEvent;
        private System.Windows.Forms.Button buttonSaveTeamEvent;
        private System.Windows.Forms.Label labelDuration;
        private System.Windows.Forms.DateTimePicker dateTimePickerTeamEvent;
        private System.Windows.Forms.Label labelEventForm;
        private System.Windows.Forms.Button buttonConfirmDelete;
        private System.Windows.Forms.Panel panelDeleteConfirm;
        private System.Windows.Forms.Panel panelTimeSlotChoice;
        private System.Windows.Forms.Button buttonTimeSlots;
        private System.Windows.Forms.Button buttonAddMembers;
        private System.Windows.Forms.ListBox listBoxTeamMembersAdded;
        private System.Windows.Forms.Label labelTimeSlotTitle;
        private System.Windows.Forms.ListBox listBoxMembersToAdd;
        private System.Windows.Forms.Panel panelMembersToAdd;
        private System.Windows.Forms.Label labelChooseMembersToAdd;
        private System.Windows.Forms.Button buttonCancelMemberAdd;
        private System.Windows.Forms.ListBox listBoxTeamTimeAvail;
        private System.Windows.Forms.Button buttonDeleteTeamEvent;
    }
}

