using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Welp.Models;

namespace Welp.DAL
{
    public class WelpInitializer : DropCreateDatabaseIfModelChanges<WelpContext>
    {
        protected override void Seed(WelpContext context)
        {
            // Add Business Type
            var businessTypes = new List<BusinessType>
            {
                new BusinessType { BusinessTypeName="Resturant" }
            };
            businessTypes.ForEach(bt => context.BusinessTypes.Add(bt));
            context.SaveChanges();

            // Add Business
            var businesses = new List<Business>
            {
                new Business { BusinessName="McDonalds", Address="1337 Uranus Ave Saturn, OH 44113",
                    Hours = " Mon - Fri: 6:00 am - 1:00 am, Sat - Sun: 7:00 am - 11:00 pm",
                    Phone = "(216)861-2799", Menu = "http://s3-media4.fl.yelpcdn.com/bphoto/zZzjnzvMPoToXJpej1AI8w/o.jpg"}
            };
            businesses.ForEach(b => context.Businesses.Add(b));
            context.SaveChanges();

            // Add User
            var users = new List<User>
            {
                new User { Username = "DosEquis", Password = "TheMostIntrestingMan", Email = "Dos@yahoo.com", Location = "Mars, OH" }
            };
            users.ForEach(u => context.Users.Add(u));
            context.SaveChanges();

            // Add Rating
            var ratings = new List<Rating>
            {
                new Rating { StarReview = StarReview.one, TextReview = "The big mac is ass, and cashiers were rude asked for a courtesy and got water" }
            };
            ratings.ForEach(r => context.Ratings.Add(r));
            context.SaveChanges();

            //base.Seed(context);
        }
    }
}