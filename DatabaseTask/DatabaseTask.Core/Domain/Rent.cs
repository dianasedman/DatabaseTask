using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Rent
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime RentStart { get; set; }
        public Guid RentEnd { get; set; }


        public Employee Employee { get; set; }
        public Item Item { get; set; }
    }
}
