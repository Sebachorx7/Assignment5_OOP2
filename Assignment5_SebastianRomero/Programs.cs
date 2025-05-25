using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_SebastianRomero
{
    /// <summary>
    /// The class Program is used for the Solution. I had to use Programs.cs instead.
    /// </summary>
    internal class Programs
    {
        // Getters and setters to store the information about programs, rewrite toString method.
        public string programName { get; set; }
        public int programFees { get; set; }
        public int programDuration { get; set; }

        public Programs(string program_Name, int program_Fees, int program_Duration)

        {
            programName = program_Name;
            programFees = program_Fees;
            programDuration = program_Duration;
        }
        public override string ToString()
        {
            string programString;
            programString = programName;
            return programString;
        }
    }
}
