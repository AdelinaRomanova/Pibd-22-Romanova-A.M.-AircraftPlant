using AircraftPlantFileImplement.Models;
using AircraftPlantContracts.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace AircraftPlantFileImplement
{
	public class FileDataListSingleton
	{
		private static FileDataListSingleton instance;
		private readonly string ComponentFileName = "Component.xml";
		private readonly string OrderFileName = "Order.xml";
		private readonly string PlaneFileName = "Plane.xml";
		private readonly string ClientFileName = "Client.xml";
		private readonly string ImplementerFileName = "Implementer.xml";
		private readonly string WarehouseFileName = "Warehouse.xml";
		public List<Component> Components { get; set; }
		public List<Order> Orders { get; set; }
		public List<Plane> Planes { get; set; }
		public List<Warehouse> Warehouses { get; set; }
		public List<Client> Clients { get; set; }
		public List<Implementer> Implementers { get; set; }
		private FileDataListSingleton()
		{
			Components = LoadComponents();
			Orders = LoadOrders();
			Planes = LoadPlanes();
			Warehouses = LoadWarehouses();
			Clients = LoadClients();
			Implementers = LoadImplementers();
		}
		public static FileDataListSingleton GetInstance()
		{
			if (instance == null)
			{
				instance = new FileDataListSingleton();
			}
			return instance;
		}
		~FileDataListSingleton()
		{
			SaveComponents();
			SaveOrders();
			SavePlanes();
			SaveClients();
			SaveImplementers();
			SaveWarehouses();
		}
		private List<Component> LoadComponents()
		{
			var list = new List<Component>();
			if (File.Exists(ComponentFileName))
			{
				var xDocument = XDocument.Load(ComponentFileName);
				var xElements = xDocument.Root.Elements("Component").ToList();
				foreach (var elem in xElements)
				{
					list.Add(new Component
					{
						Id = Convert.ToInt32(elem.Attribute("Id").Value),
						ComponentName = elem.Element("ComponentName").Value
					});
				}
			}
			return list;
		}
		private List<Order> LoadOrders()
		{
			var list = new List<Order>();
			if (File.Exists(OrderFileName))
			{
				var xDocument = XDocument.Load(OrderFileName);
				var xElements = xDocument.Root.Elements("Order").ToList();
				foreach (var elem in xElements)
				{
					list.Add(new Order
					{
						Id = Convert.ToInt32(elem.Attribute("Id").Value),
						ClientId = Convert.ToInt32(elem.Element("ClientId").Value),
						PlaneId = Convert.ToInt32(elem.Element("PlaneId").Value),
						Count = Convert.ToInt32(elem.Element("Count").Value),
						Sum = Convert.ToInt32(elem.Element("Sum").Value),
						Status = (OrderStatus)Enum.Parse(typeof(OrderStatus), elem.Element("Status").Value),
						DateCreate = Convert.ToDateTime(elem.Element("DateCreate").Value),
						DateImplement = string.IsNullOrEmpty(elem.Element("DateImplement").Value) ?
						(DateTime?)null : Convert.ToDateTime(elem.Element("DateImplement").Value)
					});
				}
			}
			return list;
		}
		private List<Plane> LoadPlanes()
		{
			var list = new List<Plane>();
			if (File.Exists(PlaneFileName))
			{
				var xDocument = XDocument.Load(PlaneFileName);
				var xElements = xDocument.Root.Elements("Plane").ToList();
				foreach (var elem in xElements)
				{
					var planeComp = new Dictionary<int, int>();
					foreach (var component in elem.Element("PlaneComponents").Elements("PlaneComponent").ToList())
					{
						planeComp.Add(Convert.ToInt32(component.Element("Key").Value), Convert.ToInt32(component.Element("Value").Value));
					}
					list.Add(new Plane
					{
						Id = Convert.ToInt32(elem.Attribute("Id").Value),
						PlaneName = elem.Element("PlaneName").Value,
						Price = Convert.ToDecimal(elem.Element("Price").Value),
						PlaneComponents = planeComp
					});
				}
			}
			return list;
		}
		private List<Warehouse> LoadWarehouses()
		{
			var list = new List<Warehouse>();
			if (File.Exists(WarehouseFileName))
			{
				var xDocument = XDocument.Load(WarehouseFileName);
				var xElements = xDocument.Root.Elements("Warehouse").ToList();
				foreach (var elem in xElements)
				{
					var warComp = new Dictionary<int, int>();
					foreach (var component in
						elem.Element("WarehouseComponents").Elements("WarehouseComponent").ToList())
					{
						warComp.Add(Convert.ToInt32(component.Element("Key").Value),
							Convert.ToInt32(component.Element("Value").Value));
					}
					list.Add(new Warehouse
					{
						Id = Convert.ToInt32(elem.Attribute("Id").Value),
						WarehouseName = elem.Element("WarehouseName").Value,
						Responsible = elem.Element("Responsible").Value,
						DateCreate = DateTime.Parse(elem.Element("DateCreate").Value),
						WarehouseComponents = warComp
					});
				}
			}
			return list;
		}
		private List<Client> LoadClients()
		{
			var list = new List<Client>();

			if (File.Exists(ClientFileName))
			{
				XDocument xDocument = XDocument.Load(ClientFileName);
				var xElements = xDocument.Root.Elements("Client").ToList();

				foreach (var elem in xElements)
				{
					list.Add(new Client
					{
						Id = Convert.ToInt32(elem.Attribute("Id").Value),
						ClientFIO = elem.Element("ClientFIO").Value,
						Email = elem.Element("Email").Value,
						Password = elem.Element("Password").Value,
					});
				}
			}
			return list;
		}

		public List<Implementer> LoadImplementers()
		{
			var list = new List<Implementer>();
			if (File.Exists(ImplementerFileName))
			{
				var xDocument = XDocument.Load(ImplementerFileName);
				var xElements = xDocument.Root.Elements("Implementer").ToList();
				foreach (var elem in xElements)
				{
					list.Add(new Implementer
					{
						Id = Convert.ToInt32(elem.Attribute("Id").Value),
						ImplementerFIO = elem.Element("ImplementerFIO").Value,
						WorkingTime = Convert.ToInt32(elem.Element("WorkingTime").Value),
						PauseTime = Convert.ToInt32(elem.Element("PauseTime").Value)
					});
				}
			}
			return list;
		}
		private void SaveComponents()
		{
			if (Components != null)
			{
				var xElement = new XElement("Components");
				foreach (var component in Components)
				{
					xElement.Add(new XElement("Component", new XAttribute("Id", component.Id), new XElement("ComponentName", component.ComponentName)));
				}
				var xDocument = new XDocument(xElement);
				xDocument.Save(ComponentFileName);
			}
		}
		private void SaveOrders()
		{
			if (Orders != null)
			{
				var xElement = new XElement("Orders");
				foreach (var order in Orders)
				{
					xElement.Add(new XElement("Order",
					new XAttribute("Id", order.Id),
					new XElement("ClientId", order.ClientId),
					new XElement("PlaneId", order.PlaneId),
					new XElement("Count", order.Count),
					new XElement("Sum", order.Sum),
					new XElement("Status", order.Status),
					new XElement("DateCreate", order.DateCreate),
					new XElement("DateImplement", order.DateImplement)));
				}
				XDocument xDocument = new XDocument(xElement);
				xDocument.Save(OrderFileName);
			}
		}
		private void SavePlanes()
		{
			if (Planes != null)
			{
				var xElement = new XElement("Planes");
				foreach (var plane in Planes)
				{
					var compElement = new XElement("PlaneComponents");
					foreach (var component in plane.PlaneComponents)
					{
						compElement.Add(new XElement("PlaneComponent",
						new XElement("Key", component.Key),
						new XElement("Value", component.Value)));
					}
					xElement.Add(new XElement("Plane",
					new XAttribute("Id", plane.Id),
					new XElement("PlaneName", plane.PlaneName),
					new XElement("Price", plane.Price),
					compElement));
				}
				var xDocument = new XDocument(xElement);
				xDocument.Save(PlaneFileName);
			}
		}
		private void SaveClients()
		{
			if (Clients != null)
			{
				var xElement = new XElement("Clients");

				foreach (var client in Clients)
				{
					xElement.Add(new XElement("Client",
					new XAttribute("Id", client.Id),
					new XElement("ClientFIO", client.ClientFIO),
					new XElement("Email", client.Email),
					new XElement("Password", client.Password)));
				}

				XDocument xDocument = new XDocument(xElement);
				xDocument.Save(ClientFileName);
			}
		}

		private void SaveImplementers()
		{
			if (Implementers != null)
			{
				var xElement = new XElement("Implementers");
				foreach (var implementer in Implementers)
				{
					xElement.Add(new XElement("Implementer"),
						new XAttribute("Id", implementer.Id),
						new XElement("ImplementerFIO", implementer.ImplementerFIO),
						new XElement("WorkTime", implementer.WorkingTime),
						new XElement("PauseTime", implementer.PauseTime));
				}
				var xDocument = new XDocument(xElement);
				xDocument.Save(ImplementerFileName);
			}
		}
		private void SaveWarehouses()
		{
			if (Warehouses != null)
			{
				var xElement = new XElement("Warehouses");
				foreach (var warehouse in Warehouses)
				{
					var compElement = new XElement("WarehouseComponents");
					foreach (var component in warehouse.WarehouseComponents)
					{
						compElement.Add(new XElement("WarehouseComponent",
							new XElement("Key", component.Key),
							new XElement("Value", component.Value)));
					}
					xElement.Add(new XElement("Warehouse",
						new XAttribute("Id", warehouse.Id),
						new XElement("WarehouseName", warehouse.WarehouseName),
						new XElement("Responsible", warehouse.Responsible),
						new XElement("DateCreate", warehouse.DateCreate.ToString()),
						compElement));
				}
				var xDocument = new XDocument(xElement);
				xDocument.Save(WarehouseFileName);
			}
		}
		public static void Save()
		{
			instance.SaveOrders();
			instance.SavePlanes();
			instance.SaveComponents();
			instance.SaveWarehouses();
			instance.SaveClients();
			instance.SaveImplementers();
		}
	}
}
