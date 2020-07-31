using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ThisneyTicket.Domain.Interface;
using ThisneyTicket.Domain.Model;

namespace ThisneyTicket.Infra.Data.Config
{
    class UserConfig : BaseConfig<User>, IEntityTypeConfiguration<User>, IEntityConfig
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            DefaultConfigs(builder, tableName: "User");

            builder.Property(x => x.Name).HasMaxLength(45).IsRequired();
            builder.Property(x => x.Document).HasMaxLength(15).IsRequired();
            builder.Property(x => x.BirthDate).IsRequired();

            builder.HasMany(x => x.Ticket).WithOne(x => x.User).HasForeignKey(x => x.UserId);
        }
    }
}
