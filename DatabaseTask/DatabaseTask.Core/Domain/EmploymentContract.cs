using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class EmploymentContract
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime EffectiveDate { get; set; }
        public string ContractType { get; set; }
        public decimal Workload { get; set; }
        public int AddendumNumber { get; set; }
        public int Salary { get; set; }



        public Employee Employee { get; set; }
        public ICollection<WorkSchedule> WorkSchedules { get; set; }
    }
}
