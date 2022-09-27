using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Foo.Models
{
    public class Applicant
    {
        [Key]
        public int id { get; set; }

        [Required]
        [StringLength(150)]
        public string Name { get; set; }

        [Required]
        [StringLength(10)]
        public string Gender { get; set; }

        [Required]
        [Range(25, 55, ErrorMessage = "Error")]
        [DisplayName("Age in Years")]
        public int Age { get; set; }


        [Required]
        [Range(1, 25, ErrorMessage = "Error")]
        [DisplayName("Total Experience in Years")]
        public int TotalExperience { get; set; }


        public List<Experience> Experiences { get; set; } = new List<Experience>();
    }
}
