using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using ThisneyTicket.Domain.Interface;
using ThisneyTicket.Domain.Model;

namespace ThisneyTicket.Infra.Data.Config
{
    public class EventConfig : BaseConfig<Event>, IEntityTypeConfiguration<Event>, IEntityConfig
    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {
            DefaultConfigs(builder, tableName: "Ticket");

            builder.Property(x => x.Name).HasMaxLength(45).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(255).IsRequired();
            builder.Property(x => x.Date).IsRequired();
            builder.Property(x => x.Quantity).IsRequired();
            builder.Property(x => x.TypeEvent).IsRequired();

            builder.HasMany(x => x.Ticket).WithOne(x => x.Event).HasForeignKey(x => x.EventId);
        }
    }
}
