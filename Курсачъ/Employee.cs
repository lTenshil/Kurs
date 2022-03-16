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
    }
}