// Added data annotations using _ViewImports
using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace DojoLeague.Models
{
    // Class for Ninjas
    public class Ninja
    {
        // model properties must match SQL table column names!!!!
        [Key]
        public long ninja_id { get; set; }
        [Display(Name="Ninja Name")]
        [Required(ErrorMessage = "A name for the ninja is required!")]
        [MinLength(3, ErrorMessage = "A ninja's name must be at least 3 characters!")]
        public string name { get; set; }
        [Display(Name="Ninja Level")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "You cheated! Levels must only be integers!")]
        [Range(1,10,ErrorMessage = "You cheated! Levels can only be between 1 and 10!")]
        public int level { get; set; }
        [Display(Name="Ninja Description")]
        public string description { get; set; }
        public DateTime created_at { get; set; }

        // The foreign key value for the associated Dojo (will be saved in the db)
        [Display(Name="Ninja Home Dojo")]
        [RegularExpression(@"^[1-9]|10*$", ErrorMessage = "You cheated! Levels must only be integers between 1-10!")]
        public int? dojo_id { get; set; }
        
        // A give Ninja will be associated with a specific Dojo
        // The Ninja isn't saved with the whole Dojo object in the DB
        // Having this object makes it much easier to interact with the Ninja
        // instance in the rest of the code
        public Dojo dojo { get; set; }

    }
}