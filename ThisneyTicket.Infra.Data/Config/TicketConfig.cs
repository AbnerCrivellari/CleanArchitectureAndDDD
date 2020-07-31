using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using ThisneyTicket.Domain.Interface;
using ThisneyTicket.Domain.Model;

namespace ThisneyTicket.Infra.Data.Config
{
    public class TicketConfig : BaseConfig<Ticket>, IEntityTypeConfiguration<Ticket>, IEntityConfig
    {
        public void Configure(EntityTypeBuilder<Ticket> builder)
        {
            DefaultConfigs(builder, tableName: "Ticket");

            builder.Property(x => x.Code).IsRequired();
        }
    }
}
