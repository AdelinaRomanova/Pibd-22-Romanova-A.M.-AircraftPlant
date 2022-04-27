using System;
using System.Collections.Generic;
using AircraftPlantContracts.BindingModels;
using AircraftPlantContracts.BusinessLogicsContracts;
using AircraftPlantContracts.Enums;
using AircraftPlantContracts.StoragesContracts;
using AircraftPlantContracts.ViewModels;

namespace AircraftPlantBusinessLogic.BusinessLogics
{
	public class OrderLogic : IOrderLogic
	{
		private readonly IOrderStorage _orderStorage;
		private readonly IClientStorage _clientStorage;
		public OrderLogic(IOrderStorage orderStorage, IClientStorage clientStorage)
		{
			_orderStorage = orderStorage;
			_clientStorage = clientStorage;
		}
		public List<OrderViewModel> Read(OrderBindingModel model)
		{
			if (model == null)
			{
				return _orderStorage.GetFullList();
			}
			if (model.Id.HasValue)
			{
				return new List<OrderViewModel> { _orderStorage.GetElement(model) };
			}
			return _orderStorage.GetFilteredList(model);
		}
		public void CreateOrder(CreateOrderBindingModel model)
		{
			_orderStorage.Insert(new OrderBindingModel
			{
				PlaneId = model.PlaneId,
				Count = model.Count,
				Sum = model.Sum,
				DateCreate = DateTime.Now,
				Status = OrderStatus.Принят,
				ClientId = model.ClientId
			});
		}
		public void TakeOrderInWork(ChangeStatusBindingModel model)
		{
			var order = _orderStorage.GetElement(new OrderBindingModel { Id = model.OrderId });

			if (order == null)
			{
				throw new Exception("Заказ не найден");
			}
			if (order.Status != OrderStatus.Принят.ToString())
			{
				throw new Exception("Заказ не в статусе \"Принят\"");
			}
			_orderStorage.Update(new OrderBindingModel
			{
				Id = order.Id,
				PlaneId = order.PlaneId,
				Count = order.Count,
				Sum = order.Sum,
				DateCreate = order.DateCreate,
				DateImplement = DateTime.Now,
				Status = OrderStatus.Выполняется,
				ClientId = order.ClientId
			});
		}
		public void FinishOrder(ChangeStatusBindingModel model)
		{
			var order = _orderStorage.GetElement(new OrderBindingModel { Id = model.OrderId });
			if (order == null)
			{
				throw new Exception("Заказ не найден");
			}
			if (order.Status != OrderStatus.Выполняется.ToString())
			{
				throw new Exception("Заказ не в статусе \"Выполняется\"");
			}
			_orderStorage.Update(new OrderBindingModel
			{
				Id = order.Id,
				PlaneId = order.PlaneId,
				Count = order.Count,
				Sum = order.Sum,
				DateCreate = order.DateCreate,
				DateImplement = order.DateImplement,
				Status = OrderStatus.Готов,
				ClientId = order.ClientId
			});
		}
		public void DeliveryOrder(ChangeStatusBindingModel model)
		{
			var order = _orderStorage.GetElement(new OrderBindingModel { Id = model.OrderId });
			if (order == null)
			{
				throw new Exception("Заказ не найден");
			}
			if (order.Status != OrderStatus.Готов.ToString())
			{
				throw new Exception("Заказ не в статусе \"Готов\"");
			}
			_orderStorage.Update(new OrderBindingModel
			{
				Id = order.Id,
				PlaneId = order.PlaneId,
				Count = order.Count,
				Sum = order.Sum,
				DateCreate = order.DateCreate,
				DateImplement = order.DateImplement,
				Status = OrderStatus.Выдан,
				ClientId = order.ClientId
			});
		}
	}
}
