
using AircraftPlantContracts.BindingModels;
using AircraftPlantContracts.ViewModels;
using System.Collections.Generic;

namespace AircraftPlantContracts.BusinessLogicsContracts
{
	public interface IReportLogic
	{
		// Получение списка компонент с указанием, в каких изделиях используются
		List<ReportPlaneComponentViewModel> GetProductComponent();
		/// Получение списка заказов за определенный период
		List<ReportOrdersViewModel> GetOrders(ReportBindingModel model);
		/// Сохранение компонент в файл-Word
		void SaveComponentsToWordFile(ReportBindingModel model);
		/// Сохранение компонент с указаеним продуктов в файл-Excel
		void SaveProductComponentToExcelFile(ReportBindingModel model);
		/// Сохранение заказов в файл-Pdf
		void SaveOrdersToPdfFile(ReportBindingModel model);
	}
}
