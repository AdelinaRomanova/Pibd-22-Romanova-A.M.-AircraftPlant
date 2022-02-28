using System;
using AircraftPlantBusinessLogic.BusinessLogics;
using AircraftPlantContracts.BindingModels;
using AircraftPlantContracts.BusinessLogicsContracts;
using AircraftPlantContracts.ViewModels;
using System.Collections.Generic;
using System.Windows.Forms;
using Unity;

namespace AircraftPlantView
{
	public partial class FormPlane : Form
	{
		public int Id { set { id = value; } }
		private readonly PlaneLogic _logic;
		private int? id;
		private Dictionary<int, (string, int)> planeComponents;
		public FormPlane(PlaneLogic logic)
		{
			InitializeComponent();
			_logic = logic;
		}
		private void FormPlane_Load(object sender, EventArgs e)
		{
			if (id.HasValue)
			{
				try
				{
					PlaneViewModel view = _logic.Read(new PlaneBindingModel
					{
						Id =id.Value
					})?[0];
					if (view != null)
					{
						textBoxName.Text = view.PlaneName;
						textBoxPrice.Text = view.Price.ToString();
						planeComponents = view.PlaneComponents;
						LoadData();
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
				   MessageBoxIcon.Error);
				}
			}
			else
			{
				planeComponents = new Dictionary<int, (string, int)>();
			}
		}
		private void LoadData()
		{
			try
			{
				if (planeComponents != null)
				{
					dataGridView.Rows.Clear();
					foreach (var pc in planeComponents)
					{
						dataGridView.Rows.Add(new object[] { pc.Key, pc.Value.Item1,pc.Value.Item2 });
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void buttonAdd_Click(object sender, EventArgs e)
		{
			var form = Program.Container.Resolve<FormPlaneComponent>();
			if (form.ShowDialog() == DialogResult.OK)
			{
				if (planeComponents.ContainsKey(form.Id))
				{
					planeComponents[form.Id] = (form.ComponentName, form.Count);
				}
				else
				{
					planeComponents.Add(form.Id, (form.ComponentName, form.Count));
				}
				LoadData();
			}
		}
		private void buttonUpd_Click(object sender, EventArgs e)
		{
			if (dataGridView.SelectedRows.Count == 1)
			{
				FormPlaneComponent form = Program.Container.Resolve<FormPlaneComponent>();
				int id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value);
				form.Id = id;
				form.Count = planeComponents[id].Item2;
				if (form.ShowDialog() == DialogResult.OK)
				{
					planeComponents[form.Id] = (form.ComponentName, form.Count);
					LoadData();
				}
			}

		}
		private void buttonDel_Click(object sender, EventArgs e)
		{
			if (dataGridView.SelectedRows.Count == 1)
			{
				if (MessageBox.Show("Удалить запись", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					try
					{

						planeComponents.Remove(Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value));
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					LoadData();
				}
			}
		}
		private void buttonRef_Click(object sender, EventArgs e)
		{
			LoadData();
		}
		private void buttonSave_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(textBoxName.Text))
			{
				MessageBox.Show("Заполните название", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (string.IsNullOrEmpty(textBoxPrice.Text))
			{
				MessageBox.Show("Заполните цену", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (planeComponents == null || planeComponents.Count == 0)
			{
				MessageBox.Show("Заполните компоненты", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			try
			{
				_logic.CreateOrUpdate(new PlaneBindingModel
				{
					Id = id,
					PlaneName = textBoxName.Text,
					Price = Convert.ToDecimal(textBoxPrice.Text),
					PlaneComponents = planeComponents
				});
				MessageBox.Show("Сохранение прошло успешно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
				DialogResult = DialogResult.OK;
				Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void buttonCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}
	}
}
