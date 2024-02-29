using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAppFilter.Models
{
    public class SignIn
    {
        [Required]
        [Display(Name ="User Name")]
        public string  UserName { get; set; }

        [Required]
        [Display(Name ="User Password")]
        [DataType(DataType.Password)]   
        public string Password { get; set; }
    }
}