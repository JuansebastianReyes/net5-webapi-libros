using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using my_books.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_books.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder aplicationBuilder)
        {
            using (var serviceScope = aplicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                if (!context.Books.Any())
                {
                    context.Books.AddRange(new Book()
                    {
                        Title = "Cien años de soledad",
                        Description = "Rebeca es una niña huérfana que llega a Macondo, tras un pronóstico hecho por Aureliano Buendía.",
                        IsRead = true,
                        DateRead = DateTime.Now.AddDays(-10),
                        Rate = 4,
                        Genere = "Realismo mágico",
                        Author = "Gabriel García Márquez",
                        CoverUrl = "https..", //url de la portada del libro 
                        DareAdded = DateTime.Now,
                    }, new Book()
                    {
                        Title = "Don Quijote de la Mancha",
                        Description = "Don Quijote de la Mancha​ es una novela escrita por el español Miguel de Cervantes Saavedra.",
                        IsRead = false,
                        Genere = "Novela",
                        Author = "Miguel de Cervantes",
                        CoverUrl = "https..", //url de la portada del libro 
                        DareAdded = DateTime.Now,
                    });

                    context.SaveChanges();
                }
            }
        }
    }
}
