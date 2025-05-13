using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APIPractice.infrastucture;
using APIPractice.infrastucture.Models;
using Microsoft.EntityFrameworkCore;

namespace APIPractice.infrastucture
{
    public class APIPracticeDBConttext : DbContext
    {
        private readonly static string CONN_STRING = "Server=R125-08;Database=APIPractice_ToDo;User=main_db_user;Password=p@555w0rd;TrustServerCertificate=True;";

        public APIPracticeDBConttext() 
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(CONN_STRING);
        }

        public DbSet<UserDetail> UserDetails { get; set; }
        public DbSet<ToDoItem> ToDoItems { get; set; }
        public DbSet<Category> cCtegories { get; set; }
        public DbSet<ToDoCategory> ToDoCategories { get; set; }
    }
}
