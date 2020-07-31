using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ThisneyTicket.Domain.Interface;

namespace ThisneyTicket.Infra.Data.Context
{
    public class BaseContext : DbContext
    {
        public BaseContext(DbContextOptions<BaseContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var typesToRegister = AppDomain.CurrentDomain.GetAssemblies().SelectMany(x => x.GetTypes())
                .Where(x => typeof(IEntityConfig).IsAssignableFrom(x) && !x.IsAbstract).ToList();

            foreach (var type in typesToRegister)
            {
                dynamic configurationInstance = Activator.CreateInstance(type);
                modelBuilder.ApplyConfiguration(configurationInstance);
            }
        }
    }
}
