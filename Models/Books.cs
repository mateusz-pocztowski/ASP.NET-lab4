using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcBooks.Models
{
    public class Books
    {
        [Key]
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Title { get; set; }

        [StringLength(60, MinimumLength = 3)]
        public string Author { get; set; }

        [StringLength(30, MinimumLength = 3)]
        public string Genre { get; set; }
    }
}