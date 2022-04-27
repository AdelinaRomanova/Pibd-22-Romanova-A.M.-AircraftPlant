
using AircraftPlantContracts.BindingModels;
using AircraftPlantContracts.ViewModels;
using System.Collections.Generic;

namespace AircraftPlantContracts.BusinessLogicsContracts
{
	public interface IReportLogic
	{
		// Получение списка компонент с указанием, в каких изделиях используются
		List<ReportPlaneComponentViewModel> GetPlaneComponent();
		List<ReportWarehouseComponentViewModel> GetWarehouseComponent();
		/// Получение списка заказов за определенный период
		List<ReportOrdersViewModel> GetOrders(ReportBindingModel model);
		List<ReportOrdersByDateViewModel> GetOrdersByDate();
		/// Сохранение компонент в файл-Word
		void SavePlanesToWordFile(ReportBindingModel model);
		void SaveWarehousesToWordFile(ReportBindingModel model);
		/// Сохранение компонент с указаеним продуктов в файл-Excel
		void SavePlaneComponentToExcelFile(ReportBindingModel model);
		void SaveWarehouseComponentToExcelFile(ReportBindingModel model);
		/// Сохранение заказов в файл-Pdf
		void SaveOrdersToPdfFile(ReportBindingModel model);
		void SaveOrdersByDateToPdfFile(ReportBindingModel model);

	}
}
