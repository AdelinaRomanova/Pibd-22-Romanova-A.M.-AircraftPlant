using System;
using System.Collections.Generic;
using AircraftPlantContracts.BindingModels;
using AircraftPlantContracts.ViewModels;
using System.Text;

namespace AircraftPlantContracts.StoragesContracts
{
	public interface IPlaneStorage
	{
		List<PlaneViewModel> GetFullList();
		List<PlaneViewModel> GetFilteredList(PlaneBindingModel model);
		PlaneViewModel GetElement(PlaneBindingModel model);
		void Insert(PlaneBindingModel model);
		void Update(PlaneBindingModel model);
		void Delete(PlaneBindingModel model);
	}
}
