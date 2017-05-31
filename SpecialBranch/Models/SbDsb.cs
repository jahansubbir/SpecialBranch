using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SpecialBranch.Models
{
    public class SbDsb
    {
        public int Id { get; set; }
        [Required]
        public int RpoId { get; set; }
        [Required]
        public int Name { get; set; }
        public Rpo Rpo { get; set; }
    }
}