namespace Lb2_Sharp
{
    partial class ChangeFactoryInfoForm
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
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.QuantityOfWorkshopsNumeric = new System.Windows.Forms.NumericUpDown();
            this.QuantityOfWorkshops = new System.Windows.Forms.Label();
            this.QuantityOfMastersNumeric = new System.Windows.Forms.NumericUpDown();
            this.QuantityOfMasters = new System.Windows.Forms.Label();
            this.QuantityOfSlavesNumeric = new System.Windows.Forms.NumericUpDown();
            this.QuantityOfSlavesLabel = new System.Windows.Forms.Label();
            this.IncomePerMaster = new System.Windows.Forms.Label();
            this.IncomePerSlave = new System.Windows.Forms.Label();
            this.IncomePerMasterNumeric = new System.Windows.Forms.NumericUpDown();
            this.IncomePerSlaveNumeric = new System.Windows.Forms.NumericUpDown();
            this.SubmitFactoryInfo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityOfWorkshopsNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityOfMastersNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityOfSlavesNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IncomePerMasterNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IncomePerSlaveNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // BackToMainMenu
            // 
            this.BackToMainMenu.Location = new System.Drawing.Point(0, 2);
            this.BackToMainMenu.Name = "BackToMainMenu";
            this.BackToMainMenu.Size = new System.Drawing.Size(126, 39);
            this.BackToMainMenu.TabIndex = 0;
            this.BackToMainMenu.Text = "Back to main menu";
            this.BackToMainMenu.UseVisualStyleBackColor = true;
            this.BackToMainMenu.Click += new System.EventHandler(this.BackToMainMenu_Click);
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(60, 96);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(100, 20);
            this.NameBox.TabIndex = 1;
            this.NameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // QuantityOfWorkshopsNumeric
            // 
            this.QuantityOfWorkshopsNumeric.Location = new System.Drawing.Point(60, 167);
            this.QuantityOfWorkshopsNumeric.Name = "QuantityOfWorkshopsNumeric";
            this.QuantityOfWorkshopsNumeric.Size = new System.Drawing.Size(120, 20);
            this.QuantityOfWorkshopsNumeric.TabIndex = 3;
            this.QuantityOfWorkshopsNumeric.ValueChanged += new System.EventHandler(this.QuantityOfWorkshopsNumeric_ValueChanged);
            // 
            // QuantityOfWorkshops
            // 
            this.QuantityOfWorkshops.AutoSize = true;
            this.QuantityOfWorkshops.Location = new System.Drawing.Point(57, 140);
            this.QuantityOfWorkshops.Name = "QuantityOfWorkshops";
            this.QuantityOfWorkshops.Size = new System.Drawing.Size(112, 13);
            this.QuantityOfWorkshops.TabIndex = 4;
            this.QuantityOfWorkshops.Text = "Quantity of workshops";
            this.QuantityOfWorkshops.Click += new System.EventHandler(this.QuantityOfWorkshops_Click);
            // 
            // QuantityOfMastersNumeric
            // 
            this.QuantityOfMastersNumeric.Location = new System.Drawing.Point(295, 167);
            this.QuantityOfMastersNumeric.Name = "QuantityOfMastersNumeric";
            this.QuantityOfMastersNumeric.Size = new System.Drawing.Size(120, 20);
            this.QuantityOfMastersNumeric.TabIndex = 5;
            this.QuantityOfMastersNumeric.ValueChanged += new System.EventHandler(this.QuantityOfMastersNumeric_ValueChanged);
            // 
            // QuantityOfMasters
            // 
            this.QuantityOfMasters.AutoSize = true;
            this.QuantityOfMasters.Location = new System.Drawing.Point(292, 140);
            this.QuantityOfMasters.Name = "QuantityOfMasters";
            this.QuantityOfMasters.Size = new System.Drawing.Size(97, 13);
            this.QuantityOfMasters.TabIndex = 6;
            this.QuantityOfMasters.Text = "Quantity of masters";
            this.QuantityOfMasters.Click += new System.EventHandler(this.QuantityOfMasters_Click);
            // 
            // QuantityOfSlavesNumeric
            // 
            this.QuantityOfSlavesNumeric.Location = new System.Drawing.Point(500, 167);
            this.QuantityOfSlavesNumeric.Name = "QuantityOfSlavesNumeric";
            this.QuantityOfSlavesNumeric.Size = new System.Drawing.Size(120, 20);
            this.QuantityOfSlavesNumeric.TabIndex = 7;
            this.QuantityOfSlavesNumeric.ValueChanged += new System.EventHandler(this.QuantityOfSlavesNumeric_ValueChanged);
            // 
            // QuantityOfSlavesLabel
            // 
            this.QuantityOfSlavesLabel.AutoSize = true;
            this.QuantityOfSlavesLabel.Location = new System.Drawing.Point(497, 140);
            this.QuantityOfSlavesLabel.Name = "QuantityOfSlavesLabel";
            this.QuantityOfSlavesLabel.Size = new System.Drawing.Size(111, 13);
            this.QuantityOfSlavesLabel.TabIndex = 8;
            this.QuantityOfSlavesLabel.Text = "Quantity of employees";
            this.QuantityOfSlavesLabel.Click += new System.EventHandler(this.QuantityOfSlavesLabel_Click);
            // 
            // IncomePerMaster
            // 
            this.IncomePerMaster.AutoSize = true;
            this.IncomePerMaster.Location = new System.Drawing.Point(292, 68);
            this.IncomePerMaster.Name = "IncomePerMaster";
            this.IncomePerMaster.Size = new System.Drawing.Size(94, 13);
            this.IncomePerMaster.TabIndex = 10;
            this.IncomePerMaster.Text = "Income per master";
            this.IncomePerMaster.Click += new System.EventHandler(this.IncomePerMaster_Click);
            // 
            // IncomePerSlave
            // 
            this.IncomePerSlave.AutoSize = true;
            this.IncomePerSlave.Location = new System.Drawing.Point(497, 68);
            this.IncomePerSlave.Name = "IncomePerSlave";
            this.IncomePerSlave.Size = new System.Drawing.Size(108, 13);
            this.IncomePerSlave.TabIndex = 12;
            this.IncomePerSlave.Text = "Income per employee";
            this.IncomePerSlave.Click += new System.EventHandler(this.IncomePerSlave_Click);
            // 
            // IncomePerMasterNumeric
            // 
            this.IncomePerMasterNumeric.Location = new System.Drawing.Point(295, 97);
            this.IncomePerMasterNumeric.Name = "IncomePerMasterNumeric";
            this.IncomePerMasterNumeric.Size = new System.Drawing.Size(120, 20);
            this.IncomePerMasterNumeric.TabIndex = 13;
            this.IncomePerMasterNumeric.ValueChanged += new System.EventHandler(this.IncomePerMasterNumeric_ValueChanged);
            // 
            // IncomePerSlaveNumeric
            // 
            this.IncomePerSlaveNumeric.Location = new System.Drawing.Point(500, 96);
            this.IncomePerSlaveNumeric.Name = "IncomePerSlaveNumeric";
            this.IncomePerSlaveNumeric.Size = new System.Drawing.Size(120, 20);
            this.IncomePerSlaveNumeric.TabIndex = 14;
            this.IncomePerSlaveNumeric.ValueChanged += new System.EventHandler(this.IncomePerSlaveNumeric_ValueChanged);
            // 
            // SubmitFactoryInfo
            // 
            this.SubmitFactoryInfo.Location = new System.Drawing.Point(253, 285);
            this.SubmitFactoryInfo.Name = "SubmitFactoryInfo";
            this.SubmitFactoryInfo.Size = new System.Drawing.Size(205, 44);
            this.SubmitFactoryInfo.TabIndex = 15;
            this.SubmitFactoryInfo.Text = "Submit";
            this.SubmitFactoryInfo.UseVisualStyleBackColor = true;
            this.SubmitFactoryInfo.Click += new System.EventHandler(this.SubmitFactoryInfo_Click);
            // 
            // ChangeFactoryInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SubmitFactoryInfo);
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
            this.Controls.Add(this.BackToMainMenu);
            this.Name = "ChangeFactoryInfoForm";
            this.Text = "ChangeFactoryInfocs";
            ((System.ComponentModel.ISupportInitialize)(this.QuantityOfWorkshopsNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityOfMastersNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityOfSlavesNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IncomePerMasterNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IncomePerSlaveNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackToMainMenu;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown QuantityOfWorkshopsNumeric;
        private System.Windows.Forms.Label QuantityOfWorkshops;
        private System.Windows.Forms.NumericUpDown QuantityOfMastersNumeric;
        private System.Windows.Forms.Label QuantityOfMasters;
        private System.Windows.Forms.NumericUpDown QuantityOfSlavesNumeric;
        private System.Windows.Forms.Label QuantityOfSlavesLabel;
        private System.Windows.Forms.Label IncomePerMaster;
        private System.Windows.Forms.Label IncomePerSlave;
        private System.Windows.Forms.NumericUpDown IncomePerMasterNumeric;
        private System.Windows.Forms.NumericUpDown IncomePerSlaveNumeric;
        private System.Windows.Forms.Button SubmitFactoryInfo;
    }
}