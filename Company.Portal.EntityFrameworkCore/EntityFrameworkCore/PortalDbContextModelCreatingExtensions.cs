using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace Company.Portal.EntityFrameworkCore
{
    public static class PortalDbContextModelCreatingExtensions
    {
        public static void ConfigurePortal(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(PortalConsts.DbTablePrefix + "YourEntities", PortalConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}