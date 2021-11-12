using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CrystalMind.Models
{
    public class Adress
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [DisplayFormat(NullDisplayText = "No Street Selected")]
        public string Street { get; set; }
        [DisplayFormat(NullDisplayText = "No City Selected")]
        public string City { get; set; }
        public int CustomerID { get; set; }
        public Customer Customer { get; set; }
    }
}
