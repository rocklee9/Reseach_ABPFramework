using Microsoft.EntityFrameworkCore;
using Tcx.xdcb.Entities;
using Volo.Abp;

namespace Tcx.xdcb.EntityFrameworkCore
{
    public static class xdcbDbContextModelCreatingExtensions
    {
        public static void Configurexdcb(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            builder.Entity<DMHangMucCongTrinh>(b =>
            {
                b.ToTable(xdcbConsts.DbTablePrefix + "DMHangMucCongTrinh", xdcbConsts.DbSchema);
                b.Property(s => s.MaHangMucCT).HasMaxLength(10);
                b.Property(s => s.TenHangMucCT).HasMaxLength(255);
                b.Property(s => s.GhiChu).HasMaxLength(255);
            });
        }
    }
}