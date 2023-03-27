using System;
namespace jimyTest.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string DPI { get; set; } = string.Empty;
        public int childrenNumber { get; set; }
        public decimal baseSalary { get; set; }
        public decimal decreeBond { get; set; }
        public int Active { get; set; } = 1;
    }
}

