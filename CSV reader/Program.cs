using System;
using System.IO;

namespace CSV_reader
{
    class Program
    {
        public struct Reader
        {
            public int INV;
            public string Surname;
            public string Name;
            public string Patronymic;
            public int Experience;
            public int Index;
            public string Department;

            public Reader(int _INV, string _Surname, string _Name, string _Petronymic, int _Experience, int _Index, string _department)
            {
                this.INV = _INV;
                this.Surname = _Surname;
                this.Name = _Name;
                this.Patronymic = _Petronymic;
                this.Experience = _Experience;
                this.Index = _Index;
                this.Department = _department;
            }

        }
        
        static void Main(string[] args)
        {
            using (StreamReader sr = File.OpenText("CSV.csv"))
            {
                string input = null;
                while ((input = sr.ReadLine()) != null)
                {
                    Console.WriteLine(input);
                }
            }
            Console.ReadLine();
   
        }
       
    }
}
