using AircraftPlantContracts.BindingModels;
using AircraftPlantBusinessLogic.BusinessLogics;
using AircraftPlantContracts.BusinessLogicsContracts;
using AircraftPlantBusinessLogic.OfficePackage;
using System;
using System.Windows.Forms;
using Unity;

namespace AircraftPlantView
{
	public partial class FormMain : Form
	{
		private readonly OrderLogic _orderLogic;
		private readonly IReportLogic _reportLogic;
		private readonly IImplementerLogic _implementerLogic;
		private readonly IWorkProcess _workProcces;
		public FormMain(OrderLogic orderLogic, IReportLogic reportLogic, IWorkProcess workProcess, IImplementerLogic implementerLogic)
		{
			InitializeComponent();
			_orderLogic = orderLogic;
			_reportLogic = reportLogic;
			_implementerLogic = implementerLogic;
			_workProcces = workProcess;
		}
		private void LoadData()
		{
				var list = _orderLogic.Read(null);
				if (list != null)
				{
					dataGridView.DataSource = list;
					dataGridView.Columns[0].Visible = false;
					dataGridView.Columns[1].Visible = false;
					dataGridView.Columns[2].Visible = false;
					dataGridView.Columns[3].Visible = false;
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
		private void ComponentsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using var dialog = new SaveFileDialog { Filter = "docx|*.docx" };
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				_reportLogic.SaveComponentsToWordFile(new ReportBindingModel
				{
					FileName = dialog.FileName
				});
				MessageBox.Show("Выполнено", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}

		}
		private void ComponentProductsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var form = Program.Container.Resolve<FormReportPlaneComponents>();
			form.ShowDialog();
		}
		private void OredersToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var form = Program.Container.Resolve<FormReportOrders>();
			form.ShowDialog();
		}
		private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var form = Program.Container.Resolve<FormClients>();
			form.ShowDialog();
		}
        private void исполнителиToolStripMenuItem_Click(object sender, EventArgs e)
        {
			var form = Program.Container.Resolve<FormImplementers>();
			form.ShowDialog();
		}
		private void запускРаботыToolStripMenuItem_Click(object sender, EventArgs e)
		{
			_workProcces.DoWork(_implementerLogic, _orderLogic);
			LoadData();
		}
	}
}
