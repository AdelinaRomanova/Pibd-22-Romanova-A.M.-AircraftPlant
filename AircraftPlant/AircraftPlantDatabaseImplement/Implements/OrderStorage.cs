using AircraftPlantContracts.BindingModels;
using AircraftPlantContracts.StoragesContracts;
using AircraftPlantContracts.ViewModels;
using AircraftPlantDatabaseImplement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AircraftPlantDatabaseImplement.Implements
{
    public class OrderStorage : IOrderStorage
    {
        public List<OrderViewModel> GetFullList()
        {
            using var context = new AircraftPlantDatabase();
            return context.Orders
                .Include(rec => rec.Planes)
                .Select(rec => new OrderViewModel
                {
                    Id = rec.Id,
                    PlaneId = rec.PlaneId,
                    PlaneName = rec.Planes.PlaneName,
                    Count = rec.Count,
                    Sum = rec.Sum,
                    Status = rec.Status.ToString(),
                    DateCreate = rec.DateCreate,
                    DateImplement = rec.DateImplement,
                    ClientId = rec.ClientId,
                    ClientFIO = rec.Client.ClientFIO
                })
                .ToList();
        }

        public List<OrderViewModel> GetFilteredList(OrderBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using var context = new AircraftPlantDatabase();
            return context.Orders
                .Include(rec => rec.Planes)
                .Include(rec => rec.Client)
                .Where(rec => rec.PlaneId == model.PlaneId 
                || (model.DateFrom.HasValue && model.DateTo.HasValue && rec.DateCreate >= model.DateFrom && rec.DateCreate <= model.DateTo) 
                || model.ClientId.HasValue && rec.ClientId == model.ClientId)
                .ToList()
                .Select(CreateModel)
                .ToList();
        }

        public OrderViewModel GetElement(OrderBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using var context = new AircraftPlantDatabase();
            var order = context.Orders
            .Include(rec => rec.Planes)
            .FirstOrDefault(rec => rec.Id == model.Id || rec.Id == model.Id);
            return order != null ? CreateModel(order) : null;
        }

        public void Insert(OrderBindingModel model)
        {
            using var context = new AircraftPlantDatabase();
            using var transaction = context.Database.BeginTransaction();
            try
            {
                context.Orders.Add(CreateModel(model, new Order()));
                context.SaveChanges();
                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
        }

        public void Update(OrderBindingModel model)
        {
            using var context = new AircraftPlantDatabase();
            using var transaction = context.Database.BeginTransaction();
            try
            {
                var element = context.Orders.FirstOrDefault(rec => rec.Id == model.Id);
                if (element == null)
                {
                    throw new Exception("Элемент не найден");
                }
                CreateModel(model, element);
                context.SaveChanges();
                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
        }

        public void Delete(OrderBindingModel model)
        {
            using var context = new AircraftPlantDatabase();
            Order element = context.Orders.FirstOrDefault(rec => rec.Id == model.Id);
            if (element != null)
            {
                context.Orders.Remove(element);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Заказ не найден");
            }
        }
        public static Order CreateModel(OrderBindingModel model, Order order)
        {
            order.PlaneId = model.PlaneId;
            order.ClientId = (int)model.ClientId;
            order.Count = model.Count;
            order.Sum = model.Sum;
            order.Status = model.Status;
            order.DateCreate = model.DateCreate;
            order.DateImplement = model.DateImplement;
            return order;
        }
        public OrderViewModel CreateModel(Order order)
        {
            return new OrderViewModel
            {
                Id = order.Id,
                ClientId = order.ClientId,
                ClientFIO = order.Client.ClientFIO,
                PlaneId = order.PlaneId,
                PlaneName = order.Planes.PlaneName,
                Count = order.Count,
                Sum = order.Sum,
                Status = order.Status.ToString(),
                DateCreate = order.DateCreate,
                DateImplement = order.DateImplement
            };
        }
    }
}
