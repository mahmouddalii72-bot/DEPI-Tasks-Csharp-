using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Day3.Models
{

    //    Q1: Why did the property "Id" become a Primary Key without any explicit configuration?
    //answer :==> Entity Framework Core follows naming conventions

    //Q2: Why is "Country" nullable in the database while "Price" is not?
// answer :==>     - "Country" is defined as "string?" which is a nullable reference type, so it becomes NULL in SQL
   //              - "Price" is defined as "decimal" which is a value type and cannot be null, so it becomes NOT NUll
    internal class Book
    {

        //public int Id { get; set; }
        //public string Title { get; set; }
        //public decimal Price { get; set; }
        //public DateTime? PublishedDate { get; set; }



        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(150)]


        public string Title { get; set; }

        [Required]
        public decimal Price { get; set; }

        // implicit mapping
        [Column(TypeName = "DateTime")]
        public DateTime? PublishedDate { get; set; }
    }
}
