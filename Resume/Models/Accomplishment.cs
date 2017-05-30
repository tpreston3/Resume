using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Resume.Models
{
    public class Accomplishment
    {

        public int ID { get; set; }

        [Required]
        [Display(Name = "Add a Major Accomplishment")]
        public string accomplishment { get; set; }

        /*How do you access the List of accomplishments from the AccomplishmentsController.cs class? 
         Should there be a seperate Accomplishments List<> class and a Accomplishment.cs class*/

        [Display(Name = "Major Accomplishments")] //update database
        public virtual List<Accomplishment> Accomplishments { get; set; }

        [Display(Name = "For Which Job?")]
        public int? JobID { get; set; }

        
    }
}