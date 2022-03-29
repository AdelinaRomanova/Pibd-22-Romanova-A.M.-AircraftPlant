using System;
using AircraftPlantBusinessLogic.BusinessLogics;
using AircraftPlantContracts.BusinessLogicsContracts;
using AircraftPlantContracts.StoragesContracts;
using AircraftPlantDatabaseImplement.Implements;
using System.Windows.Forms;
using Unity;
using Unity.Lifetime;

namespace AircraftPlantView
{
	static class Program
	{
		private static IUnityContainer container = null;
		public static IUnityContainer Container
		{
			get
			{
				if (container == null)
				{
					container = BuildUnityContainer();
				}
				return container;
			}
		}
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.SetHighDpiMode(HighDpiMode.SystemAware);
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(Container.Resolve<FormMain>());
		}
		private static IUnityContainer BuildUnityContainer()
		{
			var currentContainer = new UnityContainer();
			currentContainer.RegisterType<IComponentStorage, ComponentStorage>(new HierarchicalLifetimeManager());
			currentContainer.RegisterType<IWarehouseStorage, WarehouseStorage>(new HierarchicalLifetimeManager());
			currentContainer.RegisterType<IOrderStorage, OrderStorage>(new HierarchicalLifetimeManager());
			currentContainer.RegisterType<IPlaneStorage, PlaneStorage>(new HierarchicalLifetimeManager());
			currentContainer.RegisterType<IComponentLogic, ComponentLogic>(new HierarchicalLifetimeManager());
			currentContainer.RegisterType<IOrderLogic, OrderLogic>(new HierarchicalLifetimeManager());
			currentContainer.RegisterType<IPlaneLogic, PlaneLogic>(new HierarchicalLifetimeManager());
			currentContainer.RegisterType<IWarehouseLogic, WarehouseLogic>(new HierarchicalLifetimeManager());
			return currentContainer;
		}
	}
}
