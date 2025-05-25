using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Assignment5_SebastianRomero
{
    internal class Student
    {
        // Getters and setters to keep the data from the student.
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int SIN { get; set; }
        public string Email { get; set; }
        public int highSchoolGrade { get; set; }
        public int admissionTestScore { get; set; }
        public string campusLocation { get; set; }
        public string programName { get; set; }

        // Parameterized constructor

        public Student(string first_Name, string last_Name, int sin, string email, int high_School_Grade,
                       int admission_Test_Score, string campus_Location, string program_Name)
        {
            firstName = first_Name;
            lastName = last_Name;
            SIN = sin;
            Email = email;
            highSchoolGrade = high_School_Grade;
            admissionTestScore = admission_Test_Score;
            campusLocation = campus_Location;
            programName = program_Name;
        }
    }
}
