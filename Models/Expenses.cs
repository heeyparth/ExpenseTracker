
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Mime;

namespace ExpenseTrackerApp.Models
{
    public enum Category
    {
        Food,
        Travel,
        Electricity,
        Personal,
        Others
    }

    public class Expenses
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName ="varchar(20)") ]
        public required string Title { get; set; }

        [Required]
        
        public decimal Amount { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateOnly Date { get; set; }

        [Required]
        public Category Category { get; set; }
    }
}
