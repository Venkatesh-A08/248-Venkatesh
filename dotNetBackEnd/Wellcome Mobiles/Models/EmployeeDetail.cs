using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wellcome_Mobiles.Models
{
    public class EmployeeDetail
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int PhoneNumber { get; set; }
        public string Location { get; set; }
        public DateTime DateOfJoining { get; set; }
        public int Salary { get; set; }
    }
}
