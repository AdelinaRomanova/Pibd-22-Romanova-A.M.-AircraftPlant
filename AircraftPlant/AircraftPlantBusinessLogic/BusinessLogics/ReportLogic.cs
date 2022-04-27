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
		private readonly AbstractSaveToExcel _saveToExcel;
		private readonly AbstractSaveToWord _saveToWord;
		private readonly AbstractSaveToPdf _saveToPdf;

		public ReportLogic(IPlaneStorage planeStorage, IComponentStorage componentStorage, IOrderStorage orderStorage, AbstractSaveToExcel saveToExcel, AbstractSaveToWord saveToWord, AbstractSaveToPdf saveToPdf)
		{
			_planeStorage = planeStorage;
			_componentStorage = componentStorage;
			_orderStorage = orderStorage;
			_saveToExcel = saveToExcel;
			_saveToWord = saveToWord;
			_saveToPdf = saveToPdf;
		}

		// Получение списка изделий с указанием цены
		public List<ReportPlaneComponentViewModel> GetProductComponent()
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

		// Сохранение компонент с указаеним продуктов в файл-Excel
		public void SaveProductComponentToExcelFile(ReportBindingModel model)
		{
			_saveToExcel.CreateReport(new ExcelInfo
			{
				FileName = model.FileName,
				Title = "Список компонент",
				PlaneComponents = GetProductComponent()
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
	}
}
