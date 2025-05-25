using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using System.Xml;
using Newtonsoft.Json;
using Microsoft.Win32;

namespace Assignment5_SebastianRomero
{/// <summary>
 /// Sebastian Romero Gonzalez - 100886859
 /// This application is able to register a new student to Durham College databases.
 /// The registration officer writes the needed information and can checkj if the student is admitted.
 /// After this, the app will ask for campus and program selected from the new student and register the decision.
 /// With all the students registered in the list, the registration officer will upload the information to the database in the Durham College's Server.
 /// If the register officer needs to modify or delete any register, he will be able to.
 /// If the register officer doesn't need the list anymore, he will be able to delete all the data from the server and prepare the app to recieve new students. 
 ///
 /// The student should have an admission score equal or above of 60 points, and high school grade of 70 points.
/// </summary>
    public partial class Form1 : System.Windows.Forms.Form
    {
        // Biding list variable declaration.
        private BindingList<Student> studentBindingList;
        // Constants declaration.
        private const int AdmissionScorePass = 5;
        private const int HighSchoolGrade = 6;
        public Form1()
        {
            InitializeComponent();
            enableOrDisable(false);
            // subscribe the method, used to see the info of the student in the textboxes when is selected in the datagrid view
            DataGridViewRegisterStudent.SelectionChanged += DataGridViewRegisterStudent_SelectionChanged;
        }
        /// <summary>
        /// Method to take the control of those controllers, at the start of the session, those controls are disabled
        /// </summary>
        /// <param name="enableOrDisable"></param>
        private void enableOrDisable(bool enableOrDisable)
        {
            GroupBoxAvailablePrograms.Enabled = enableOrDisable;
            ButtonRegisterStudent.Enabled = enableOrDisable;
            DataGridViewRegisterStudent.Enabled = enableOrDisable;
            ButtonDeleteRecord.Enabled = enableOrDisable;
            ButtonUpdateRecord.Enabled = enableOrDisable;
            ButtonRemoveAllRecords.Enabled = enableOrDisable;
            ButtonLoadRecordstoServer.Enabled = enableOrDisable;
        }/// <summary>
        /// I had to use this method to take control only of this part of the app.
        /// </summary>
        /// <param name="enableOrDisable"></param>
        private void enableOrDisableAvailablePrograms(bool enableOrDisable)
        {
            GroupBoxAvailablePrograms.Enabled = enableOrDisable;
        }
        /// <summary>
        /// Set as default the form using a method.
        /// </summary>
        private void ClearForm()
        {
            // Clear all form controls, including those within groupboxes
            ClearControls(this);
        }
        /// <summary>
        /// Clear all the controls, textboxes, comboboxes, colors, index to be as default.
        /// </summary>
        /// <param name="control"></param>
        private void ClearControls(Control control)
        {
            ComboBoxAdmissionTestScore.SelectedIndex = -1;
            ComboBoxHighSchoolGrade.SelectedIndex = -1;
            foreach (Control ctrl in control.Controls)
            {
                if (ctrl is TextBox || ctrl is ComboBox)
                {
                    ctrl.Text = "";
                    ctrl.BackColor = SystemColors.Window;
                }
                // If the control is groupbox, recursively clear it control
                if (ctrl is GroupBox)
                {
                    ClearControls(ctrl);
                }
            }
        }
        /// <summary>
        /// Close the program.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Method to inizialize the datagrid view
        /// </summary>
        private void InitializeDataGridView()
        {
            // Check if the columns have not been added yet. // The final document adds another extra columns twice.
            if (DataGridViewRegisterStudent.Columns.Count == 0) 
            {
                DataGridViewTextBoxColumn[] columns =
                {
                    new DataGridViewTextBoxColumn() {HeaderText = "First Name", DataPropertyName = "firstName"},
                    new DataGridViewTextBoxColumn() {HeaderText = "Last Name", DataPropertyName = "lastName"},
                    new DataGridViewTextBoxColumn() {HeaderText = "SIN", DataPropertyName = "SIN"},
                    new DataGridViewTextBoxColumn() {HeaderText = "Email", DataPropertyName = "Email"},
                    new DataGridViewTextBoxColumn() {HeaderText = "High School Grade", DataPropertyName = "highSchoolGrade"},
                    new DataGridViewTextBoxColumn() {HeaderText = "Admission Test Score", DataPropertyName = "admissionTestScore"},
                    new DataGridViewTextBoxColumn() {HeaderText = "Campus Location", DataPropertyName = "campusLocation"},
                    new DataGridViewTextBoxColumn() {HeaderText = "Program Name", DataPropertyName = "programName"}
                };
                DataGridViewRegisterStudent.Columns.AddRange(columns);
                DataGridViewRegisterStudent.AutoGenerateColumns = false;
            }
            // The path of the json file is as default, it has no relation to any computer, only the main folder
            string jsonFilePath = @".\students.json";
            if (File.Exists(jsonFilePath))
            {
                //associate the students to grid view
                studentBindingList = new BindingList<Student>(ReadJsonFile(jsonFilePath));
                DataGridViewRegisterStudent.DataSource = Students;
            }
        }
        /// <summary>
        /// Reads the json file.
        /// </summary>
        /// <param name="filepath"></param>
        /// <returns></returns>
        private List<Student> ReadJsonFile(string filepath)
        {
            try
            {
                string json = File.ReadAllText(filepath);
                return JsonConvert.DeserializeObject<List<Student>>(json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading Server file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        /// <summary>
        /// This method validates the input in each student field. Display the errors if the user app gets unexpected information or non-exist.
        /// 
        /// The student should have an admission score equal or above of 60 points, and high school grade of 70 points.
        /// </summary>
        /// <returns></returns>
        private bool ValidateStudentInformationInputs()
        {
            //Validate Text box first name is empty.
            if (TextBoxFirstName.Text == "" || int.TryParse(TextBoxFirstName.Text, out int firstnameInt))
            {
                MessageBox.Show("Check the input First Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextBoxFirstName.BackColor = Color.Red;
                return false;
            }
            //Validate Text box last name is empty.
            else if (TextBoxLastName.Text == "" || int.TryParse(TextBoxFirstName.Text, out int lastnameInt))
            {
                MessageBox.Show("Check the input Last Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextBoxLastName.BackColor = Color.Red;
                return false;
            }
            // Validate the Student ID is numeric.
            else if (!int.TryParse(TextBoxSIN.Text, out int sin) || sin <= 0 || TextBoxSIN.Text.Length != 9)
            {
                MessageBox.Show("Invalid Social Insurance Number (SIN). Please enter a numeric, positive value should be 9 digits.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextBoxSIN.BackColor = Color.Red;
                return false;
            }
            //Validate Email Address is in a correct format
            else if (!TextBoxEmail.Text.Contains("@") || (!TextBoxEmail.Text.EndsWith(".com") && !TextBoxEmail.Text.EndsWith(".ca")))
            {
                MessageBox.Show("Invalid Student Email. Please enter a valid email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextBoxEmail.BackColor = Color.Red;
                return false;
            }            
            //Validate if the user selected something from combobox
            else if (ComboBoxAdmissionTestScore.SelectedIndex == -1)
            {
                MessageBox.Show("Check the Admission Test Score.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ComboBoxAdmissionTestScore.BackColor = Color.Red;
                return false;
            }
            //Validate if the user selected something from combobox
            else if (ComboBoxHighSchoolGrade.SelectedIndex == -1)
            {
                MessageBox.Show("Check the High School Grade.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ComboBoxHighSchoolGrade.BackColor = Color.Red;
                return false;
            }
            return true;

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCheck_Click(object sender, EventArgs e)
        {
            try
            {
                // Sets the colors of the textboxes as default.
                TextBoxFirstName.BackColor = SystemColors.Window;
                TextBoxLastName.BackColor = SystemColors.Window;
                TextBoxSIN.BackColor = SystemColors.Window;
                TextBoxEmail.BackColor = SystemColors.Window;
                ComboBoxAdmissionTestScore.BackColor = SystemColors.Window;
                ComboBoxHighSchoolGrade.BackColor = SystemColors.Window;
                // Validate if the admission scores and highschool grades are enough to pass.
                if (ValidateStudentInformationInputs())
                {
                    if (ComboBoxAdmissionTestScore.SelectedIndex >= AdmissionScorePass)
                    {
                        if (ComboBoxHighSchoolGrade.SelectedIndex >= HighSchoolGrade)
                        {
                            MessageBox.Show("The student is elegible to be accepted in Durham College.\nPlease, select one of the Campuses, then select one of the programs.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Enable the controlles to be used.
                            enableOrDisable(true);
                            InitializeDataGridView();
                            ComboBoxPrograms.Enabled = false;
                        }
                        else
                        {
                            // If the highschool grades are too low, displays a message
                            MessageBox.Show("The high school grades of the student are not enought to be accepted.\n Student Application is rejected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            ClearForm();
                        }
                    }
                    else
                    {
                        // If the Admission score is too low, displays a message
                        MessageBox.Show("The Admission score of the student is too low to be accepted.\n Student Application is rejected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ClearForm();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in the application: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// If the user select any selection from campus locaiton, combo box programs is enabled. Populate the programs combobox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboBoxCampusLocation_SelectedIndexChanged(object sender, EventArgs e)
        {

            if( ComboBoxCampusLocation.SelectedIndex != -1 )
            {
                ComboBoxPrograms.Enabled = true;
                initializePrograms();
            }                
        }
        /// <summary>
        /// Populate the programs combobox.
        /// </summary>
        private void initializePrograms()
        {
            ComboBoxPrograms.Items.Clear();
            ComboBoxPrograms.Items.Add(new Programs("Architectural".ToString(), 13385, 3));
            ComboBoxPrograms.Items.Add(new Programs("Science and Art (General Certificate)".ToString(), 4148, 1));
            ComboBoxPrograms.Items.Add(new Programs("Law".ToString(), 12368, 3));
            ComboBoxPrograms.Items.Add(new Programs("Health".ToString(), 9119, 2));
            ComboBoxPrograms.Items.Add(new Programs("Engineering (Technician)".ToString(), 12909, 3));// mostrar en decimales
            ComboBoxPrograms.Items.Add(new Programs("Music".ToString(), 8258, 2));
            ComboBoxPrograms.Items.Add(new Programs("Business".ToString(), 6594, 2));
        }
        /// <summary>
        /// send the selections from comboboxes and display an relevan information in the labels, in this case are prices and durations.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboBoxPrograms_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxPrograms.SelectedItem is Programs selectedProgram)
            {
                LabelStudyPeriodShow.Text = $"{selectedProgram.programDuration} Years";
                LabelTotalCostShow.Text = $"${selectedProgram.programFees}";
            }
        }
        /// <summary>
        /// Check if the SIN number already exist.
        /// </summary>
        /// <param name="sin"></param>
        /// <returns></returns>
        public bool IsSINAlreadyExists(int sin)
        {
            foreach (Student existingStudent in Students)
            {
                if (existingStudent.SIN == sin)
                {
                    // SIN already exist
                    return true;
                }
            }
            // SIN doesn't exist.
            return false;
        }
        // Create a new students list.
        List<Student> Students = new List<Student>();
        /// <summary>
        /// Method to save the student's information, is used to save the info in the datagrid view later.
        /// </summary>
        public void saveStudent()
        {
            try
            {
                int newSIN = int.Parse(TextBoxSIN.Text);

                // Use the method to know if the SIN already exist.
                if (IsSINAlreadyExists(newSIN))
                {
                    MessageBox.Show("The SIN already exists in the list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // Set the information to the new student object
                Student student = new Student(TextBoxFirstName.Text, TextBoxLastName.Text, int.Parse(TextBoxSIN.Text), TextBoxEmail.Text, Convert.ToInt32(ComboBoxHighSchoolGrade.SelectedItem), Convert.ToInt32(ComboBoxAdmissionTestScore.SelectedItem), ComboBoxCampusLocation.SelectedItem.ToString(), ComboBoxPrograms.SelectedItem.ToString());
                Students.Add(student);
                DataGridViewRegisterStudent.DataSource = null;
                DataGridViewRegisterStudent.DataSource = Students;
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in the application: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Uses savestudent method and disable programs combobox.
        /// </summary>
        private void registerStudent()
        {
            saveStudent();
            enableOrDisableAvailablePrograms(false);
        }
        /// <summary>
        /// Use register student method in the bottom.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonRegisterStudent_Click(object sender, EventArgs e)
        {
            registerStudent();
        }
        /// <summary>
        /// Use register student method in the tool strip.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            registerStudent();
        }
        /// <summary>
        /// Set the student's information to the textboxes again, this is useful to update the students info.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridViewRegisterStudent_SelectionChanged(object sender, EventArgs e)
        {
            // Check if there is at least one record selected
            if (DataGridViewRegisterStudent.SelectedRows.Count > 0)
            {
                // Get the selected student
                Student selectedStudent = (Student)DataGridViewRegisterStudent.SelectedRows[0].DataBoundItem;

                // Assign values ​​to TextBoxes
                TextBoxFirstName.Text = selectedStudent.firstName;
                TextBoxLastName.Text = selectedStudent.lastName;
                TextBoxSIN.Text = selectedStudent.SIN.ToString();
                TextBoxEmail.Text = selectedStudent.Email;
                // enable the controls of textboxes
                enableOrDisable(true);
            }
        }
        /// <summary>
        /// Is used when is needed to be updated the information of the student, get the information of the student, and  set in the textboxes to be edited
        /// </summary>
        private void updateStudent()
        {
            try
            {

                // Check if there is at least one record selected
                if (DataGridViewRegisterStudent.SelectedRows.Count > 0)
                {
                    // Get the index of the selected student
                    int selectedIndex = DataGridViewRegisterStudent.SelectedRows[0].Index;

                    // Get the selected student
                    Student selectedStudent = (Student)DataGridViewRegisterStudent.Rows[selectedIndex].DataBoundItem;

                    // Update student properties with information from TextBoxes
                    selectedStudent.firstName = TextBoxFirstName.Text;
                    selectedStudent.lastName = TextBoxLastName.Text;
                    selectedStudent.SIN = int.Parse(TextBoxSIN.Text);
                    selectedStudent.Email = TextBoxEmail.Text;
                    // link the updated list to the datagrid view
                    DataGridViewRegisterStudent.DataSource = null;
                    DataGridViewRegisterStudent.DataSource = Students;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in the application: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Update method in the botton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonUpdateRecord_Click(object sender, EventArgs e)
        {
            updateStudent();
        }
        /// <summary>
        /// Update method in the tool strip
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void updateRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateStudent();
        }
        /// <summary>
        /// 
        /// </summary>
        private void deleteStudent()
        {
            try
            {
                // Check if there is at least one record selected
                if (DataGridViewRegisterStudent.SelectedRows.Count > 0)
                {
                    // Get the index of the selected student
                    int selectedIndex = DataGridViewRegisterStudent.SelectedRows[0].Index;

                    // Delete the selected student from the list
                    Students.RemoveAt(selectedIndex);

                    // Rebind the updated list to the DataGridView
                    DataGridViewRegisterStudent.DataSource = null;
                    DataGridViewRegisterStudent.DataSource = Students;
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in the application: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Delete student method in the button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonDeleteRecord_Click(object sender, EventArgs e)
        {
            deleteStudent();
        }
        /// <summary>
        /// Delete student method in the tool strip
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleteStudent();
        }
        /// <summary>
        /// Method to delete all students in the datagrid view.
        /// </summary>
        private void removeAllStudents()
        {
            // Clear student list
            Students.Clear();

            // Rebind the empty list to the DataGridView
            DataGridViewRegisterStudent.DataSource = null;
            DataGridViewRegisterStudent.DataSource = Students;
            ClearForm();
        }
        /// <summary>
        /// Remove all students method used in the button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonRemoveAllRecords_Click(object sender, EventArgs e)
        {
            removeAllStudents();
        }
        /// <summary>
        /// Remove all students method used in the tool strip
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteAllRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            removeAllStudents();
        }
        /// <summary>
        /// Load records method used in the button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonLoadRecordstoServer_Click(object sender, EventArgs e)
        {
            loadToServer();
        }
        /// <summary>
        /// Load records method used in the tool strip
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadRecordsToServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadToServer();
        }
        /// <summary>
        /// 
        /// </summary>
        private void loadToServer()
        {
            try
            {   // I had some help from chatGPT in this section of the code.
                DataTable dataTable = new DataTable();
                foreach (DataGridViewColumn column in DataGridViewRegisterStudent.Columns)
                {
                    dataTable.Columns.Add(column.HeaderText, column.ValueType ?? typeof(string));
                }

                // Fill the DataTable with data from the DataGridView
                foreach (DataGridViewRow row in DataGridViewRegisterStudent.Rows)
                {
                    DataRow dataRow = dataTable.NewRow();
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        dataRow[cell.ColumnIndex] = cell.Value;
                    }
                    dataTable.Rows.Add(dataRow);
                }

                // Convert student list to JSON format
                string json = JsonConvert.SerializeObject(Students, Newtonsoft.Json.Formatting.Indented);
                string jsonFilePath = @".\students.json";

                // Write the JSON data to the file
                File.WriteAllText(jsonFilePath, json);

                MessageBox.Show("Data saved correctly on the Server", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving to the Server: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DataGridViewRegisterStudent.DataSource = null;
            ClearForm();
        }
        /// <summary>
        /// Exit method used in the tool strip
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Displays the read help form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void readHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReadHelp FormReadHelp = new FormReadHelp();

            // Mostrar Form2
            FormReadHelp.Show();
        }
        /// <summary>
        /// Displays the technical support form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void technicalSupportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTechnicalSupport FormTechnicalSupport = new FormTechnicalSupport();

            // Mostrar Form2
            FormTechnicalSupport.Show();
        }
        /// <summary>
         /// Displays the about dc form.
         /// </summary>
         /// <param name="sender"></param>
         /// <param name="e"></param>
        private void aboutDCRegistrationAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout FormAbout = new FormAbout();

            // Mostrar Form2
            FormAbout.Show();
        }

        private void fileToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
