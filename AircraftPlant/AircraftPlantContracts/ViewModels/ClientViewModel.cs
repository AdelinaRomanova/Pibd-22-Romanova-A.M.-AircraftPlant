using System.Runtime.Serialization;
using AircraftPlantContracts.Attributes;

namespace AircraftPlantContracts.ViewModels
{
    [DataContract]
    public class ClientViewModel
	{
        [Column(title: "Номер", width: 100)]
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        [Column(title: "Клиент", width: 150)]
        public string ClientFIO { get; set; }
        [DataMember]
        [Column(title: "Email", width: 150)]
        public string Email { get; set; }
        [DataMember]
        [Column(title: "Пароль", width: 100)]
        public string Password { get; set; }
    }
}
