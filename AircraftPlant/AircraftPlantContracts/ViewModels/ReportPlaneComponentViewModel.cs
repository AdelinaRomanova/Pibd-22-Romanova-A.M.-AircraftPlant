using System;
using System.Collections.Generic;

namespace AircraftPlantContracts.BindingModels
{
	public class ReportPlaneComponentViewModel
	{
		public string PlaneName { get; set; }
		public int TotalCount { get; set; }
		public List<Tuple<string, int>> Components { get; set; }
	}
}
