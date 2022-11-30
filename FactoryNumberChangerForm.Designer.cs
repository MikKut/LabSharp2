namespace Lb2_Sharp
{
    partial class FactoryNumberChangerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BackToMainMenu = new System.Windows.Forms.Button();
            this.AddFactoryButton = new System.Windows.Forms.Button();
            this.IncomePerSlaveNumeric = new System.Windows.Forms.NumericUpDown();
            this.IncomePerMasterNumeric = new System.Windows.Forms.NumericUpDown();
            this.IncomePerSlave = new System.Windows.Forms.Label();
            this.IncomePerMaster = new System.Windows.Forms.Label();
            this.QuantityOfSlavesLabel = new System.Windows.Forms.Label();
            this.QuantityOfSlavesNumeric = new System.Windows.Forms.NumericUpDown();
            this.QuantityOfMasters = new System.Windows.Forms.Label();
            this.QuantityOfMastersNumeric = new System.Windows.Forms.NumericUpDown();
            this.QuantityOfWorkshops = new System.Windows.Forms.Label();
            this.QuantityOfWorkshopsNumeric = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.DeeteFactoryButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.IncomePerSlaveNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IncomePerMasterNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityOfSlavesNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityOfMastersNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityOfWorkshopsNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // BackToMainMenu
            // 
            this.BackToMainMenu.Location = new System.Drawing.Point(0, -2);
            this.BackToMainMenu.Name = "BackToMainMenu";
            this.BackToMainMenu.Size = new System.Drawing.Size(126, 39);
            this.BackToMainMenu.TabIndex = 1;
            this.BackToMainMenu.Text = "Back to main menu";
            this.BackToMainMenu.UseVisualStyleBackColor = true;
            this.BackToMainMenu.Click += new System.EventHandler(this.BackToMainMenu_Click);
            // 
            // AddFactoryButton
            // 
            this.AddFactoryButton.Location = new System.Drawing.Point(58, 276);
            this.AddFactoryButton.Name = "AddFactoryButton";
            this.AddFactoryButton.Size = new System.Drawing.Size(205, 44);
            this.AddFactoryButton.TabIndex = 29;
            this.AddFactoryButton.Text = "Add factory";
            this.AddFactoryButton.UseVisualStyleBackColor = true;
            this.AddFactoryButton.Click += new System.EventHandler(this.AddFactoryButton_Click);
            // 
            // IncomePerSlaveNumeric
            // 
            this.IncomePerSlaveNumeric.Location = new System.Drawing.Point(498, 95);
            this.IncomePerSlaveNumeric.Name = "IncomePerSlaveNumeric";
            this.IncomePerSlaveNumeric.Size = new System.Drawing.Size(120, 20);
            this.IncomePerSlaveNumeric.TabIndex = 28;
            // 
            // IncomePerMasterNumeric
            // 
            this.IncomePerMasterNumeric.Location = new System.Drawing.Point(293, 96);
            this.IncomePerMasterNumeric.Name = "IncomePerMasterNumeric";
            this.IncomePerMasterNumeric.Size = new System.Drawing.Size(120, 20);
            this.IncomePerMasterNumeric.TabIndex = 27;
            // 
            // IncomePerSlave
            // 
            this.IncomePerSlave.AutoSize = true;
            this.IncomePerSlave.Location = new System.Drawing.Point(495, 67);
            this.IncomePerSlave.Name = "IncomePerSlave";
            this.IncomePerSlave.Size = new System.Drawing.Size(108, 13);
            this.IncomePerSlave.TabIndex = 26;
            this.IncomePerSlave.Text = "Income per employee";
            // 
            // IncomePerMaster
            // 
            this.IncomePerMaster.AutoSize = true;
            this.IncomePerMaster.Location = new System.Drawing.Point(290, 67);
            this.IncomePerMaster.Name = "IncomePerMaster";
            this.IncomePerMaster.Size = new System.Drawing.Size(94, 13);
            this.IncomePerMaster.TabIndex = 25;
            this.IncomePerMaster.Text = "Income per master";
            // 
            // QuantityOfSlavesLabel
            // 
            this.QuantityOfSlavesLabel.AutoSize = true;
            this.QuantityOfSlavesLabel.Location = new System.Drawing.Point(495, 139);
            this.QuantityOfSlavesLabel.Name = "QuantityOfSlavesLabel";
            this.QuantityOfSlavesLabel.Size = new System.Drawing.Size(111, 13);
            this.QuantityOfSlavesLabel.TabIndex = 24;
            this.QuantityOfSlavesLabel.Text = "Quantity of employees";
            // 
            // QuantityOfSlavesNumeric
            // 
            this.QuantityOfSlavesNumeric.Location = new System.Drawing.Point(498, 166);
            this.QuantityOfSlavesNumeric.Name = "QuantityOfSlavesNumeric";
            this.QuantityOfSlavesNumeric.Size = new System.Drawing.Size(120, 20);
            this.QuantityOfSlavesNumeric.TabIndex = 23;
            // 
            // QuantityOfMasters
            // 
            this.QuantityOfMasters.AutoSize = true;
            this.QuantityOfMasters.Location = new System.Drawing.Point(290, 139);
            this.QuantityOfMasters.Name = "QuantityOfMasters";
            this.QuantityOfMasters.Size = new System.Drawing.Size(97, 13);
            this.QuantityOfMasters.TabIndex = 22;
            this.QuantityOfMasters.Text = "Quantity of masters";
            // 
            // QuantityOfMastersNumeric
            // 
            this.QuantityOfMastersNumeric.Location = new System.Drawing.Point(293, 166);
            this.QuantityOfMastersNumeric.Name = "QuantityOfMastersNumeric";
            this.QuantityOfMastersNumeric.Size = new System.Drawing.Size(120, 20);
            this.QuantityOfMastersNumeric.TabIndex = 21;
            // 
            // QuantityOfWorkshops
            // 
            this.QuantityOfWorkshops.AutoSize = true;
            this.QuantityOfWorkshops.Location = new System.Drawing.Point(55, 139);
            this.QuantityOfWorkshops.Name = "QuantityOfWorkshops";
            this.QuantityOfWorkshops.Size = new System.Drawing.Size(112, 13);
            this.QuantityOfWorkshops.TabIndex = 20;
            this.QuantityOfWorkshops.Text = "Quantity of workshops";
            // 
            // QuantityOfWorkshopsNumeric
            // 
            this.QuantityOfWorkshopsNumeric.Location = new System.Drawing.Point(58, 166);
            this.QuantityOfWorkshopsNumeric.Name = "QuantityOfWorkshopsNumeric";
            this.QuantityOfWorkshopsNumeric.Size = new System.Drawing.Size(120, 20);
            this.QuantityOfWorkshopsNumeric.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Name";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(58, 95);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(100, 20);
            this.NameBox.TabIndex = 17;
            // 
            // DeeteFactoryButton
            // 
            this.DeeteFactoryButton.Location = new System.Drawing.Point(441, 279);
            this.DeeteFactoryButton.Name = "DeeteFactoryButton";
            this.DeeteFactoryButton.Size = new System.Drawing.Size(177, 39);
            this.DeeteFactoryButton.TabIndex = 16;
            this.DeeteFactoryButton.Text = "Delete factory";
            this.DeeteFactoryButton.UseVisualStyleBackColor = true;
            this.DeeteFactoryButton.Click += new System.EventHandler(this.DeleteFactoryButton_Click);
            // 
            // FactoryNumberChangerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 376);
            this.Controls.Add(this.AddFactoryButton);
            this.Controls.Add(this.IncomePerSlaveNumeric);
            this.Controls.Add(this.IncomePerMasterNumeric);
            this.Controls.Add(this.IncomePerSlave);
            this.Controls.Add(this.IncomePerMaster);
            this.Controls.Add(this.QuantityOfSlavesLabel);
            this.Controls.Add(this.QuantityOfSlavesNumeric);
            this.Controls.Add(this.QuantityOfMasters);
            this.Controls.Add(this.QuantityOfMastersNumeric);
            this.Controls.Add(this.QuantityOfWorkshops);
            this.Controls.Add(this.QuantityOfWorkshopsNumeric);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.DeeteFactoryButton);
            this.Controls.Add(this.BackToMainMenu);
            this.Name = "FactoryNumberChangerForm";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.IncomePerSlaveNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IncomePerMasterNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityOfSlavesNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityOfMastersNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityOfWorkshopsNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackToMainMenu;
        private System.Windows.Forms.Button AddFactoryButton;
        private System.Windows.Forms.NumericUpDown IncomePerSlaveNumeric;
        private System.Windows.Forms.NumericUpDown IncomePerMasterNumeric;
        private System.Windows.Forms.Label IncomePerSlave;
        private System.Windows.Forms.Label IncomePerMaster;
        private System.Windows.Forms.Label QuantityOfSlavesLabel;
        private System.Windows.Forms.NumericUpDown QuantityOfSlavesNumeric;
        private System.Windows.Forms.Label QuantityOfMasters;
        private System.Windows.Forms.NumericUpDown QuantityOfMastersNumeric;
        private System.Windows.Forms.Label QuantityOfWorkshops;
        private System.Windows.Forms.NumericUpDown QuantityOfWorkshopsNumeric;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Button DeeteFactoryButton;
    }
}