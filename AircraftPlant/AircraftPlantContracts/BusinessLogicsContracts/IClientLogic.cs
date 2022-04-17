using System.Collections.Generic;
using AircraftPlantContracts.BindingModels;
using AircraftPlantContracts.ViewModels;

namespace AircraftPlantContracts.BusinessLogicsContracts
{
	public interface IClientLogic
	{
		List<ClientViewModel> Read(ClientBindingModel model);
		void CreateOrUpdate(ClientBindingModel model);
		void Delete(ClientBindingModel model);
	}
}
