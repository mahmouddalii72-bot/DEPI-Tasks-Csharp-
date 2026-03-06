using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Day3.Models
{

    [Table("Writers")]
    internal class Author
    {

        //public int Id { get; set; }
        //public string Name { get; set; }
        //public string? Country { get; set; }

        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(100)]
        public string Name { get; set; }


        public String Conutery { get; set; }
    }
}
