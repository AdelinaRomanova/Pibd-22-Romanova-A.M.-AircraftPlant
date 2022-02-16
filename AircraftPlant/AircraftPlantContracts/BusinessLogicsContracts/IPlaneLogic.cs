using System;
using System.Collections.Generic;
using AircraftPlantContracts.BindingModels;
using AircraftPlantContracts.ViewModels;
using System.Text;

namespace AircraftPlantContracts.BusinessLogicsContracts
{
	public interface IPlaneLogic
	{
		List<PlaneViewModel> Read(PlaneBindingModel model);
		void CreateOrUpdate(PlaneBindingModel model);
		void Delete(PlaneBindingModel model);
	}
}
