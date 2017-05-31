using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SpecialBranch.Models
{
    public class RpoLogin
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Select RPO")]
        public int RpoId { get; set; }
        [Required(ErrorMessage = "User Name cannot be empty")]
        public string UserId { get; set; }
        [Required(ErrorMessage = "Password cannot be empty")]
        [PasswordPropertyText(true)]
        public string Password { get; set; }
        public Rpo Rpo { get; set; }
    }
}