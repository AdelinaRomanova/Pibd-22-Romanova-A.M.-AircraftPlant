using System;
using System.Collections.Generic;
using AircraftPlantListImplement.Models;

namespace AircraftPlantListImplement
{
	public class DataListSingleton
	{
		private static DataListSingleton instance;
		public List<Component> Components { get; set; }
		public List<Order> Orders { get; set; }
		public List<Plane> Planes { get; set; }
		public List<Client> Clients { get; set; }
		public List<Implementer> Implementers { get; set; }
		public List<Warehouse> Warehouses { get; set; }
		private DataListSingleton()
		{
			Components = new List<Component>();
			Orders = new List<Order>();
			Planes = new List<Plane>();
			Clients = new List<Client>();
			Warehouses = new List<Warehouse>();
			Implementers = new List<Implementer>();
		}
		public static DataListSingleton GetInstance()
		{
			if (instance == null)
			{
				instance = new DataListSingleton();
			}
			return instance;
		}
	}
}
