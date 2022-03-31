using System;
using AircraftPlantContracts.Enums;
using System.Runtime.Serialization;

namespace AircraftPlantContracts.BindingModels
{
	[DataContract]
	public class OrderBindingModel
	{
		[DataMember]
		public int? Id { get; set; }
		[DataMember]
		public int? ClientId { get; set; }
		[DataMember]
		public int PlaneId { get; set; }
		[DataMember]
		public int Count { get; set; }
		[DataMember]
		public decimal Sum { get; set; }
		[DataMember]
		public OrderStatus Status { get; set; }
		[DataMember]
		public DateTime DateCreate { get; set; }
		[DataMember]
		public DateTime? DateImplement { get; set; }
		[DataMember]
		public DateTime? DateFrom { get; set; }
		[DataMember]
		public DateTime? DateTo { get; set; }

	}
}
