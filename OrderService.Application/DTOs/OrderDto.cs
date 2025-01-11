namespace OrderService.Application.DTOs
{
    /// <summary>
    /// DTO para representar una orden.
    /// </summary>
    public class OrderDto
    {
        /// <summary>
        /// Identificador único de la orden.
        /// </summary>
        public int Id { get; set; }

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

        /// <summary>
        /// Fecha y hora en la que se creó la orden.
        /// </summary>
        public DateTime CreatedAt { get; set; }
    }
}
