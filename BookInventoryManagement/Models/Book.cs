using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookInventoryManagement.Models
{
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int bookId { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public string isbn { get; set; }
        public string publisher { get; set; }
        public DateTime year { get; set; }
    }
}
