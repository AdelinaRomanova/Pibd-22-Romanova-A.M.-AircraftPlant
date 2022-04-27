using AircraftPlantContracts.ViewModels;
using System.Collections.Generic;


namespace AircraftPlantBusinessLogic.OfficePackage.HelperModels
{
	public class WordInfo
	{
		public string FileName { get; set; }
		public string Title { get; set; }
		public List<PlaneViewModel> Planes { get; set; }
		public List<WarehouseViewModel> Warehouses { get; set; }
	}
}
