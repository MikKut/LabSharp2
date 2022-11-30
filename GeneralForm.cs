using Lab2.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Lb2_Sharp
{
    public partial class GeneralForm : Form
    {
        private Color _errorColor = Color.Red, _defaultColor = Color.DarkGray;
        private FactoriesDirection.FactoriesDirection factoriesDirection;
        private ForInvestorForm investorForm;
        private ChangeFactoryInfoForm changeFactoryInfoForm;
        private FactoryNumberChangerForm numberChangerForm;
        private UnitFactoriesForm unitsForm;
        public GeneralForm()
        {
            factoriesDirection = FactoriesDirection.FactoriesDirection.GetInstance();
            investorForm = new ForInvestorForm();
            changeFactoryInfoForm = new ChangeFactoryInfoForm();
            numberChangerForm = new FactoryNumberChangerForm();
            unitsForm = new UnitFactoriesForm();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void ForInvestorsButton_Click(object sender, EventArgs e)
        {
            try
            {
                investorForm.RenovateListOfFactories();
                this.Hide();
                investorForm.Show(this);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UnitFactoriesButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (NameForUnity1.Text == String.Empty || NameForUnity2.Text == String.Empty)
                {
                    throw new ArgumentNullException($"{nameof(NameForUnity1)} or {nameof(NameForUnity2)} is empty");
                }

                Factory factory1 = factoriesDirection.GetFactory(NameForUnity1.Text), factory2 = factoriesDirection.GetFactory(NameForUnity2.Text), unitedFactory = factory1 + factory2 ;
                if (!factoriesDirection.DeleteFactory(factory1))
                {
                    throw new KeyNotFoundException();
                }

                if (!factoriesDirection.DeleteFactory(factory2))
                {
                    throw new KeyNotFoundException();
                }

                if (!factoriesDirection.AddFactory(unitedFactory))
                {
                    throw new Exception("The factory already exists");
                }

                unitsForm.InitializeNewFactoryInfo(unitedFactory);
                UnitFactoriesBackground.BackColor = _defaultColor;
                this.Hide();
                unitsForm.Show(this);
            }
            catch(ArgumentNullException ex)
            {
                UnitFactoriesBackground.BackColor = _errorColor;
                MessageBox.Show(ex.Message);
            }
            catch(KeyNotFoundException ex)
            {
                UnitFactoriesBackground.BackColor = _errorColor;
                MessageBox.Show("There is no factory you want to delete");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FactoryInfoChangerButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ChangeFactoryInfoTextBox.Text == String.Empty)
                {
                    throw new ArgumentNullException($"{nameof(ChangeFactoryInfoTextBox)} is empty");
                }

                changeFactoryInfoForm.SetValuesOfTheFactory(ChangeFactoryInfoTextBox.Text);
                FactoryInfoChangerBackground.BackColor = _defaultColor;
                this.Hide();
                changeFactoryInfoForm.Show(this);
            }
            catch (KeyNotFoundException ex)
            {
                FactoryInfoChangerBackground.BackColor = _errorColor;
                MessageBox.Show("There is no factory you want to edit");
            }
            catch (ArgumentNullException ex)
            {
                FactoryInfoChangerBackground.BackColor = _errorColor;
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FactoryNumberChangerButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                numberChangerForm.Show(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FactoryInfoChangerButton_Click_1(object sender, EventArgs e)
        {

        }

        private void NameForUnity1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
