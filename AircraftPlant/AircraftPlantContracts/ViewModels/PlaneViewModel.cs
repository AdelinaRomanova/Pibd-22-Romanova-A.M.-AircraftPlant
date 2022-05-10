using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Runtime.Serialization;
using AircraftPlantContracts.Attributes;

namespace AircraftPlantContracts.ViewModels
{
	// Изделие, изготавливаемое в магазине
	public class PlaneViewModel
	{
		[Column(title: "Номер", width: 100)]
		public int Id { get; set; }
		[Column(title: "Название изделия", gridViewAutoSize: GridViewAutoSize.Fill)]
		public string PlaneName { get; set; }
		[Column(title: "Цена", gridViewAutoSize: GridViewAutoSize.Fill)]
		public decimal Price { get; set; }
		public Dictionary<int, (string, int)> PlaneComponents { get; set; }
	}
}
