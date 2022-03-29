using System.Collections.Generic;

namespace Курсачъ
{
   public class Employee
    {
        public int Id { get; set; }
        public string Full_name { get; set; }
        public int Experience { get; set; }
        public decimal Salary { get; set; }
        public virtual ICollection<Sale> Sale { get; set; }

        public Employee(string full_name, int experience, decimal salary)
        {
            Full_name = full_name;
            Experience = experience;
            Salary = salary;
        }

        public Employee(int id, string full_name, int experience, decimal salary)
        {
            Id = id;
            Full_name = full_name;
            Experience = experience;
            Salary = salary;
        }
        public Employee ()
        {

        }
    }
}