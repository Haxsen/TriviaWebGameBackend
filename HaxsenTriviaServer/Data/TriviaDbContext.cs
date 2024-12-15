using HaxsenTriviaServer.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace HaxsenTriviaServer.Data
{
    public class TriviaDbContext : DbContext
    {
        public TriviaDbContext(DbContextOptions<TriviaDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Score> Scores { get; set; }
    }
}