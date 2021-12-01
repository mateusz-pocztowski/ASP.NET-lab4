using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcBooks.Data;
using System;
using System.Linq;
namespace MvcBooks.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcBooksContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcBooksContext>>()))
            {
                // Look for any movies.
                if (context.Books.Any())
                {
                    return;   // DB has been seeded
                }
                context.Books.AddRange(
                    new Books
                    {
                        Title = "The Hobbit",
                        Author = "J. R. R. Tolkien",
                        Genre = "Fantasy",
                    },
                    new Books
                    {
                        Title = "Harry Potter and the Philosopher's Stone",
                        Author = "J. K. Rowling",
                        Genre = "Fantasy",
                    },
                    new Books
                    {
                        Title = "And Then There Were None",
                        Author = "Agatha Christie",
                        Genre = "Mystery",
                    },
                    new Books
                    {
                        Title = "The Da Vinci Code",
                        Author = "Dan Brown",
                        Genre = "Mystery thriller",
                    }
                );
                context.SaveChanges();
            }
        }
    }
}