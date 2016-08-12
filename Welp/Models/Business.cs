using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Welp.Models
{
    public class Business
    {   
        [Key]
        public int ID { get; set; }
        [MaxLength(50)]
        public string BusinessName { get; set; }
        [MaxLength(100)]
        public string Address { get; set; }
        [MaxLength(100)]
        public string Hours { get; set; }
        [MaxLength(50)]
        public string Phone { get; set; }
        public string Menu { get; set; }

        // Foreign Keys
        public int BusinessTypeID { get; set; }
        public int? UserID { get; set; }

        // Navigation
        public virtual BusinessType BusinessType { get; set; }
        public virtual User User { get; set; }

        public virtual ICollection<Rating> Ratings { get; set; }
    }
}