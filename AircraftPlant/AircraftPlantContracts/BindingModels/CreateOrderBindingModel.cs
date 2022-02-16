using System;
using System.Collections.Generic;
using System.Text;

namespace AircraftPlantContracts.BindingModels
{
	public class CreateOrderBindingModel
	{
		public int PlaneId { get; set; }
		public int Count { get; set; }
		public decimal Sum { get; set; }
	}
}
