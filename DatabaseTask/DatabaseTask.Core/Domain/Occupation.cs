using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Occupation
    {
        [Key]
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime InUseSince { get; set; }
        public DateTime InUseUntil { get; set; }

        public ICollection<EmployeeOccupation> EmployeeOccupations { get; set; }
    }
}
