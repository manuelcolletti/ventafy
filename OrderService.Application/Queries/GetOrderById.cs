using MediatR;
using OrderService.Application.DTOs;
using OrderService.Domain.Repositories;

namespace OrderService.Application.Queries;

public class GetOrderByIdQuery : IRequest<OrderDto>
{
    public int OrderId { get; set; }
}

public class GetOrderByIdQueryHandler(IOrderRepository orderRepository) 
    : IRequestHandler<GetOrderByIdQuery, OrderDto>
{
    public async Task<OrderDto> Handle(GetOrderByIdQuery request, CancellationToken cancellationToken)
    {
        var order = await orderRepository.GetOrderByIdAsync(request.OrderId)
            ?? throw new KeyNotFoundException($"Order with ID {request.OrderId} not found.");

        return new OrderDto
        {
            Id = order.Id,
            CustomerName = order.CustomerName,
            ProductIds = order.ProductIds,
            TotalAmount = order.TotalAmount,
            CreatedAt = order.CreatedAt
        };
    }
}
