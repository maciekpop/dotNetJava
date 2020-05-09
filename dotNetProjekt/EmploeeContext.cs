using Microsoft.EntityFrameworkCore;

namespace dotNetProjekt
{
    public class EmploeeContext : DbContext
    {
        public DbSet<Employee> employees { get; set; }

        public DbSet<WorkTime> workTimes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseOracle(@"User Id=FIRMA;Password=rk7;Data Source=(DESCRIPTION = " +
" (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))" +
"(CONNECT_DATA =" +
 " (SERVER = DEDICATED)" +
  "(SERVICE_NAME = XEPDB1)" +
"));");
        }
    }
}
