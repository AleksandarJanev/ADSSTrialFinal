using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrialFinal.Models
{
    public class SongModel
    {
        [Display(Name ="Song Name")]
        [Required(ErrorMessage ="Please enter the Song's name.")]
        public string SongName { get; set; }

        [Display(Name ="Song Length(must be of format minutes:seconds)")]
        [Range(0, 150, ErrorMessage = "Song length must be a valid number")]
        [Required(ErrorMessage = "Please enter the Song's lenght.")]
        public string SongLength { get; set; }
    }
}