using AircraftPlantBusinessLogic.OfficePackage.HelperEnums;
using AircraftPlantBusinessLogic.OfficePackage.HelperModels;

namespace AircraftPlantBusinessLogic.OfficePackage
{
	public abstract class AbstractSaveToExcel
	{
		/// Создание отчета
		public void CreateReport(ExcelInfo info)
		{
            CreateExcel(info);
            InsertCellInWorksheet(new ExcelCellParameters
            {
                ColumnName = "A",
                RowIndex = 1,
                Text = info.Title,
                StyleInfo = ExcelStyleInfoType.Title
            });
            MergeCells(new ExcelMergeParameters
            {
                CellFromName = "A1",
                CellToName = "C1"
            });
            uint rowIndex = 2;
            foreach (var comp in info.PlaneComponents)
            {
                InsertCellInWorksheet(new ExcelCellParameters
                {
                    ColumnName = "A",
                    RowIndex = rowIndex,
                    Text = comp.PlaneName,
                    StyleInfo = ExcelStyleInfoType.Text
                });
                rowIndex++;
                foreach (var plane in comp.Components)
                {
                    InsertCellInWorksheet(new ExcelCellParameters
                    {
                        ColumnName = "B",
                        RowIndex = rowIndex,
                        Text = plane.Item1,
                        StyleInfo = ExcelStyleInfoType.TextWithBroder
                    });
                    InsertCellInWorksheet(new ExcelCellParameters
                    {
                        ColumnName = "C",
                        RowIndex = rowIndex,
                        Text = plane.Item2.ToString(),
                        StyleInfo = ExcelStyleInfoType.TextWithBroder
                    });
                    rowIndex++;
                }
                InsertCellInWorksheet(new ExcelCellParameters
                {
                    ColumnName = "A",
                    RowIndex = rowIndex,
                    Text = "Итого",
                    StyleInfo = ExcelStyleInfoType.Text
                });
                InsertCellInWorksheet(new ExcelCellParameters
                {
                    ColumnName = "C",
                    RowIndex = rowIndex,
                    Text = comp.TotalCount.ToString(),
                    StyleInfo = ExcelStyleInfoType.Text
                });
                rowIndex++;
            }
            SaveExcel(info);
        }

        public void CreateReportWarehouse(ExcelInfo info)
        {
            CreateExcel(info);
            InsertCellInWorksheet(new ExcelCellParameters
            {
                ColumnName = "A",
                RowIndex = 1,
                Text = info.Title,
                StyleInfo = ExcelStyleInfoType.Title
            });
            MergeCells(new ExcelMergeParameters
            {
                CellFromName = "A1",
                CellToName = "C1"
            });
            uint rowIndex = 2;
            foreach (var comp in info.WarehouseComponents)
            {
                InsertCellInWorksheet(new ExcelCellParameters
                {
                    ColumnName = "A",
                    RowIndex = rowIndex,
                    Text = comp.WarehouseName,
                    StyleInfo = ExcelStyleInfoType.Text
                });
                rowIndex++;
                foreach (var product in comp.Components)
                {
                    InsertCellInWorksheet(new ExcelCellParameters
                    {
                        ColumnName = "B",
                        RowIndex = rowIndex,
                        Text = product.Item1,
                        StyleInfo = ExcelStyleInfoType.TextWithBroder
                    });
                    InsertCellInWorksheet(new ExcelCellParameters
                    {
                        ColumnName = "C",
                        RowIndex = rowIndex,
                        Text = product.Item2.ToString(),
                        StyleInfo = ExcelStyleInfoType.TextWithBroder
                    });
                    rowIndex++;
                }
                InsertCellInWorksheet(new ExcelCellParameters
                {
                    ColumnName = "A",
                    RowIndex = rowIndex,
                    Text = "Итого",
                    StyleInfo = ExcelStyleInfoType.Text
                });
                InsertCellInWorksheet(new ExcelCellParameters
                {
                    ColumnName = "C",
                    RowIndex = rowIndex,
                    Text = comp.TotalCount.ToString(),
                    StyleInfo = ExcelStyleInfoType.Text
                });
                rowIndex++;
            }
            SaveExcel(info);
        }

        // Создание excel-файла
        protected abstract void CreateExcel(ExcelInfo info);
		/// Добавляем новую ячейку в лист
		protected abstract void InsertCellInWorksheet(ExcelCellParameters excelParams);
		/// Объединение ячеек
		protected abstract void MergeCells(ExcelMergeParameters excelParams);
		/// Сохранение файла
		protected abstract void SaveExcel(ExcelInfo info);
	}
}
