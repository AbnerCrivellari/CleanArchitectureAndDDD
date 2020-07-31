using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using ThisneyTicket.Domain.Model;

namespace ThisneyTicket.Infra.Data.Config
{
    public class BaseConfig<TEntity> where TEntity : Base
    {
        public void DefaultConfigs(EntityTypeBuilder<TEntity> builder, string tableName)
        {
            builder.ToTable(tableName);
            builder.HasKey(x => x.Id);

            builder.Property(x => x.CreatedAt).HasDefaultValue(DateTime.Now).IsRequired();
            builder.Property(x => x.CreatedBy).IsRequired();
        }
    }
}
