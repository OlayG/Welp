using System.ComponentModel.DataAnnotations;

namespace Welp.Models
{
    public enum StarReview
    {
        one = 1, two = 2, three = 3, four = 4, five = 5 

                // How to turn to num \\
        //StarReview getStars = StarReview.three;
        //int stars = (int) three;
    }

    public class Rating
    {   
        [Key]
        public int RatingID { get; set; }
        public StarReview? StarReview { get; set; }
        public string TextReview { get; set; }

        // Foreign Keys
        public int UserID { get; set; }
        public int BusinessID { get; set; }

        // Navigation
        public virtual Business Business { get; set; }
        public virtual User User { get; set; }
    }
}