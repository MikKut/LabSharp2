using Lab2.Model;
using System;
using System.Windows.Forms;

namespace Lb2_Sharp
{
    public partial class FactoryNumberChangerForm : Form
    {
        FactoriesDirection.FactoriesDirection _factoriesDirection;
        public FactoryNumberChangerForm()
        {
            _factoriesDirection = FactoriesDirection.FactoriesDirection.GetInstance();
            InitializeComponent();
        }

        private void AddFactoryButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (QuantityOfMastersNumeric.Value < 0 || QuantityOfSlavesNumeric.Value < 0 || NameBox.Text == String.Empty)
                {
                    throw new ArgumentException("Wrong input factory data");
                }

                if (!_factoriesDirection.AddFactory(new Factory(NameBox.Text, (int)QuantityOfWorkshopsNumeric.Value, new FactoryHR(IncomePerSlaveNumeric.Value, IncomePerMasterNumeric.Value, (int)QuantityOfMastersNumeric.Value, (int)QuantityOfSlavesNumeric.Value))))
                {
                    MessageBox.Show("This factory already exists");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteFactoryButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (QuantityOfMastersNumeric.Value < 0 || QuantityOfSlavesNumeric.Value < 0 || NameBox.Text == String.Empty)
                {
                    throw new ArgumentException("Wrong input factory data");
                }

                if (!_factoriesDirection.DeleteFactory(new Factory(NameBox.Text, (int)QuantityOfWorkshopsNumeric.Value, new FactoryHR(IncomePerSlaveNumeric.Value, IncomePerMasterNumeric.Value, (int)QuantityOfMastersNumeric.Value, (int)QuantityOfSlavesNumeric.Value))))
                {
                    MessageBox.Show("Cannot delete the factory: nothing to delete");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BackToMainMenu_Click(object sender, EventArgs e)
        {
             this.Hide();
             this.Owner.Show();
        }
    }
}
