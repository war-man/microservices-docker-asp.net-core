using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Rating_services.Infastructure;
using Rating_services.Models;

namespace Rating_services.Repository
{
    public interface IOrderRepository : IRepository<Order>
    {

    }
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        Rating_Context _Context;
        public OrderRepository(Rating_Context context) : base(context)
        {
            _Context = context;
        }
        public override void Update(Order entity)
        {
            Order target = _Context.Orders.Where(c => c.Id == entity.Id).FirstOrDefault();
            _Context.Entry(target).CurrentValues.SetValues(entity);
            _Context.SaveChanges();
        }
    }
}