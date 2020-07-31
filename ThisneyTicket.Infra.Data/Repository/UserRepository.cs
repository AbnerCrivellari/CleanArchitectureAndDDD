using System;
using System.Collections.Generic;
using System.Text;
using ThisneyTicket.Domain.Interface;
using ThisneyTicket.Domain.Model;
using ThisneyTicket.Infra.Data.Config;
using ThisneyTicket.Infra.Data.Context;

namespace ThisneyTicket.Infra.Data.Repository
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(BaseContext dbContext) : base(dbContext)
        {
        }
    }
}
