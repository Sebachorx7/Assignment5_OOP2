namespace Assignment5_SebastianRomero
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.GroupBoxStudentInformation = new System.Windows.Forms.GroupBox();
            this.ComboBoxHighSchoolGrade = new System.Windows.Forms.ComboBox();
            this.ComboBoxAdmissionTestScore = new System.Windows.Forms.ComboBox();
            this.LabelHighSchoolGrade = new System.Windows.Forms.Label();
            this.LabelAdmissionTestScore = new System.Windows.Forms.Label();
            this.TextBoxEmail = new System.Windows.Forms.TextBox();
            this.LabelEmail = new System.Windows.Forms.Label();
            this.TextBoxSIN = new System.Windows.Forms.TextBox();
            this.LabelSIN = new System.Windows.Forms.Label();
            this.TextBoxLastName = new System.Windows.Forms.TextBox();
            this.LabelLastName = new System.Windows.Forms.Label();
            this.TextBoxFirstName = new System.Windows.Forms.TextBox();
            this.LabelFirstName = new System.Windows.Forms.Label();
            this.ButtonCheck = new System.Windows.Forms.Button();
            this.GroupBoxAvailablePrograms = new System.Windows.Forms.GroupBox();
            this.LabelTotalCostShow = new System.Windows.Forms.Label();
            this.LabelStudyPeriodShow = new System.Windows.Forms.Label();
            this.ComboBoxPrograms = new System.Windows.Forms.ComboBox();
            this.ComboBoxCampusLocation = new System.Windows.Forms.ComboBox();
            this.LabelPrograms = new System.Windows.Forms.Label();
            this.LabelCampusLocation = new System.Windows.Forms.Label();
            this.LabelTotalCost = new System.Windows.Forms.Label();
            this.LabelStudyPeriod = new System.Windows.Forms.Label();
            this.ButtonRegisterStudent = new System.Windows.Forms.Button();
            this.DataGridViewRegisterStudent = new System.Windows.Forms.DataGridView();
            this.ButtonDeleteRecord = new System.Windows.Forms.Button();
            this.ButtonUpdateRecord = new System.Windows.Forms.Button();
            this.ButtonRemoveAllRecords = new System.Windows.Forms.Button();
            this.ButtonLoadRecordstoServer = new System.Windows.Forms.Button();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.ToolTipDCRegistrationApp = new System.Windows.Forms.ToolTip(this.components);
            this.MenuStripFileHelp = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.registerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAllRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadRecordsToServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.technicalSupportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutDCRegistrationAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GroupBoxStudentInformation.SuspendLayout();
            this.GroupBoxAvailablePrograms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewRegisterStudent)).BeginInit();
            this.MenuStripFileHelp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBoxStudentInformation
            // 
            this.GroupBoxStudentInformation.BackColor = System.Drawing.Color.Transparent;
            this.GroupBoxStudentInformation.Controls.Add(this.ComboBoxHighSchoolGrade);
            this.GroupBoxStudentInformation.Controls.Add(this.ComboBoxAdmissionTestScore);
            this.GroupBoxStudentInformation.Controls.Add(this.LabelHighSchoolGrade);
            this.GroupBoxStudentInformation.Controls.Add(this.LabelAdmissionTestScore);
            this.GroupBoxStudentInformation.Controls.Add(this.TextBoxEmail);
            this.GroupBoxStudentInformation.Controls.Add(this.LabelEmail);
            this.GroupBoxStudentInformation.Controls.Add(this.TextBoxSIN);
            this.GroupBoxStudentInformation.Controls.Add(this.LabelSIN);
            this.GroupBoxStudentInformation.Controls.Add(this.TextBoxLastName);
            this.GroupBoxStudentInformation.Controls.Add(this.LabelLastName);
            this.GroupBoxStudentInformation.Controls.Add(this.TextBoxFirstName);
            this.GroupBoxStudentInformation.Controls.Add(this.LabelFirstName);
            this.GroupBoxStudentInformation.Location = new System.Drawing.Point(12, 45);
            this.GroupBoxStudentInformation.Name = "GroupBoxStudentInformation";
            this.GroupBoxStudentInformation.Size = new System.Drawing.Size(809, 103);
            this.GroupBoxStudentInformation.TabIndex = 0;
            this.GroupBoxStudentInformation.TabStop = false;
            this.GroupBoxStudentInformation.Text = "Student Information";
            // 
            // ComboBoxHighSchoolGrade
            // 
            this.ComboBoxHighSchoolGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxHighSchoolGrade.FormattingEnabled = true;
            this.ComboBoxHighSchoolGrade.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90"});
            this.ComboBoxHighSchoolGrade.Location = new System.Drawing.Point(632, 59);
            this.ComboBoxHighSchoolGrade.Name = "ComboBoxHighSchoolGrade";
            this.ComboBoxHighSchoolGrade.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxHighSchoolGrade.TabIndex = 11;
            // 
            // ComboBoxAdmissionTestScore
            // 
            this.ComboBoxAdmissionTestScore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxAdmissionTestScore.FormattingEnabled = true;
            this.ComboBoxAdmissionTestScore.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90"});
            this.ComboBoxAdmissionTestScore.Location = new System.Drawing.Point(632, 27);
            this.ComboBoxAdmissionTestScore.Name = "ComboBoxAdmissionTestScore";
            this.ComboBoxAdmissionTestScore.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxAdmissionTestScore.TabIndex = 10;
            this.ToolTipDCRegistrationApp.SetToolTip(this.ComboBoxAdmissionTestScore, "Enter your Admission test score");
            // 
            // LabelHighSchoolGrade
            // 
            this.LabelHighSchoolGrade.AutoSize = true;
            this.LabelHighSchoolGrade.Location = new System.Drawing.Point(517, 64);
            this.LabelHighSchoolGrade.Name = "LabelHighSchoolGrade";
            this.LabelHighSchoolGrade.Size = new System.Drawing.Size(97, 13);
            this.LabelHighSchoolGrade.TabIndex = 9;
            this.LabelHighSchoolGrade.Text = "High School &Grade";
            // 
            // LabelAdmissionTestScore
            // 
            this.LabelAdmissionTestScore.AutoSize = true;
            this.LabelAdmissionTestScore.Location = new System.Drawing.Point(517, 31);
            this.LabelAdmissionTestScore.Name = "LabelAdmissionTestScore";
            this.LabelAdmissionTestScore.Size = new System.Drawing.Size(109, 13);
            this.LabelAdmissionTestScore.TabIndex = 8;
            this.LabelAdmissionTestScore.Text = "Admission &Test Score";
            // 
            // TextBoxEmail
            // 
            this.TextBoxEmail.Location = new System.Drawing.Point(277, 64);
            this.TextBoxEmail.Name = "TextBoxEmail";
            this.TextBoxEmail.Size = new System.Drawing.Size(191, 20);
            this.TextBoxEmail.TabIndex = 7;
            this.ToolTipDCRegistrationApp.SetToolTip(this.TextBoxEmail, "Enter your Email");
            // 
            // LabelEmail
            // 
            this.LabelEmail.AutoSize = true;
            this.LabelEmail.Location = new System.Drawing.Point(225, 67);
            this.LabelEmail.Name = "LabelEmail";
            this.LabelEmail.Size = new System.Drawing.Size(32, 13);
            this.LabelEmail.TabIndex = 6;
            this.LabelEmail.Text = "&Email";
            // 
            // TextBoxSIN
            // 
            this.TextBoxSIN.Location = new System.Drawing.Point(277, 28);
            this.TextBoxSIN.Name = "TextBoxSIN";
            this.TextBoxSIN.Size = new System.Drawing.Size(191, 20);
            this.TextBoxSIN.TabIndex = 5;
            this.ToolTipDCRegistrationApp.SetToolTip(this.TextBoxSIN, "Enter your SIN number");
            // 
            // LabelSIN
            // 
            this.LabelSIN.AutoSize = true;
            this.LabelSIN.Location = new System.Drawing.Point(225, 31);
            this.LabelSIN.Name = "LabelSIN";
            this.LabelSIN.Size = new System.Drawing.Size(25, 13);
            this.LabelSIN.TabIndex = 4;
            this.LabelSIN.Text = "SI&N";
            // 
            // TextBoxLastName
            // 
            this.TextBoxLastName.Location = new System.Drawing.Point(85, 68);
            this.TextBoxLastName.Name = "TextBoxLastName";
            this.TextBoxLastName.Size = new System.Drawing.Size(116, 20);
            this.TextBoxLastName.TabIndex = 3;
            this.ToolTipDCRegistrationApp.SetToolTip(this.TextBoxLastName, "Enter your last name");
            // 
            // LabelLastName
            // 
            this.LabelLastName.AutoSize = true;
            this.LabelLastName.Location = new System.Drawing.Point(24, 71);
            this.LabelLastName.Name = "LabelLastName";
            this.LabelLastName.Size = new System.Drawing.Size(58, 13);
            this.LabelLastName.TabIndex = 2;
            this.LabelLastName.Text = "La&st Name";
            // 
            // TextBoxFirstName
            // 
            this.TextBoxFirstName.Location = new System.Drawing.Point(87, 28);
            this.TextBoxFirstName.Name = "TextBoxFirstName";
            this.TextBoxFirstName.Size = new System.Drawing.Size(116, 20);
            this.TextBoxFirstName.TabIndex = 1;
            this.ToolTipDCRegistrationApp.SetToolTip(this.TextBoxFirstName, "Enter your first name");
            // 
            // LabelFirstName
            // 
            this.LabelFirstName.AutoSize = true;
            this.LabelFirstName.Location = new System.Drawing.Point(24, 31);
            this.LabelFirstName.Name = "LabelFirstName";
            this.LabelFirstName.Size = new System.Drawing.Size(57, 13);
            this.LabelFirstName.TabIndex = 0;
            this.LabelFirstName.Text = "&First Name";
            // 
            // ButtonCheck
            // 
            this.ButtonCheck.Location = new System.Drawing.Point(12, 165);
            this.ButtonCheck.Name = "ButtonCheck";
            this.ButtonCheck.Size = new System.Drawing.Size(109, 23);
            this.ButtonCheck.TabIndex = 1;
            this.ButtonCheck.Text = "&Check";
            this.ToolTipDCRegistrationApp.SetToolTip(this.ButtonCheck, "Click to check the eligibility of a student ");
            this.ButtonCheck.UseVisualStyleBackColor = true;
            this.ButtonCheck.Click += new System.EventHandler(this.ButtonCheck_Click);
            // 
            // GroupBoxAvailablePrograms
            // 
            this.GroupBoxAvailablePrograms.BackColor = System.Drawing.Color.Transparent;
            this.GroupBoxAvailablePrograms.Controls.Add(this.LabelTotalCostShow);
            this.GroupBoxAvailablePrograms.Controls.Add(this.LabelStudyPeriodShow);
            this.GroupBoxAvailablePrograms.Controls.Add(this.ComboBoxPrograms);
            this.GroupBoxAvailablePrograms.Controls.Add(this.ComboBoxCampusLocation);
            this.GroupBoxAvailablePrograms.Controls.Add(this.LabelPrograms);
            this.GroupBoxAvailablePrograms.Controls.Add(this.LabelCampusLocation);
            this.GroupBoxAvailablePrograms.Controls.Add(this.LabelTotalCost);
            this.GroupBoxAvailablePrograms.Controls.Add(this.LabelStudyPeriod);
            this.GroupBoxAvailablePrograms.Location = new System.Drawing.Point(12, 204);
            this.GroupBoxAvailablePrograms.Name = "GroupBoxAvailablePrograms";
            this.GroupBoxAvailablePrograms.Size = new System.Drawing.Size(809, 68);
            this.GroupBoxAvailablePrograms.TabIndex = 12;
            this.GroupBoxAvailablePrograms.TabStop = false;
            this.GroupBoxAvailablePrograms.Text = "Available Programs";
            // 
            // LabelTotalCostShow
            // 
            this.LabelTotalCostShow.AutoSize = true;
            this.LabelTotalCostShow.Location = new System.Drawing.Point(710, 43);
            this.LabelTotalCostShow.Name = "LabelTotalCostShow";
            this.LabelTotalCostShow.Size = new System.Drawing.Size(28, 13);
            this.LabelTotalCostShow.TabIndex = 13;
            this.LabelTotalCostShow.Text = "$0.0";
            // 
            // LabelStudyPeriodShow
            // 
            this.LabelStudyPeriodShow.AutoSize = true;
            this.LabelStudyPeriodShow.Location = new System.Drawing.Point(596, 43);
            this.LabelStudyPeriodShow.Name = "LabelStudyPeriodShow";
            this.LabelStudyPeriodShow.Size = new System.Drawing.Size(13, 13);
            this.LabelStudyPeriodShow.TabIndex = 12;
            this.LabelStudyPeriodShow.Text = "0";
            // 
            // ComboBoxPrograms
            // 
            this.ComboBoxPrograms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxPrograms.FormattingEnabled = true;
            this.ComboBoxPrograms.Location = new System.Drawing.Point(372, 27);
            this.ComboBoxPrograms.Name = "ComboBoxPrograms";
            this.ComboBoxPrograms.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxPrograms.TabIndex = 11;
            this.ToolTipDCRegistrationApp.SetToolTip(this.ComboBoxPrograms, "Select the program to register");
            this.ComboBoxPrograms.SelectedIndexChanged += new System.EventHandler(this.ComboBoxPrograms_SelectedIndexChanged);
            // 
            // ComboBoxCampusLocation
            // 
            this.ComboBoxCampusLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxCampusLocation.FormattingEnabled = true;
            this.ComboBoxCampusLocation.Items.AddRange(new object[] {
            "Ontario",
            "Quebec",
            "Nova Scotia",
            "New Brunswick",
            "Manitoba",
            "British Columbia",
            "Prince Edward Island",
            "Saskatchewan",
            "Alberta",
            "Newfoundland and Labrador"});
            this.ComboBoxCampusLocation.Location = new System.Drawing.Point(137, 28);
            this.ComboBoxCampusLocation.Name = "ComboBoxCampusLocation";
            this.ComboBoxCampusLocation.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxCampusLocation.TabIndex = 10;
            this.ToolTipDCRegistrationApp.SetToolTip(this.ComboBoxCampusLocation, "Enter the location of the campus");
            this.ComboBoxCampusLocation.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCampusLocation_SelectedIndexChanged);
            // 
            // LabelPrograms
            // 
            this.LabelPrograms.AutoSize = true;
            this.LabelPrograms.Location = new System.Drawing.Point(310, 35);
            this.LabelPrograms.Name = "LabelPrograms";
            this.LabelPrograms.Size = new System.Drawing.Size(51, 13);
            this.LabelPrograms.TabIndex = 9;
            this.LabelPrograms.Text = "Pr&ograms";
            // 
            // LabelCampusLocation
            // 
            this.LabelCampusLocation.AutoSize = true;
            this.LabelCampusLocation.Location = new System.Drawing.Point(42, 31);
            this.LabelCampusLocation.Name = "LabelCampusLocation";
            this.LabelCampusLocation.Size = new System.Drawing.Size(89, 13);
            this.LabelCampusLocation.TabIndex = 8;
            this.LabelCampusLocation.Text = "Ca&mpus Location";
            // 
            // LabelTotalCost
            // 
            this.LabelTotalCost.AutoSize = true;
            this.LabelTotalCost.Location = new System.Drawing.Point(698, 16);
            this.LabelTotalCost.Name = "LabelTotalCost";
            this.LabelTotalCost.Size = new System.Drawing.Size(55, 13);
            this.LabelTotalCost.TabIndex = 2;
            this.LabelTotalCost.Text = "Total Cost";
            // 
            // LabelStudyPeriod
            // 
            this.LabelStudyPeriod.AutoSize = true;
            this.LabelStudyPeriod.Location = new System.Drawing.Point(570, 16);
            this.LabelStudyPeriod.Name = "LabelStudyPeriod";
            this.LabelStudyPeriod.Size = new System.Drawing.Size(67, 13);
            this.LabelStudyPeriod.TabIndex = 0;
            this.LabelStudyPeriod.Text = "Study Period";
            // 
            // ButtonRegisterStudent
            // 
            this.ButtonRegisterStudent.Location = new System.Drawing.Point(12, 289);
            this.ButtonRegisterStudent.Name = "ButtonRegisterStudent";
            this.ButtonRegisterStudent.Size = new System.Drawing.Size(109, 23);
            this.ButtonRegisterStudent.TabIndex = 13;
            this.ButtonRegisterStudent.Text = "&Register Student";
            this.ToolTipDCRegistrationApp.SetToolTip(this.ButtonRegisterStudent, "Click to register an student");
            this.ButtonRegisterStudent.UseVisualStyleBackColor = true;
            this.ButtonRegisterStudent.Click += new System.EventHandler(this.ButtonRegisterStudent_Click);
            // 
            // DataGridViewRegisterStudent
            // 
            this.DataGridViewRegisterStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewRegisterStudent.Location = new System.Drawing.Point(0, 330);
            this.DataGridViewRegisterStudent.Name = "DataGridViewRegisterStudent";
            this.DataGridViewRegisterStudent.Size = new System.Drawing.Size(833, 130);
            this.DataGridViewRegisterStudent.TabIndex = 14;
            // 
            // ButtonDeleteRecord
            // 
            this.ButtonDeleteRecord.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonDeleteRecord.FlatAppearance.BorderSize = 2;
            this.ButtonDeleteRecord.Location = new System.Drawing.Point(57, 487);
            this.ButtonDeleteRecord.Name = "ButtonDeleteRecord";
            this.ButtonDeleteRecord.Size = new System.Drawing.Size(109, 23);
            this.ButtonDeleteRecord.TabIndex = 16;
            this.ButtonDeleteRecord.Text = "&Delete Record";
            this.ToolTipDCRegistrationApp.SetToolTip(this.ButtonDeleteRecord, "Click to delete the student record");
            this.ButtonDeleteRecord.UseVisualStyleBackColor = true;
            this.ButtonDeleteRecord.Click += new System.EventHandler(this.ButtonDeleteRecord_Click);
            // 
            // ButtonUpdateRecord
            // 
            this.ButtonUpdateRecord.Location = new System.Drawing.Point(205, 487);
            this.ButtonUpdateRecord.Name = "ButtonUpdateRecord";
            this.ButtonUpdateRecord.Size = new System.Drawing.Size(109, 23);
            this.ButtonUpdateRecord.TabIndex = 17;
            this.ButtonUpdateRecord.Text = "&Update Record";
            this.ToolTipDCRegistrationApp.SetToolTip(this.ButtonUpdateRecord, "Click to update the student record");
            this.ButtonUpdateRecord.UseVisualStyleBackColor = true;
            this.ButtonUpdateRecord.Click += new System.EventHandler(this.ButtonUpdateRecord_Click);
            // 
            // ButtonRemoveAllRecords
            // 
            this.ButtonRemoveAllRecords.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonRemoveAllRecords.Location = new System.Drawing.Point(448, 487);
            this.ButtonRemoveAllRecords.Name = "ButtonRemoveAllRecords";
            this.ButtonRemoveAllRecords.Size = new System.Drawing.Size(132, 23);
            this.ButtonRemoveAllRecords.TabIndex = 18;
            this.ButtonRemoveAllRecords.Text = "Remove &All Records";
            this.ToolTipDCRegistrationApp.SetToolTip(this.ButtonRemoveAllRecords, "Click to delete all records of the table");
            this.ButtonRemoveAllRecords.UseVisualStyleBackColor = true;
            this.ButtonRemoveAllRecords.Click += new System.EventHandler(this.ButtonRemoveAllRecords_Click);
            // 
            // ButtonLoadRecordstoServer
            // 
            this.ButtonLoadRecordstoServer.Location = new System.Drawing.Point(602, 487);
            this.ButtonLoadRecordstoServer.Name = "ButtonLoadRecordstoServer";
            this.ButtonLoadRecordstoServer.Size = new System.Drawing.Size(136, 23);
            this.ButtonLoadRecordstoServer.TabIndex = 19;
            this.ButtonLoadRecordstoServer.Text = "&Load Records to Server";
            this.ToolTipDCRegistrationApp.SetToolTip(this.ButtonLoadRecordstoServer, "Click to Loadrecords to the database");
            this.ButtonLoadRecordstoServer.UseVisualStyleBackColor = true;
            this.ButtonLoadRecordstoServer.Click += new System.EventHandler(this.ButtonLoadRecordstoServer_Click);
            // 
            // ButtonExit
            // 
            this.ButtonExit.Location = new System.Drawing.Point(712, 532);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(109, 23);
            this.ButtonExit.TabIndex = 20;
            this.ButtonExit.Text = "E&xit";
            this.ToolTipDCRegistrationApp.SetToolTip(this.ButtonExit, "Click to closes the App");
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // MenuStripFileHelp
            // 
            this.MenuStripFileHelp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.helpToolStripMenuItem});
            this.MenuStripFileHelp.Location = new System.Drawing.Point(0, 0);
            this.MenuStripFileHelp.Name = "MenuStripFileHelp";
            this.MenuStripFileHelp.Size = new System.Drawing.Size(833, 24);
            this.MenuStripFileHelp.TabIndex = 22;
            this.MenuStripFileHelp.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerToolStripMenuItem,
            this.recordToolStripMenuItem,
            this.deleteAllRecordsToolStripMenuItem,
            this.loadRecordsToServerToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem1.Text = "File";
            this.fileToolStripMenuItem1.Click += new System.EventHandler(this.fileToolStripMenuItem1_Click);
            // 
            // registerToolStripMenuItem
            // 
            this.registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            this.registerToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.registerToolStripMenuItem.Text = "Register";
            this.registerToolStripMenuItem.Click += new System.EventHandler(this.registerToolStripMenuItem_Click);
            // 
            // recordToolStripMenuItem
            // 
            this.recordToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateRecordToolStripMenuItem,
            this.deleteRecordToolStripMenuItem});
            this.recordToolStripMenuItem.Name = "recordToolStripMenuItem";
            this.recordToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.recordToolStripMenuItem.Text = "Record";
            // 
            // updateRecordToolStripMenuItem
            // 
            this.updateRecordToolStripMenuItem.Name = "updateRecordToolStripMenuItem";
            this.updateRecordToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.updateRecordToolStripMenuItem.Text = "Update Record";
            this.updateRecordToolStripMenuItem.Click += new System.EventHandler(this.updateRecordToolStripMenuItem_Click);
            // 
            // deleteRecordToolStripMenuItem
            // 
            this.deleteRecordToolStripMenuItem.Name = "deleteRecordToolStripMenuItem";
            this.deleteRecordToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deleteRecordToolStripMenuItem.Text = "Delete Record";
            this.deleteRecordToolStripMenuItem.Click += new System.EventHandler(this.deleteRecordToolStripMenuItem_Click);
            // 
            // deleteAllRecordsToolStripMenuItem
            // 
            this.deleteAllRecordsToolStripMenuItem.Name = "deleteAllRecordsToolStripMenuItem";
            this.deleteAllRecordsToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.deleteAllRecordsToolStripMenuItem.Text = "Delete All Records";
            this.deleteAllRecordsToolStripMenuItem.Click += new System.EventHandler(this.deleteAllRecordsToolStripMenuItem_Click);
            // 
            // loadRecordsToServerToolStripMenuItem
            // 
            this.loadRecordsToServerToolStripMenuItem.Name = "loadRecordsToServerToolStripMenuItem";
            this.loadRecordsToServerToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.loadRecordsToServerToolStripMenuItem.Text = "Load Records to Server";
            this.loadRecordsToServerToolStripMenuItem.Click += new System.EventHandler(this.loadRecordsToServerToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(191, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.readHelpToolStripMenuItem,
            this.technicalSupportsToolStripMenuItem,
            this.aboutDCRegistrationAppToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // readHelpToolStripMenuItem
            // 
            this.readHelpToolStripMenuItem.Name = "readHelpToolStripMenuItem";
            this.readHelpToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.readHelpToolStripMenuItem.Text = "Read Help";
            this.readHelpToolStripMenuItem.Click += new System.EventHandler(this.readHelpToolStripMenuItem_Click);
            // 
            // technicalSupportsToolStripMenuItem
            // 
            this.technicalSupportsToolStripMenuItem.Name = "technicalSupportsToolStripMenuItem";
            this.technicalSupportsToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.technicalSupportsToolStripMenuItem.Text = "Technical Supports";
            this.technicalSupportsToolStripMenuItem.Click += new System.EventHandler(this.technicalSupportsToolStripMenuItem_Click);
            // 
            // aboutDCRegistrationAppToolStripMenuItem
            // 
            this.aboutDCRegistrationAppToolStripMenuItem.Name = "aboutDCRegistrationAppToolStripMenuItem";
            this.aboutDCRegistrationAppToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.aboutDCRegistrationAppToolStripMenuItem.Text = "About DC-Registration App";
            this.aboutDCRegistrationAppToolStripMenuItem.Click += new System.EventHandler(this.aboutDCRegistrationAppToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(325, 478);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.ButtonCheck;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.ButtonRemoveAllRecords;
            this.ClientSize = new System.Drawing.Size(833, 576);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MenuStripFileHelp);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.ButtonLoadRecordstoServer);
            this.Controls.Add(this.ButtonRemoveAllRecords);
            this.Controls.Add(this.ButtonUpdateRecord);
            this.Controls.Add(this.ButtonDeleteRecord);
            this.Controls.Add(this.DataGridViewRegisterStudent);
            this.Controls.Add(this.ButtonRegisterStudent);
            this.Controls.Add(this.GroupBoxAvailablePrograms);
            this.Controls.Add(this.ButtonCheck);
            this.Controls.Add(this.GroupBoxStudentInformation);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStripFileHelp;
            this.MaximumSize = new System.Drawing.Size(849, 615);
            this.MinimumSize = new System.Drawing.Size(849, 615);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DC Registration App";
            this.GroupBoxStudentInformation.ResumeLayout(false);
            this.GroupBoxStudentInformation.PerformLayout();
            this.GroupBoxAvailablePrograms.ResumeLayout(false);
            this.GroupBoxAvailablePrograms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewRegisterStudent)).EndInit();
            this.MenuStripFileHelp.ResumeLayout(false);
            this.MenuStripFileHelp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBoxStudentInformation;
        private System.Windows.Forms.ComboBox ComboBoxHighSchoolGrade;
        private System.Windows.Forms.ComboBox ComboBoxAdmissionTestScore;
        private System.Windows.Forms.Label LabelHighSchoolGrade;
        private System.Windows.Forms.Label LabelAdmissionTestScore;
        private System.Windows.Forms.TextBox TextBoxEmail;
        private System.Windows.Forms.Label LabelEmail;
        private System.Windows.Forms.TextBox TextBoxSIN;
        private System.Windows.Forms.Label LabelSIN;
        private System.Windows.Forms.TextBox TextBoxLastName;
        private System.Windows.Forms.Label LabelLastName;
        private System.Windows.Forms.TextBox TextBoxFirstName;
        private System.Windows.Forms.Label LabelFirstName;
        private System.Windows.Forms.Button ButtonCheck;
        private System.Windows.Forms.GroupBox GroupBoxAvailablePrograms;
        private System.Windows.Forms.Label LabelTotalCostShow;
        private System.Windows.Forms.Label LabelStudyPeriodShow;
        private System.Windows.Forms.ComboBox ComboBoxPrograms;
        private System.Windows.Forms.ComboBox ComboBoxCampusLocation;
        private System.Windows.Forms.Label LabelPrograms;
        private System.Windows.Forms.Label LabelCampusLocation;
        private System.Windows.Forms.Label LabelTotalCost;
        private System.Windows.Forms.Label LabelStudyPeriod;
        private System.Windows.Forms.Button ButtonRegisterStudent;
        private System.Windows.Forms.DataGridView DataGridViewRegisterStudent;
        private System.Windows.Forms.Button ButtonDeleteRecord;
        private System.Windows.Forms.Button ButtonUpdateRecord;
        private System.Windows.Forms.Button ButtonRemoveAllRecords;
        private System.Windows.Forms.Button ButtonLoadRecordstoServer;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.ToolTip ToolTipDCRegistrationApp;
        private System.Windows.Forms.MenuStrip MenuStripFileHelp;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem registerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteAllRecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadRecordsToServerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem technicalSupportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutDCRegistrationAppToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

