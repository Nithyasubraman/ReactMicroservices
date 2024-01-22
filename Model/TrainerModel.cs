using System.ComponentModel.DataAnnotations;

namespace Trainer.Data
{
    public class Trainer

    {
        [Key]
        public int Id { get; set; }

        [Required]

        public string? Name { get; set; }

        [Required]

        public string? Designation { get; set; }

        [Required]

        public long PhoneNumber { get; set; }



    }
}