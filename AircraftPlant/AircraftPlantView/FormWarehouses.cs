using System;
using AircraftPlantBusinessLogic.BusinessLogics;
using AircraftPlantContracts.BindingModels;
using AircraftPlantContracts.BusinessLogicsContracts;
using Unity;
using System.Windows.Forms;

namespace AircraftPlantView
{
	public partial class FormWarehouses : Form
	{
		private readonly IWarehouseLogic logic;
		public FormWarehouses(IWarehouseLogic logic)
		{
			InitializeComponent();
			this.logic = logic;
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			var form = Program.Container.Resolve<FormWarehouse>();
			if (form.ShowDialog() == DialogResult.OK)
			{
				LoadData();
			}
		}

		private void buttonUpd_Click(object sender, EventArgs e)
		{
			if (dataGridView1.SelectedRows.Count == 1)
			{
				var form = Program.Container.Resolve<FormWarehouse>();
				form.Id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
				if (form.ShowDialog() == DialogResult.OK)
				{
					LoadData();
				}
			}
		}

		private void buttonDel_Click(object sender, EventArgs e)
		{
			if (dataGridView1.SelectedRows.Count == 1)
			{
				if (MessageBox.Show("Удалить запись", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
					try
					{
						logic.Delete(new WarehouseBindingModel { Id = id });
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

		private void FormWarehouses_Load(object sender, EventArgs e)
		{
			LoadData();
		}

		private void LoadData()
		{
			try
			{
				var list = logic.Read(null);
				if (list != null)
				{
					dataGridView1.DataSource = list;
					dataGridView1.Columns[0].Visible = false;
					dataGridView1.Columns[4].Visible = false;
					dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}
	}
}
