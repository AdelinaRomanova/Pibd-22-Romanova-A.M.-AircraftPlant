using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace AircraftPlantContracts.ViewModels
{
	// Изделие, изготавливаемое в магазине
	public class PlaneViewModel
	{
		public int Id { get; set; }
		[DisplayName("Название изделия")]
		public string PlaneName { get; set; }
		[DisplayName("Цена")]
		public decimal Price { get; set; }
		public Dictionary<int, (string, int)> PlaneComponents { get; set; }
	}
}
