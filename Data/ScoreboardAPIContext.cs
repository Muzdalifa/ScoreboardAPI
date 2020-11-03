using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ScoreboardAPI.Models;

namespace ScoreboardAPI.Data
{
    public class ScoreboardAPIContext : DbContext
    {
        public ScoreboardAPIContext (DbContextOptions<ScoreboardAPIContext> options)
            : base(options)
        {
        }

        public DbSet<ScoreboardAPI.Models.Record> Record { get; set; }
    }
}
