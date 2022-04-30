using AircraftPlantBusinessLogic.OfficePackage;
using AircraftPlantBusinessLogic.OfficePackage.HelperModels;
using AircraftPlantContracts.BindingModels;
using AircraftPlantContracts.BusinessLogicsContracts;
using AircraftPlantContracts.StoragesContracts;
using AircraftPlantContracts.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AircraftPlantBusinessLogic.BusinessLogics
{
	public class ReportLogic : IReportLogic
	{
		private readonly IComponentStorage _componentStorage;
		private readonly IPlaneStorage _planeStorage;
		private readonly IOrderStorage _orderStorage;
		private readonly IWarehouseStorage _warehouseStorage;
		private readonly AbstractSaveToExcel _saveToExcel;
		private readonly AbstractSaveToWord _saveToWord;
		private readonly AbstractSaveToPdf _saveToPdf;

		public ReportLogic(IPlaneStorage planeStorage, IComponentStorage componentStorage, IOrderStorage orderStorage, IWarehouseStorage warehouseStorage,
			AbstractSaveToExcel saveToExcel, AbstractSaveToWord saveToWord, AbstractSaveToPdf saveToPdf)
		{
			_planeStorage = planeStorage;
			_componentStorage = componentStorage;
			_orderStorage = orderStorage;
			_warehouseStorage = warehouseStorage;
			_saveToExcel = saveToExcel;
			_saveToWord = saveToWord;
			_saveToPdf = saveToPdf;
		}

		// Получение списка изделий с указанием цены
		public List<ReportPlaneComponentViewModel> GetPlaneComponent()
		{
			var planes = _planeStorage.GetFullList();
			var list = new List<ReportPlaneComponentViewModel>();
			foreach (var plane in planes)
			{
				var record = new ReportPlaneComponentViewModel
				{
					PlaneName = plane.PlaneName,
					Components = new List<Tuple<string, int>>(),
					TotalCount = 0
				};
				foreach (var component in plane.PlaneComponents)
				{
					record.Components.Add(new Tuple<string, int>(component.Value.Item1, component.Value.Item2));
					record.TotalCount += component.Value.Item2;
				}
				list.Add(record);
			}
			return list;
		}

		public List<ReportWarehouseComponentViewModel> GetWarehouseComponent()
		{
			var warehouses = _warehouseStorage.GetFullList();
			var list = new List<ReportWarehouseComponentViewModel>();
			foreach (var warehouse in warehouses)
			{
				var record = new ReportWarehouseComponentViewModel
				{
					WarehouseName = warehouse.WarehouseName,
					Components = new List<Tuple<string, int>>(),
					TotalCount = 0
				};
				foreach (var component in warehouse.WarehouseComponents)
				{
					record.Components.Add(new Tuple<string, int>(component.Value.Item1, component.Value.Item2));
					record.TotalCount += component.Value.Item2;
				}
				list.Add(record);
			}
			return list;
		}

		// Получение списка заказов за определенный период
		public List<ReportOrdersViewModel> GetOrders(ReportBindingModel model)
		{
			return _orderStorage.GetFilteredList(new OrderBindingModel
			{
				DateFrom = model.DateFrom,
				DateTo = model.DateTo
			})
			.Select(x => new ReportOrdersViewModel
			{
				DateCreate = x.DateCreate,
				PlaneName = x.PlaneName,
				Count = x.Count,
				Sum = x.Sum,
				Status = x.Status
			})
		   .ToList();
		}

		public List<ReportOrdersByDateViewModel> GetOrdersByDate()
		{
			return _orderStorage.GetFullList()
			.GroupBy(rec => rec.DateCreate.ToShortDateString())
			.Select(x => new ReportOrdersByDateViewModel
			{
				DateCreate = Convert.ToDateTime(x.Key),
				Count = x.Count(),
				Sum = x.Sum(rec => rec.Sum)
			})
		   .ToList();
		}

		public void SavePlanesToWordFile(ReportBindingModel model)
		{
			_saveToWord.CreateDoc(new WordInfo
			{
				FileName = model.FileName,
				Title = "Список самолётов",
				Planes = _planeStorage.GetFullList()
			});
		}

		// Сохранение компонент в файл-Word
		public void SaveComponentsToWordFile(ReportBindingModel model)
		{
			_saveToWord.CreateDoc(new WordInfo
			{
				FileName = model.FileName,
				Title = "Список самолётов",
				Planes = _planeStorage.GetFullList()
			});
		}

		public void SaveWarehousesToWordFile(ReportBindingModel model)
		{
			_saveToWord.CreateDocWarehouse(new WordInfo
			{
				FileName = model.FileName,
				Title = "Список складов",
				Warehouses = _warehouseStorage.GetFullList()
			});
		}

		// Сохранение компонент с указаеним продуктов в файл-Excel
		public void SavePlaneComponentToExcelFile(ReportBindingModel model)
		{
			_saveToExcel.CreateReport(new ExcelInfo
			{
				FileName = model.FileName,
				Title = "Список компонент",
				PlaneComponents = GetPlaneComponent()
			});
		}

		public void SaveWarehouseComponentToExcelFile(ReportBindingModel model)
		{
			_saveToExcel.CreateReportWarehouse(new ExcelInfo
			{
				FileName = model.FileName,
				Title = "Список компонент",
				WarehouseComponents = GetWarehouseComponent()
			});
		}

		/// Сохранение заказов в файл-Pdf
		public void SaveOrdersToPdfFile(ReportBindingModel model)
		{
			_saveToPdf.CreateDoc(new PdfInfo
			{
				FileName = model.FileName,
				Title = "Список заказов",
				DateFrom = model.DateFrom.Value,
				DateTo = model.DateTo.Value,
				Orders = GetOrders(model)
			});
		}

		public void SaveOrdersByDateToPdfFile(ReportBindingModel model)
		{
			_saveToPdf.CreateDocOrdersByDate(new PdfInfo
			{
				FileName = model.FileName,
				Title = "Список заказов по датам",
				OrdersByDate = GetOrdersByDate()
			});
		}
	}
}
