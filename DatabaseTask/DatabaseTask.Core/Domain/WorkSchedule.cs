using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class WorkSchedule
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime PeriodStart { get; set; }
        public DateTime PeriodEnd { get; set; }
        public int HoursWorked { get; set; }
        public int OverHours { get; set; }
        public string? Comment { get; set; }


        public EmploymentContract EmploymentContract { get; set; }
    }
}
