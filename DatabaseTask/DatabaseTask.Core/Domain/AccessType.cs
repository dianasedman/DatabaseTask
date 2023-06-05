using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class AccessType
    {
        [Key]
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime TerminatedDate { get; set;}
        public string? Comment { get; set; }

        public ICollection<EmployeeAccess> EmployeeAccesses { get; set; }
    }
}
