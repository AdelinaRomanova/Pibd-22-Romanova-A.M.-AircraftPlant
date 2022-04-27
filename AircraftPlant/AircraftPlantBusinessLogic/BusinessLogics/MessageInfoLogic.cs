using AircraftPlantContracts.BindingModels;
using AircraftPlantContracts.BusinessLogicsContracts;
using AircraftPlantContracts.StoragesContracts;
using AircraftPlantContracts.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AircraftPlantBusinessLogic.BusinessLogics
{
    public class MessageInfoLogic : IMessageInfoLogic
    {
        private readonly IMessageInfoStorage messageInfoStorage;
        public MessageInfoLogic(IMessageInfoStorage messageInfoStorage)
        {
            this.messageInfoStorage = messageInfoStorage;
        }
        public List<MessageInfoViewModel> Read(MessageInfoBindingModel model)
        {
            if (model == null)
            {
                return messageInfoStorage.GetFullList();
            }
            return messageInfoStorage.GetFilteredList(model);
        }
        public void CreateOrUpdate(MessageInfoBindingModel model)
        {
            messageInfoStorage.Insert(model);
        }
    }
}
