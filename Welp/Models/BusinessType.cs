using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Welp.Models
{
    public class BusinessType
    {
        [Key]
        public int BusinessTypeID { get; set; }
        [MaxLength(50)]
        public string BusinessTypeName { get; set; }

        // Navigation
        public virtual ICollection<Business> Businesses { get; set; }
    }
}