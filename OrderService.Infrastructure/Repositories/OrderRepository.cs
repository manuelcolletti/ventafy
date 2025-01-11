using OrderService.Domain.Entities;
using OrderService.Domain.Repositories;

namespace OrderService.Infrastructure.Repositories;
public class OrderRepository : IOrderRepository
{
    public Task AddOrderAsync(Order order)
    {
        throw new NotImplementedException();
    }

    public Task<Order> GetOrderByIdAsync(int orderId)
    {
        throw new NotImplementedException();
    }
}
