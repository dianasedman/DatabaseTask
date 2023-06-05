using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Salary
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime AccountingMonth { get; set; }
        public int AccountedSum { get; set; }
        public int TaxFreeMin { get; set; }
        public decimal WithholdingTax { get; set; }
        public decimal PayoutSum { get; set; }
        public DateTime PayoutDate { get; set; }
        public string AccountNumber { get; set; }
        public string? Comment { get; set; }

        public Employee Employee { get; set; }
    }
}
