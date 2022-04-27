using System.Collections.Generic;
using AircraftPlantContracts.BindingModels;
using AircraftPlantContracts.ViewModels;

namespace AircraftPlantContracts.BusinessLogicsContracts
{
    public interface IImplementerLogic
    {
        List<ImplementerViewModel> Read(ImplementerBindingModel model);
        void CreateOrUpdate(ImplementerBindingModel model);
        void Delete(ImplementerBindingModel model);
    }
}
