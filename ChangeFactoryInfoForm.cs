using Lab2.Model;
using Lb2_Sharp.FactoriesDirection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lb2_Sharp
{
    public partial class ChangeFactoryInfoForm : Form
    {
        FactoriesDirection.FactoriesDirection _factoriesDirection;
        public ChangeFactoryInfoForm()
        {
            _factoriesDirection = FactoriesDirection.FactoriesDirection.GetInstance();
            InitializeComponent();
        }

        private void BackToMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }

        private void SubmitFactoryInfo_Click(object sender, EventArgs e)
        {
            try
            {
                if (QuantityOfMastersNumeric.Value < 0 || QuantityOfSlavesNumeric.Value < 0 || NameBox.Text == String.Empty)
                {
                    throw new ArgumentException("Wrong input factory data");
                }
                var factory = _factoriesDirection.GetFactory(NameBox.Text);
                _factoriesDirection.DeleteFactory(factory);
                if (!_factoriesDirection.AddFactory(new Factory(NameBox.Text, (int)QuantityOfWorkshopsNumeric.Value, new FactoryHR(IncomePerSlaveNumeric.Value, IncomePerMasterNumeric.Value, (int)QuantityOfMastersNumeric.Value, (int)QuantityOfSlavesNumeric.Value))))
                {
                    MessageBox.Show("This factory already exists.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void SetValuesOfTheFactory(string factoryName)
        {
            var factory = _factoriesDirection.GetFactory(factoryName);
            NameBox.Text = factoryName;
            QuantityOfWorkshopsNumeric.Value = factory.QuantityOfWorkshops;
            QuantityOfMastersNumeric.Value = factory.FactoryHR.QuantityOfMasters;
            QuantityOfSlavesNumeric.Value =  factory.FactoryHR.QuantityOfSlaves;
            IncomePerMasterNumeric.Value = factory.FactoryHR.IncomePerMaster;
            IncomePerSlaveNumeric.Value = factory.FactoryHR.IncomePerSlave;
        }
        private void IncomePerSlaveNumeric_ValueChanged(object sender, EventArgs e)
        {

        }

        private void IncomePerMasterNumeric_ValueChanged(object sender, EventArgs e)
        {

        }

        private void IncomePerSlave_Click(object sender, EventArgs e)
        {

        }

        private void IncomePerMaster_Click(object sender, EventArgs e)
        {

        }

        private void QuantityOfSlavesLabel_Click(object sender, EventArgs e)
        {

        }

        private void QuantityOfSlavesNumeric_ValueChanged(object sender, EventArgs e)
        {

        }

        private void QuantityOfMasters_Click(object sender, EventArgs e)
        {

        }

        private void QuantityOfMastersNumeric_ValueChanged(object sender, EventArgs e)
        {

        }

        private void QuantityOfWorkshops_Click(object sender, EventArgs e)
        {

        }

        private void QuantityOfWorkshopsNumeric_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
