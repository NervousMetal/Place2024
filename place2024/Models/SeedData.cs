using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using place2024.Data;
using System;
using System.Linq;

namespace place2024.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new place2024Context(
            serviceProvider.GetRequiredService<
                DbContextOptions<place2024Context>>()))
        {
            // Look for any movies.
            if (context.Publication.Any())
            {
                return;   // DB has been seeded
            }
            context.Publication.AddRange(
                new Publication
                {
                    PublicationTitle = "Le moulin de PAT",
                    PublicationDescription = "C'est un moulin à PAT",
                    PublicationDate = DateTime.Parse("2024-2-12"),
                    Categorie = "Monument historique",
             
                },
                    new Publication
                    {
                        PublicationTitle = "Le bain Morgan",
                        PublicationDescription = "C'est une piscine",
                        PublicationDate = DateTime.Parse("2024-2-12"),
                        Categorie = "Monument historique",

                    },

                                new Publication
                                {
                                    PublicationTitle = "Le musée Redpath",
                                    PublicationDescription = "C'est le premier musée en Amérique",
                                    PublicationDate = DateTime.Parse("2024-2-24"),
                                    Categorie = "Monument historique",

                                }


            );
            context.SaveChanges();
        }
    }
}
