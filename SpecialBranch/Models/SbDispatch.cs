using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace SpecialBranch.Models
{
    public class SbDispatch
    {
        public int Id { get; set; }
        public int SbDsbId { get; set; }
        [Required]
        [StringLength(15,ErrorMessage = "EID Must be 15 character length",MinimumLength = 15)]
        public string EId { get; set; }
        public DateTime DrDate { get; set; }
        public DateTime DrTime { get; set; }
        
       
        public string Status { get; set; }
        public string Remarks { get; set; }
        public SbDsb SbDsb { get; set; }


    }
}