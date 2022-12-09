using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    public class ScientistList
    {
        public List<Scientist> Scientists { get; set; }

        private string file = "file.xml";
        
        public List<Scientist> FindByPIB(string PIB)
        {
            return Scientists.Where(x => x.Pib == PIB).ToList();
        }

        public List<Scientist> FindBySalary(decimal salary)
        {
            return Scientists.Where(x => x.Salary == salary).ToList();
        }

        public List<Scientist> FindByCathedra(string cathedra)
        {
            return Scientists.Where(x => x.Cathedra == cathedra).ToList();
        }


        public void AddScientist(Scientist scientist)
        {
            foreach (var sc in Scientists)
            {
                if(sc.Pib == scientist.Pib)
                {
                    throw new Exception("Науковця з таким ПІБ вже було додано");
                }
            }
            Scientists.Add(scientist);
        }

        public void EditScientist(Scientist scientist)
        {
            foreach (var sc in Scientists)
            {
                if(sc.Pib == scientist.Pib)
                {
                    sc.Faculty = scientist.Faculty;
                    sc.Salary = scientist.Salary;
                    sc.Cathedra = scientist.Cathedra;
                    sc.DaysOnPosition = scientist.DaysOnPosition;
                    sc.Position = scientist.Position;
                }
            }
        }

        public void DeleteScientist(string pib)
        {
            foreach (var sc in Scientists)
            {
                if(sc.Pib == pib)
                {
                    Scientists.Remove(sc);
                    return;
                }
            }
        }

        public void LoadFromFile()
        {
            using (var sr = new StreamReader(file))
            {
                Scientists = JsonConvert.DeserializeObject<List<Scientist>>(sr.ReadToEnd());
            }
        }

        public void LoadToFile()
        {
            using (var sw = new StreamWriter(file))
            {
                sw.Write(JsonConvert.SerializeObject(Scientists));
            }
        }

        public ScientistList()
        {
            Scientists = new List<Scientist>();
        }
    }
}
