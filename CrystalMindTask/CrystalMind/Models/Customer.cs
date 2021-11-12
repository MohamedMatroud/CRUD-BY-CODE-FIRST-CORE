using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CrystalMind.Models
{
    public class Customer
    {
         public int CustomerID { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "last Name")]
        public string CustomerLastName { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "First Name")]
        public string CustomerFirstName { get; set; }
        [Required]
        [StringLength(1)]
        [Display(Name = "Gender")]
        [Column(TypeName = "char")]
        public string CustomerGender { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Birth Date")]
        public DateTime CustomerDOB { get; set; }
        [Display(Name = "Email")]
        [EmailAddress]
        public string CustomerEmail { get; set; }
        public ICollection<Adress> Adresses { get; set; }
    }
}
