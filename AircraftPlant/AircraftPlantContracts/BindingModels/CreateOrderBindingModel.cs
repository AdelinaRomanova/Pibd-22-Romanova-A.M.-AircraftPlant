using System.Runtime.Serialization;

namespace AircraftPlantContracts.BindingModels
{
	[DataContract]
	public class CreateOrderBindingModel
	{
		[DataMember]
		public int ClientId { get; set; }
		[DataMember]
		public int PlaneId { get; set; }
		[DataMember]
		public int Count { get; set; }
		[DataMember]
		public decimal Sum { get; set; }
	}
}
