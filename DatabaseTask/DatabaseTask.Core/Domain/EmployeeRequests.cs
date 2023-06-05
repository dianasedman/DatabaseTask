using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class EmployeeRequests
    {
        [Key]
        public Guid Id { get; set; }
        public string Content { get; set; }
        public DateTime NotificationTime { get; set; }
        public string? Comments { get; set; }


        public Employee Employee { get; set; }
        
    }
}
