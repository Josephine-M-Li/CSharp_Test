using CSharp_Test.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CSharp_Test.Data;

public class CSharp_TestContext : IdentityDbContext<CSharp_TestUser>
{
    public CSharp_TestContext(DbContextOptions<CSharp_TestContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);

        builder.ApplyConfiguration(new CSharp_TestUserEntityConfiguration());

    }
}

public class CSharp_TestUserEntityConfiguration:IEntityTypeConfiguration<CSharp_TestUser>
{

    public void Configure(EntityTypeBuilder<CSharp_TestUser> builder)
    {
        builder.Property(u => u.name).HasMaxLength(255);
        builder.Property(u => u.email).HasMaxLength(255);
    }

    //public Guid id { get; set; }
    //public string org_id { get; set; }
    //public string name { get; set; }
    //public string birthday { get; set; }
    //public string email { get; set; }
    //public string account { get; set; }
    //public string password { get; set; }
    //public int status { get; set; }
    //public DateTime created_at { get; set; }
    //public DateTime updated_at { get; set; }


}
