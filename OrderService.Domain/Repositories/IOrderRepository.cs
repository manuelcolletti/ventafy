﻿using OrderService.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderService.Domain.Repositories
{
    public interface IOrderRepository
    {
        Task AddOrderAsync(Order order);
        Task<Order> GetOrderByIdAsync(int orderId);
    }
}
