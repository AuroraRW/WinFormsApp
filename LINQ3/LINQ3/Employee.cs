using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ3
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal AnnualSalary { get; set; }
        public bool IsManager { get; set; }
        public int DepartmentId { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is Employee other)
            {
                return Id == other.Id &&
                       FirstName == other.FirstName &&
                       LastName == other.LastName &&
                       AnnualSalary == other.AnnualSalary &&
                       IsManager == other.IsManager &&
                       DepartmentId == other.DepartmentId;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, FirstName, LastName, AnnualSalary, IsManager, DepartmentId);
        }
    }
}
