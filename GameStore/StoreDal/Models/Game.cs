using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;
using System.Text;

namespace StoreDal.Models
{
    public class Game
    {
        [Required]
        [Key]
        public string Key { get; set; }
               
        public string Name { get; set; }

        public string Description { get; set; }

        public virtual List<Comment> Comments { get; set; } 
    }
}
