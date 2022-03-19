using System;
using System.Collections.Generic;
using AircraftPlantContracts.ViewModels;
using AircraftPlantContracts.BindingModels;

namespace AircraftPlantContracts.BusinessLogicsContracts
{
	public interface IWarehouseLogic
	{
		List<WarehouseViewModel> Read(WarehouseBindingModel model);
		void CreateOrUpdate(WarehouseBindingModel model);
		void Delete(WarehouseBindingModel model);
		void AddComponent(WarehouseBindingModel model, int componentId, int Count);
	}
}
