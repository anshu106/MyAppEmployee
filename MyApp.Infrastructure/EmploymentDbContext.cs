namespace MyApp.Infrastructure
{
    public class EmploymentDbContext : DbContext
    {
        public EmploymentDbContext(DbContextOptions<EmploymentDbContext> options):
        base(options)
        {}
        public DbSets<EmployeeModel> Employees{get;set;}
        
    }
}