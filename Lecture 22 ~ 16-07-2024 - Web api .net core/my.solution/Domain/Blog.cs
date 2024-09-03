using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Blog
    {
        [Required]
        public string? Title { get; set; }
        [Required]
        public string? Description { get; set; }

    }
}
