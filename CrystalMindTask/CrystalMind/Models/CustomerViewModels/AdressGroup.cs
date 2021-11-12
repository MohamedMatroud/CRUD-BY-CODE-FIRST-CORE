using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrystalMind.Models.CustomerViewModels
{
    public class AdressGroup
    {
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]

        public DateTime? CustomerDOB { get; set; }

        public int CustomerCount { get; set; }
    }
}
