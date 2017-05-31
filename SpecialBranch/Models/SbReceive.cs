using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SpecialBranch.Models
{
    public class SbReceive
    {
        public int Id { get; set; }
        [Required]
        public int SbDsbId { get; set; }
        [Required]
        [StringLength(15, ErrorMessage = "Must be 15 character long", MinimumLength = 15)]
        public string EId { get; set; }
        public DateTime DrDate { get; set; }
        public DateTime DrTime { get; set; }


        public string Status { get; set; }
        public string Remarks { get; set; }
        public int DId { get; set; }
        public SbDsb SbDsb { get; set; }

    }
}