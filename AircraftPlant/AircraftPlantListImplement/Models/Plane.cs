using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AircraftPlantListImplement.Models
{
	// Изделие, изготавливаемое в магазине
	public class Plane
	{
		public int Id { get; set; }
		public string PlaneName { get; set; }
		public decimal Price { get; set; }
		public Dictionary<int, int> PlaneComponents { get; set; }
	}
}
