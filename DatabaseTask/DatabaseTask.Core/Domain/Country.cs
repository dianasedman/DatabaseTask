using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class Country
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }

        public ICollection<Company> Companies { get; set; }
    }
}
