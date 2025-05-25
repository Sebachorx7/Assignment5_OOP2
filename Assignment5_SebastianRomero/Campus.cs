using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_SebastianRomero
{
    internal class Campus
    {
        // Getters and setters to store the data from the campus, stored in a list.
        public int HSGradeReq { get; set; }
        public int admissionTSReq { get; set; }
        public int regFees { get; set; }
        public ArrayList listPrograms { get; set; }

        // Constructor para inicializar la ArrayList
        public Campus()
        {
            listPrograms = new ArrayList();
        }

    }
}
