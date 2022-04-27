using AircraftPlantContracts.BindingModels;
using AircraftPlantContracts.ViewModels;
using System.Collections.Generic;

namespace AircraftPlantBusinessLogic.OfficePackage.HelperModels
{
	public class ExcelInfo
	{
			public string FileName { get; set; }
			public string Title { get; set; }
			public List<ReportPlaneComponentViewModel> PlaneComponents { get; set; }
			public List<ReportWarehouseComponentViewModel> WarehouseComponents { get; set; }
	}
}
