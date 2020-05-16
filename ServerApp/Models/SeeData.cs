using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerApp.Models
{
    public class SeedData
    {

        public static void SeedDatabase(DataContext context)
        {

            context.Database.Migrate();

            if (context.People.Count() == 0)
            {


                context.People.AddRange(
                    new Person
                    {
                        LasttName = "Ostermann",
                        FirstName = "Troy",
                        Address = "Breey Point, MN",
                        Age = 46,
                        Interests = "Baseball, Computers",
                        Picture = "insert picure"
                    },
                    new Person
                    {
                        LasttName = "Romo",
                        FirstName = "Tony",
                        Address = "Dallas, Texas",
                        Age = 40,
                        Interests = "Football",
                        Picture = "insert picure"
                    },
                    new Person
                    {
                        LasttName = "Doe",
                        FirstName = "Tony",
                        Address = "Jacksonville, Florida",
                        Age = 40,
                        Interests = "Angular, Web Design",
                        Picture = "insert picure"
                    },
                    new Person
                    {
                        LasttName = "Fudd",
                        FirstName = "Elmer",
                        Address = "Warner Brothers, Animation",
                        Age = 83,
                        Interests = "Hat, Hunting Wabbits ",
                        Picture = "insert picure"
                    },
                    new Person
                    {
                        LasttName = "Flinstone",
                        FirstName = "Fred",
                        Address = "1000 Rock Lane, Bedrock",
                        Age = 60,
                        Interests = "Bowling, TV",
                        Picture = "insert picure"
                    },
                    new Person
                    {
                        LasttName = "Doo",
                        FirstName = "Scooby",
                        Address = "Mystery City, USA",
                        Age = 7,
                        Interests = "True Crime, Scooby snacks",
                        Picture = "insert picure"
                    },
                    new Person
                    {
                        LasttName = "Ostermann",
                        FirstName = "Nichole",
                        Address = "Breey Point, MN",
                        Age = 34,
                        Interests = "Dogs, Reading, The Office",
                        Picture = "insert picure"}); 
                context.SaveChanges();
            }
        }
    }


}
