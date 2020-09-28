using Blog.Core.Mvc.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Core.Mvc.Data
{
    public class MysqlDbContext : DbContext
    {
        public MysqlDbContext(DbContextOptions<MysqlDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseMySql("这里填Mysql链接字符串");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Administrator>(entity =>
            {
                entity.Property(t => t.UserPwd).HasDefaultValue("admin888");
            });
        }

        public DbSet<Administrator> administrators { get; set; }

    }
}
