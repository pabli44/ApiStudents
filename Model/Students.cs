using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApiStudents.Model
{
    [Table("Student")]
    public class Students
    {
        [Column("Id")]
        [Key]
        [Required]
        public long idStudent { get; set; }

        [Column("Username")]
        [Required]
        [StringLength(20)]
        public string userName { get; set; }

        [Column("FirstName")]
        [Required]
        [StringLength(20)]
        public string firstName { get; set; }

        [Column("LastName")]
        [Required]
        [StringLength(20)]
        public string lastName { get; set; }

        [Column("Age")]
        [Required]
        public long age { get; set; }

        [Column("Career")]
        [Required]
        [StringLength(50)]
        public string career { get; set; }
    }
}
