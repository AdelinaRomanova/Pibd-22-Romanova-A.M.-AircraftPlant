using AircraftPlantContracts.BindingModels;
using AircraftPlantBusinessLogic.BusinessLogics;
using System;
using System.Windows.Forms;
using Unity;

namespace AircraftPlantView
{
	public partial class FormMain : Form
	{
		private readonly OrderLogic _orderLogic;
		public FormMain(OrderLogic orderLogic)
		{
			InitializeComponent();
			_orderLogic = orderLogic;
		}
		private void LoadData()
		{
			try
			{
				var list = _orderLogic.Read(null);
				if (list != null)
				{
					dataGridView.DataSource = list;
					dataGridView.Columns[0].Visible = false;
					dataGridView.Columns[1].Visible = false;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void компонентыToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var form = Program.Container.Resolve<FormComponents>();
			form.ShowDialog();
		}
		private void изделияToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var form = Program.Container.Resolve<FormPlanes>();
			form.ShowDialog();
		}
		private void buttonCreateOrder_Click(object sender, EventArgs e)
		{
			var form = Program.Container.Resolve<FormCreateOrder>();
			form.ShowDialog();
			LoadData();
		}
		private void buttonTakeOrder_Click(object sender, EventArgs e)
		{
			if (dataGridView.SelectedRows.Count == 1)
			{
				int id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value);
				try
				{
					_orderLogic.TakeOrderInWork(new ChangeStatusBindingModel
					{
						OrderId = id
					});
					LoadData();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}

		}
		private void buttonOrderReady_Click(object sender, EventArgs e)
		{
			if (dataGridView.SelectedRows.Count == 1)
			{
				int id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value);
				try
				{
					_orderLogic.FinishOrder(new ChangeStatusBindingModel
					{
						OrderId = id
					});
					LoadData();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
				   MessageBoxIcon.Error);
				}
			}
		}
		private void buttonIssuedOrder_Click(object sender, EventArgs e)
		{
			if (dataGridView.SelectedRows.Count == 1)
			{
				int id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value);
				try
				{
					_orderLogic.DeliveryOrder(new ChangeStatusBindingModel
					{
						OrderId = id
					});
					LoadData();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
				   MessageBoxIcon.Error);
				}
			}
		}
		private void buttonRef_Click(object sender, EventArgs e)
		{
			LoadData();
		}
		private void FormMain_Load(object sender, EventArgs e)
		{
			LoadData();
		}
	}
}
