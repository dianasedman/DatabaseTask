using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class EmployeeOccupation
    {
        [Key]
        public Guid Id { get; set; }

        public DateTime InitialDate { get; set; }
        public DateTime EndDate { get; set; }

        public Employee Employee { get; set; }
        public Occupation Occupation { get; set; } 
    }
}
