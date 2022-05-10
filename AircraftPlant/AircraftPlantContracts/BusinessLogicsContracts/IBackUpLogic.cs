using AircraftPlantContracts.BindingModels;

namespace AircraftPlantContracts.BusinessLogicsContracts
{
    public interface IBackUpLogic
    {
        void CreateBackUp(BackUpSaveBinidngModel model);
    }
}
