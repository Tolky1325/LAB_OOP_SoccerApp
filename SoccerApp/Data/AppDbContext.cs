using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SoccerApp
{
    internal class AppDbContext : DbContext
    {
        public AppDbContext()
        {
            Database.EnsureCreated();
        }  
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(@"server=127.0.0.1;port=3306;database=soccer_db;username=root;password=");
        }
   
        public DbSet<Admin> AdminTable { get; set; }
        public DbSet<Fan> FanTable { get; set; }
        public DbSet<SoccerTeam> SoccerTeamTable { get; set; }
        public DbSet<Tournament> TournamentTable { get; set; }
    }
}
