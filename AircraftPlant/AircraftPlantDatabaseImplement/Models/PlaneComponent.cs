using System.ComponentModel.DataAnnotations;

namespace AircraftPlantDatabaseImplement.Models
{
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
