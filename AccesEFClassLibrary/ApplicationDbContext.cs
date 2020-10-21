using Microsoft.EntityFrameworkCore;
using System;

namespace AccesEFClassLibrary
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions opions)
            : base(opions)
        {

        }
    }
}
