using System;
using AircraftPlantContracts.BindingModels;
using AircraftPlantContracts.BusinessLogicsContracts;
using AircraftPlantContracts.ViewModels;
using AircraftPlantBusinessLogic.BusinessLogics;
using System.Windows.Forms;
using Unity;
using System.Collections.Generic;

namespace AircraftPlantView
{
	public partial class FormCreateOrder : Form
	{
        private readonly IPlaneLogic _logicP;
		private readonly IOrderLogic _logicO;
        private readonly IClientLogic _logicC;
        public FormCreateOrder(PlaneLogic logicP, OrderLogic logicO, IClientLogic logicC)
		{
			InitializeComponent();
			_logicP = logicP;
			_logicO = logicO;
            _logicC = logicC;
        }
		private void FormCreateOrder_Load(object sender, EventArgs e)
		{
            try
            {
                List<ClientViewModel> listClients = _logicC.Read(null);
                if (listClients != null)
                {
                    comboBoxClient.DisplayMember = "ClientFIO";
                    comboBoxClient.ValueMember = "Id";
                    comboBoxClient.DataSource = listClients;
                    comboBoxClient.SelectedItem = null;
                }
                else
                {
                    throw new Exception("Не удалось загрузить список клиентов");
                }

                List<PlaneViewModel> list = _logicP.Read(null);
                if (list != null)
                {
                    comboBoxPlane.DisplayMember = "PlaneName";
                    comboBoxPlane.ValueMember = "Id";
                    comboBoxPlane.DataSource = list;
                    comboBoxPlane.SelectedItem = null;
                }
                else
                {
                    throw new Exception("Не удалось загрузить список изделий");
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
            if (comboBoxClient.SelectedValue == null)
            {
                MessageBox.Show("Выберите клиента", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                _logicO.CreateOrder(new CreateOrderBindingModel
                {
                    ClientId = Convert.ToInt32(comboBoxClient.SelectedValue),
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
