using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AWSAppMVCMovie.Models;

namespace AWSAppMVCMovie.Data
{
    public class AWSAppMVCMovieContext : DbContext
    {
        public AWSAppMVCMovieContext (DbContextOptions<AWSAppMVCMovieContext> options)
            : base(options)
        {
        }

        public DbSet<AWSAppMVCMovie.Models.Book> Book { get; set; }
    }
}
