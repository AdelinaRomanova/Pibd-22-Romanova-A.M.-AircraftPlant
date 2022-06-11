using AircraftPlantContracts.BindingModels;
using AircraftPlantContracts.BusinessLogicsContracts;
using AircraftPlantContracts.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;


namespace AircraftPlantRestApi.Controllers
{
	[Route("api/[controller]/[action]")]
	[ApiController]
	public class MainController : ControllerBase
	{
		private readonly IOrderLogic _order;
		private readonly IPlaneLogic _plane;
		public MainController(IOrderLogic order, IPlaneLogic plane, IMessageInfoLogic message)
		{
			_order = order;
			_plane = plane;
		}
		[HttpGet]
		public List<PlaneViewModel> GetPlaneList() => _plane.Read(null)?.ToList();
		[HttpGet]
		public PlaneViewModel GetPlane(int planeId) => _plane.Read(new PlaneBindingModel
		{ Id = planeId })?[0];
		[HttpGet]
		public List<OrderViewModel> GetOrders(int clientId) => _order.Read(new OrderBindingModel
		{ ClientId = clientId });

		[HttpPost]
		public void CreateOrder(CreateOrderBindingModel model) => _order.CreateOrder(model);

	}
}
