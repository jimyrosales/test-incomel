using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using jimyTest.Models;

    public class jimytest : DbContext
    {
        public jimytest (DbContextOptions<jimytest> options)
            : base(options)
        {
        }

        public DbSet<jimyTest.Models.Usuario> Usuario { get; set; } = default!;

        public DbSet<jimyTest.Models.Employee>? Employee { get; set; }
    }
