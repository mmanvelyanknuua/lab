using System;

namespace WindowsFormsApp4
{
    [Serializable]
    public class Scientist
    {
        public string Pib { get; set; }

        public string Faculty { get; set; }

        public string Cathedra { get; set; }

        public string Position { get; set; }

        public decimal Salary { get; set; }

        public int DaysOnPosition { get; set; }

        public Scientist(string pib, string faculty, string cathedra, string position, decimal salary, int daysOnPosition)
        {
            Pib = pib;
            Faculty = faculty;
            Cathedra = cathedra;
            Position = position;
            Salary = salary;
            DaysOnPosition = daysOnPosition;
        }

        public override string ToString()
        {
            return "\nScientist: \nPib: " + Pib + ". Faculty: " + Faculty + ". Cathedra: " + Cathedra + "\nPosition: " + Position + ". Salary: " + Salary + ". Days on position: " + DaysOnPosition + "\n";
        }
    }
}
