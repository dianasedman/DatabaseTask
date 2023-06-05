using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class DepartmentEmployee
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime WorksFrom { get; set; }
        public DateTime WorksUntil { get; set; }
        
        public Employee Employee { get; set; }
        public Department Department { get; set; }

    }
}
