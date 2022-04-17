using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AircraftPlantDatabaseImplement.Models
{
	public class Plane
	{
		public int Id { get; set; }

		[Required]
		public string PlaneName { get; set; }

		[Required]
		public decimal Price { get; set; }
		
		[ForeignKey("PlaneId")]
		public virtual List<PlaneComponent> PlaneComponents { get; set; }

		[ForeignKey("PlaneId")]
		public virtual List<Order> Orders { get; set; }
	}
}
