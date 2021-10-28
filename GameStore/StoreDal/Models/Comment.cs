using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StoreDal.Models
{
    public class Comment
    {
        public string Name { get; set; }

        public string Body { get; set; }
        [Required]
        public virtual Game Game { get; set; }
    }
}
