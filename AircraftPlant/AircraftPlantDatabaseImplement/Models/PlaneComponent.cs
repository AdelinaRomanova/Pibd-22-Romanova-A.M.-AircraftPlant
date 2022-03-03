using System.ComponentModel.DataAnnotations;

namespace AircraftPlantDatabaseImplement.Models
{
	// Сколько компонентов, требуется при изготовлении изделия
	public class PlaneComponent
	{
		public int Id { get; set; }

		public int PlaneId { get; set; }

		public int ComponentId { get; set; }

		[Required]
		public int Count { get; set; }

		public virtual Component Component { get; set; }

		public virtual Plane Plane { get; set; }
	}
}
