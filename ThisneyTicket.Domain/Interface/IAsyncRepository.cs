﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ThisneyTicket.Domain.Model;

namespace ThisneyTicket.Domain.Interface
{
    public interface IAsyncRepository<T> where T : Base, IEntityConfig
    {
        Task<T> GetByIdAsync(int id);
        Task<IEnumerable<T>> ListAllAsync();
        Task<T> AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
    }
}

