// Added data annotations using _ViewImports
using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace DojoLeague.Models
{
    // Class for Dojos
    public class Dojo
    {
        // model properties must match SQL table column names!!!!
        [Key]
        public long dojo_id { get; set; }
        [Display(Name="Dojo Name")]
        [Required(ErrorMessage = "The name of the Dojo is required!")]
        [MinLength(5, ErrorMessage = "The name of the Dojo must be at least 5 characters!")]
        public string name { get; set; }
        [Display(Name="Dojo Location")]
        [Required(ErrorMessage = "The location of the Dojo is required!")]
        [MinLength(5, ErrorMessage = "The location of the Dojo must be at least 5 characters!")]
        public string location { get; set; }
        [Display(Name="Dojo Description")]
        [Required(ErrorMessage = "A description of the Dojo is required!")]
        [MinLength(20, ErrorMessage = "The Dojo's description must be at least 20 characters!")]
        public string description { get; set; }
        public DateTime created_at { get; set; }

        // A given Dojo may have many Ninjas so this populates a list of players
        public IEnumerable<Ninja> ninjas { get; set; }

        // this actually populates the Dojo's list of ninjas on creation
        public Dojo() {
            ninjas = new List<Ninja>();
        }
    }
}