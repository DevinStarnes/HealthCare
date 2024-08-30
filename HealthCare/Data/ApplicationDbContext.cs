using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using HealthCare.Models;

namespace HealthCare.Data
{
    public class ApplicationDbContext : IdentityDbContext<HealthCareUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
