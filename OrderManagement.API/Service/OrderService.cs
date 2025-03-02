using OrderManagement.Domain.Entities;
using OrderManagement.Domain.Repositories;

namespace OrderManagement.API.Service
{
    public class OrderService
    {
        
            private readonly IOrderRepository _orderRepository;

            public OrderService(IOrderRepository orderRepository)
            {
                _orderRepository = orderRepository;
            }

            public async Task<List<Order>> GetAllOrdersAsync()
            {
                return await _orderRepository.GetAllAsync();
            }

            public async Task AddOrderAsync(string customerName, decimal totalPrice)
            {
                var order = new Order(customerName, totalPrice);
                await _orderRepository.AddAsync(order);
            }
        
    }
   
}
