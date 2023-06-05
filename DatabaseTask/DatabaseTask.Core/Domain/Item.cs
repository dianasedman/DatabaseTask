using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Item
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string ItemId { get; set; }
        public DateTime RentStart { get; set; }
        public DateTime RentEnd { get; set;}

        public BranchOffice BranchOffice { get; set; }
    }
}
