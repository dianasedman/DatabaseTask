using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class BranchOffice
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int RegCode { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
        public string? ContactEmail { get; set; }


        public Company Companies { get; set; }
        public ICollection<Suggestion> Suggestions { get; set; }
        public ICollection<Item> Items { get; set; }
    }
}
