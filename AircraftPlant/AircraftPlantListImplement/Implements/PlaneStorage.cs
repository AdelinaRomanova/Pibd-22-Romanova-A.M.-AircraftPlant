using System;
using System.Collections.Generic;
using System.Linq;
using AircraftPlantContracts.BindingModels;
using AircraftPlantContracts.StoragesContracts;
using AircraftPlantContracts.ViewModels;
using AircraftPlantListImplement.Models;


namespace AircraftPlantListImplement.Implements
{
	public class PlaneStorage : IPlaneStorage
	{
		private readonly DataListSingleton source;
		public PlaneStorage()
		{
			source = DataListSingleton.GetInstance();
		}
		public List<PlaneViewModel> GetFullList()
		{
			var result = new List<PlaneViewModel>();
			foreach (var component in source.Planes)
			{
				result.Add(CreateModel(component));
			}
			return result;
		}
		public List<PlaneViewModel> GetFilteredList(PlaneBindingModel model)
		{
			if (model == null)
			{
				return null;
			}
			var result = new List<PlaneViewModel>();
			foreach (var plane in source.Planes)
			{
				if (plane.PlaneName.Contains(model.PlaneName))
				{
					result.Add(CreateModel(plane));
				}
			}
			return result;
		}
		public PlaneViewModel GetElement(PlaneBindingModel model)
		{
			if (model == null)
			{
				return null;
			}
			foreach (var plane in source.Planes)
			{
				if (plane.Id == model.Id || plane.PlaneName == model.PlaneName)
				{
					return CreateModel(plane);
				}
			}
			return null;
		}
		public void Insert(PlaneBindingModel model)
		{
			var tempPlane = new Plane
			{
				Id = 1,
				PlaneComponents = new Dictionary<int, int>()
			};
			foreach (var plane in source.Planes)
			{
				if (plane.Id >= tempPlane.Id)
				{
					tempPlane.Id = plane.Id + 1;
				}
			}
			source.Planes.Add(CreateModel(model, tempPlane));
		}
		public void Update(PlaneBindingModel model)
		{
			Plane tempPlane = null;
			foreach (var plane in source.Planes)
			{
				if (plane.Id == model.Id)
				{
					tempPlane = plane;
				}
			}
			if (tempPlane == null)
			{
				throw new Exception("Элемент не найден");
			}
			CreateModel(model, tempPlane);
		}
		public void Delete(PlaneBindingModel model)
		{
			for (int i = 0; i < source.Planes.Count; ++i)
			{
				if (source.Planes[i].Id == model.Id)
				{
					source.Planes.RemoveAt(i);
					return;
				}
			}
			throw new Exception("Элемент не найден");
		}
		private static Plane CreateModel(PlaneBindingModel model, Plane product)
		{
			product.PlaneName = model.PlaneName;
			product.Price = model.Price;
			// удаляем убранные
			foreach (var key in product.PlaneComponents.Keys.ToList())
			{
				if (!model.PlaneComponents.ContainsKey(key))
				{
					product.PlaneComponents.Remove(key);
				}
			}
			// обновляем существуюущие и добавляем новые
			foreach (var component in model.PlaneComponents)
			{
				if (product.PlaneComponents.ContainsKey(component.Key))
				{
					product.PlaneComponents[component.Key] = model.PlaneComponents[component.Key].Item2;
				}
				else
				{
					product.PlaneComponents.Add(component.Key, model.PlaneComponents[component.Key].Item2);
				}
			}
			return product;
		}
		private PlaneViewModel CreateModel(Plane plane)
		{
			// требуется дополнительно получить список компонентов для изделия с названиями и их количество
			var planeComponents = new Dictionary<int, (string, int)>();
			foreach (var pc in plane.PlaneComponents)
			{
				string componentName = string.Empty;
				foreach (var component in source.Components)
				{
					if (pc.Key == component.Id)
					{
						componentName = component.ComponentName;
						break;
					}
				}
				planeComponents.Add(pc.Key, (componentName, pc.Value));
			}
			return new PlaneViewModel
			{
				Id = plane.Id,
				PlaneName = plane.PlaneName,
				Price = plane.Price,
				PlaneComponents = planeComponents
			};
		}
	}
}
	

