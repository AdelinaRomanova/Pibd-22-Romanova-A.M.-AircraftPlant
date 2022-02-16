using System.Collections.Generic;
using AircraftPlantContracts.BindingModels;
using AircraftPlantContracts.ViewModels;

namespace AircraftPlantContracts.BusinessLogicsContracts
{
	public interface IComponentLogic
	{
		List<ComponentViewModel> Read(ComponentBindingModel model);
		void CreateOrUpdate(ComponentBindingModel model);
		void Delete(ComponentBindingModel model);
	}
}
