using System;
using System.Collections.Generic;
using AircraftPlantContracts.BindingModels;
using AircraftPlantContracts.ViewModels;

namespace AircraftPlantContracts.StoragesContracts
{
	public interface IComponentStorage
	{
		List<ComponentViewModel> GetFullList();
		List<ComponentViewModel> GetFilteredList(ComponentBindingModel model);
		ComponentViewModel GetElement(ComponentBindingModel model);
		void Insert(ComponentBindingModel model);
		void Update(ComponentBindingModel model);
		void Delete(ComponentBindingModel model);
	}
}
