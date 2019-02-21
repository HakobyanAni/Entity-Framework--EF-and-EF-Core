using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;

namespace EF_ModelFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ModelFirst_EFContainer db = new ModelFirst_EFContainer();

                Author author1 = new Author()
                {
                    FirstName = "Theodore",
                    LastName = "Dreiser",
                    BirthDeathDate = "1871 -1945",
                    BirthPlace = "Terre Haute, Indiana",
                    Nationality = "American"
                };

                Author author2 = new Author()
                {
                    FirstName = "Somerset ",
                    LastName = "Maugham",
                    BirthDeathDate = "1874 -1965",
                    BirthPlace = "Paris",
                    Nationality = "British"
                };

                author1.Books = new List<Book>
                {
                    new Book()
                    {
                        Title = "An American Tragedy",
                        PublicationDate = 1925,
                        NumberOfPages = 896,
                        Genre = "Crime fiction",
                    },
                    new Book()
                    {
                        Title = "The Genius",
                        PublicationDate = 1915,
                        NumberOfPages = 952,
                        Genre = "-",
                    },
                    new Book()
                    {
                        Title = "The Financier",
                        PublicationDate = 1912,
                        NumberOfPages = 376,
                        Genre = "-",
                    }
                };


                author2.Books = new List<Book>
                {
                    new Book()
                    {
                        Title = "Liza of Lambeth",
                        PublicationDate = 1897,
                        NumberOfPages = 176,
                        Genre = "-",
                    },

                    new Book()
                    {
                        Title = "The Moon and Sixpence",
                        PublicationDate = 1919,
                        NumberOfPages = 288,
                        Genre = "Biographical novel",
                    }
                };

                db.Authors.Add(author1);
                db.Authors.Add(author2);

                db.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Console.WriteLine($"Entity of type \"{eve.Entry.Entity.GetType().Name}\" in state \"{eve.Entry.State}\" has the following validation errors:");
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine($"- Property: \"{ve.PropertyName}\", Error: \"{ve.ErrorMessage}\"");
                    }
                }
                throw;
            }

            Console.ReadKey();
        }
    }
}
