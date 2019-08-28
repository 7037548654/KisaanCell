using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ContactBook.Models
{
    public class Contact
    {
        
            
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            [Key]
            public int Id { get; set; }
            [Required]
            public string Item { get; set; }
            [Required]
            public int Quantity { get; set; }
            [Required]
            public int Price { get; set; }
            [Required]
            public string Location { get; set; }
            

            [ForeignKey("UserId")]
            public int UserId { get; set; }
        
    }
}