using AircraftPlantContracts.BindingModels;
using AircraftPlantContracts.StoragesContracts;
using AircraftPlantContracts.ViewModels;
using AircraftPlantDatabaseImplement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AircraftPlantDatabaseImplement.Implements
{
	public class ClientStorage : IClientStorage
	{
		public List<ClientViewModel> GetFullList()
		{
			using var context = new AircraftPlantDatabase();
			return context.Clients.Select(CreateModel).ToList();
		}

		public List<ClientViewModel> GetFilteredList(ClientBindingModel model)
		{
			if (model == null)
			{
				return null;
			}
			using var context = new AircraftPlantDatabase();
			return context.Clients.Where(rec => rec.Email.Contains(model.Email) && rec.Password == model.Password).Select(CreateModel).ToList();
		}

		public ClientViewModel GetElement(ClientBindingModel model)
		{
			if (model == null)
			{
				return null;
			}
			using var context = new AircraftPlantDatabase();
			var component = context.Clients.FirstOrDefault(rec => rec.Email == model.Email || rec.Id == model.Id);
			return component != null ? CreateModel(component) : null;
		}

		public void Insert(ClientBindingModel model)
		{
			using var context = new AircraftPlantDatabase();
			context.Clients.Add(CreateModel(model, new Client()));
			context.SaveChanges();
		}
		public void Update(ClientBindingModel model)
		{
			using var context = new AircraftPlantDatabase();
			var element = context.Clients.FirstOrDefault(rec => rec.Id == model.Id);
			if (element == null)
			{
				throw new Exception("Клиент не найден");
			}
			CreateModel(model, element);
			context.SaveChanges();
		}
		public void Delete(ClientBindingModel model)
		{
			using var context = new AircraftPlantDatabase();
			Client element = context.Clients.FirstOrDefault(rec => rec.Id == model.Id);
			if (element != null)
			{
				context.Clients.Remove(element);
				context.SaveChanges();
			}
			else
			{
				throw new Exception("Элемент не найден");
			}
		}

		private static Client CreateModel(ClientBindingModel model, Client client)
		{
			client.ClientFIO = model.ClientFIO;
			client.Email = model.Email;
			client.Password = model.Password;
			return client;
		}
		private static ClientViewModel CreateModel(Client client)
		{
			return new ClientViewModel
			{
				Id = client.Id,
				ClientFIO = client.ClientFIO,
				Email = client.Email,
				Password = client.Password,
		};
		}
	}
}
