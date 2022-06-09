using AircraftPlantDatabaseImplement.Models;
using Microsoft.EntityFrameworkCore;

namespace AircraftPlantDatabaseImplement.Implements
{
	public class AircraftPlantDatabase : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (optionsBuilder.IsConfigured == false)
			{
				optionsBuilder.UseSqlServer(@"Data Source=localhost\SQLEXPRESS01;Initial Catalog=AircraftPlantDatabase;Integrated Security=True;MultipleActiveResultSets=True;");
			}
			base.OnConfiguring(optionsBuilder);
		}

		public virtual DbSet<Component> Components { set; get; }
		public virtual DbSet<Plane> Planes { set; get; }
		public virtual DbSet<PlaneComponent> PlaneComponents { set; get; }
		public virtual DbSet<Order> Orders { set; get; }
		public virtual DbSet<Warehouse> Warehouses { get; set; }
		public virtual DbSet<WarehouseComponent> WarehouseComponents { get; set; }
		public virtual DbSet<Client> Clients { set; get; }
		public virtual DbSet<Implementer> Implementers { set; get; }
		public virtual DbSet<MessageInfo> MessagesInfo { get; set; }
	}
}
