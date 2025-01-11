using MediatR;
using OrderService.Domain.Entities;
using OrderService.Domain.Repositories;

namespace OrderService.Application.Commands
{
    /// <summary>
    /// Comando para crear una orden.
    /// </summary>
    public class CreateOrderCommand : IRequest<int>
    {
        /// <summary>
        /// Nombre del cliente que realiza la orden.
        /// </summary>
        public required string CustomerName { get; set; }

        /// <summary>
        /// Lista de identificadores de productos incluidos en la orden.
        /// </summary>
        public required List<string> ProductIds { get; set; }

        /// <summary>
        /// Monto total de la orden.
        /// </summary>
        public decimal TotalAmount { get; set; }
    }

    /// <summary>
    /// Manejador del comando para crear una orden.
    /// </summary>
    /// <param name="orderRepository"></param>
    public class CreateOrderCommandHandler(IOrderRepository orderRepository) 
        : IRequestHandler<CreateOrderCommand, int>
    {
        public async Task<int> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            var order = new Order
            {
                CustomerName = request.CustomerName,
                ProductIds = request.ProductIds,
                TotalAmount = request.TotalAmount,
                CreatedAt = DateTime.UtcNow
            };

            await orderRepository.AddOrderAsync(order);

            return order.Id;
        }
    }
}
