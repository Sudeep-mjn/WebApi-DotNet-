using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using trackingapi.Models;

namespace trackingapi.Data
{
    public class IssueDbContext : DbContext
    {
        public IssueDbContext(DbContextOptions<IssueDbContext> options)
            : base(options)
        {
        }

        public DbSet<Issues> Issues { get; set; }
    }

}
 