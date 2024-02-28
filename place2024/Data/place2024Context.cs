using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using place2024.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace place2024.Data
{
    public class place2024Context : IdentityDbContext
    {
        public place2024Context (DbContextOptions<place2024Context> options)
            : base(options)
        {
        }

        //--
        // DBset pour la table des publications
        public DbSet<place2024.Models.Publication> Publication { get; set; } = default!;
     
        //--
    }
}
