using System;
using AircraftPlantContracts.BindingModels;
using AircraftPlantContracts.BusinessLogicsContracts;
using AircraftPlantContracts.ViewModels;
using AircraftPlantBusinessLogic.BusinessLogics;
using System.Windows.Forms;
using Unity;

namespace AircraftPlantView
{
	public partial class FormCreateOrder : Form
	{
        private readonly IPlaneLogic _logicP;
		private readonly IOrderLogic _logicO;
		public FormCreateOrder(PlaneLogic logicP, OrderLogic logicO)
		{
			InitializeComponent();
			_logicP = logicP;
			_logicO = logicO;
		}
		private void FormCreateOrder_Load(object sender, EventArgs e)
		{
            try
            {
                var list = _logicP.Read(null);
                if (list != null)
                {
                    comboBoxPlane.DisplayMember = "PlaneName";
                    comboBoxPlane.ValueMember = "Id";
                    comboBoxPlane.DataSource = list;                    
                    comboBoxPlane.SelectedItem = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CalcSum()
        {
            if (comboBoxPlane.SelectedValue != null && !string.IsNullOrEmpty(textBoxCount.Text))
            {
                try
                {
                    int id = Convert.ToInt32(comboBoxPlane.SelectedValue);
                    PlaneViewModel plane = _logicP.Read(new PlaneBindingModel { Id = id })?[0];
                    int count = Convert.ToInt32(textBoxCount.Text);
                    textBoxSum.Text = (count * plane?.Price ?? 0).ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void textBoxCount_TextChanged(object sender, EventArgs e)
        {
            CalcSum();
        }
        private void comboBoxPlane_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcSum();
        }
        private void buttonSave_Click(object sender, EventArgs e)
		{
            if (string.IsNullOrEmpty(textBoxCount.Text))
            {
                MessageBox.Show("Заполните поле Количество", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comboBoxPlane.SelectedValue == null)
            {
                MessageBox.Show("Выберите изделие", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                _logicO.CreateOrder(new CreateOrderBindingModel
                {
                    PlaneId = Convert.ToInt32(comboBoxPlane.SelectedValue),
                    Count = Convert.ToInt32(textBoxCount.Text),
                    Sum = Convert.ToDecimal(textBoxSum.Text)
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
