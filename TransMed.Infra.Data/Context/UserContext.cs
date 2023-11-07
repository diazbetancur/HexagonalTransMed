using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransMed.Dominio.Entity;
using TransMed.Infra.Data.Config;

namespace TransMed.Infra.Data.Context
{
    public class UserContext :DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder op)
        {
           // op.UseSqlServer("ConnextionDB");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new UserConfig());
        }
    }
}
