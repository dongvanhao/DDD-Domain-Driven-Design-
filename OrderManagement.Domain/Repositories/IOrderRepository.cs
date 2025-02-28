using OrderManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement.Domain.Repositories
{
    public interface IOrderRepository
    {
        Task<Order> GetByIdAsync(int id);
        Task<List<Order>> GetAllAsync();
        Task AddAsync(Order order);
    }
}
