using AircraftPlantBusinessLogic.OfficePackage.HelperEnums;
using AircraftPlantBusinessLogic.OfficePackage.HelperModels;
using System.Collections.Generic;


namespace AircraftPlantBusinessLogic.OfficePackage
{
	public abstract class AbstractSaveToWord
	{
		public void CreateDoc(WordInfo info)
		{
			CreateWord(info);
			CreateParagraph(new WordParagraph
			{
				Texts = new List<(string, WordTextProperties)> { (info.Title, new WordTextProperties { Bold = true, Size = "24", }) },
				TextProperties = new WordTextProperties
				{
					Size = "24",
					JustificationType = WordJustificationType.Center
				}
			});
			foreach (var component in info.Planes)
			{
				CreateParagraph(new WordParagraph
				{
					Texts = new List<(string, WordTextProperties)> { (component.PlaneName, new WordTextProperties {Bold = true, Size = "24"}),
						(" Цена " + component.Price.ToString(), new WordTextProperties {Bold = false, Size = "24"})},
					TextProperties = new WordTextProperties
					{
						Size = "24",
						JustificationType = WordJustificationType.Both
					}
				});
			}
			SaveWord(info);
		}

		// Создание doc-файла
		protected abstract void CreateWord(WordInfo info);
		// Создание абзаца с текстом
		protected abstract void CreateParagraph(WordParagraph paragraph);
		// Сохранение файла
		protected abstract void SaveWord(WordInfo info);
	}
}
