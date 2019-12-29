using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Coursemanager.Models
{
    public class Test
    {
        [key]
        [Required]
        public int Id { get; set; }

        [StringLength(20)]
        public string Name { get; set; }
    }
}