using ApiEnglishv1.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiEnglishv1.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        //private readonly IConfiguration configuration;
        //public DataContext(IConfiguration configuration)
        //{
        //    this.configuration = configuration;
        //}
        public DbSet<Classroom> Classrooms { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
