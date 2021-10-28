using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataAccessLayer.Models
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
