﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Welp.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }
        [MaxLength(50)]
        public string Username { get; set; }
        [MaxLength(50)]
        public string Password { get; set; }
        [MaxLength(100)]
        public string Email { get; set; }
        [MaxLength(100)]
        public string Location { get; set; }

        // Navication properties
        public virtual ICollection<Business> Businesses { get; set; }
        public virtual ICollection<Rating> Ratings { get; set; }
    }
}