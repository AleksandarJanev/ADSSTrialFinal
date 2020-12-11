using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrialFinal.Models
{
    public class ArtistModel
    {
        [Required(ErrorMessage ="Please enter a First Name.")]
        [Display(Name ="First Name")]
        public string FirstName { get; set; }
        
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Please enter a Last Name.")]
        public string LastName { get; set; }


    }
}