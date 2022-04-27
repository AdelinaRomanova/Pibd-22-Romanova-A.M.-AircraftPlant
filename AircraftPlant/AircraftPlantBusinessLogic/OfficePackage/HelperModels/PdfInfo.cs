using AircraftPlantContracts.BindingModels;
using AircraftPlantContracts.ViewModels;
using System;
using System.Collections.Generic;

namespace AircraftPlantBusinessLogic.OfficePackage.HelperModels
{
	public class PdfInfo
	{
		public string FileName { get; set; }
		public string Title { get; set; }
		public DateTime DateFrom { get; set; }
		public DateTime DateTo { get; set; }
		public List<ReportOrdersViewModel> Orders { get; set; }
		public List<ReportOrdersByDateViewModel> OrdersByDate { get; set; }
	}
}
