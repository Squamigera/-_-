namespace УП_Задание_4
{
    partial class AddEditMaterialForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.cmbMaterialType = new System.Windows.Forms.ComboBox();
            this.lblUnit = new System.Windows.Forms.Label();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.lblMinStock = new System.Windows.Forms.Label();
            this.txtMinStock = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(10, 17);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(86, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Наименование:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(104, 16);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(172, 20);
            this.txtName.TabIndex = 1;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(10, 43);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(87, 13);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "Тип материала:";
            // 
            // cmbMaterialType
            // 
            this.cmbMaterialType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaterialType.FormattingEnabled = true;
            this.cmbMaterialType.Location = new System.Drawing.Point(104, 42);
            this.cmbMaterialType.Name = "cmbMaterialType";
            this.cmbMaterialType.Size = new System.Drawing.Size(172, 21);
            this.cmbMaterialType.TabIndex = 3;
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Location = new System.Drawing.Point(10, 69);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(85, 13);
            this.lblUnit.TabIndex = 4;
            this.lblUnit.Text = "Ед. измерения:";
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(104, 68);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(172, 20);
            this.txtUnit.TabIndex = 5;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(10, 95);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(65, 13);
            this.lblCost.TabIndex = 6;
            this.lblCost.Text = "Стоимость:";
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(104, 94);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(172, 20);
            this.txtCost.TabIndex = 7;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(10, 121);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(98, 13);
            this.lblStock.TabIndex = 8;
            this.lblStock.Text = "Кол-во на складе:";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(104, 120);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(172, 20);
            this.txtStock.TabIndex = 9;
            // 
            // lblMinStock
            // 
            this.lblMinStock.AutoSize = true;
            this.lblMinStock.Location = new System.Drawing.Point(10, 147);
            this.lblMinStock.Name = "lblMinStock";
            this.lblMinStock.Size = new System.Drawing.Size(67, 13);
            this.lblMinStock.TabIndex = 10;
            this.lblMinStock.Text = "Мин. запас:";
            // 
            // txtMinStock
            // 
            this.txtMinStock.Location = new System.Drawing.Point(104, 146);
            this.txtMinStock.Name = "txtMinStock";
            this.txtMinStock.Size = new System.Drawing.Size(172, 20);
            this.txtMinStock.TabIndex = 11;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(104, 183);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(77, 26);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(198, 183);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(77, 26);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddEditMaterialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 225);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtMinStock);
            this.Controls.Add(this.lblMinStock);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.txtUnit);
            this.Controls.Add(this.lblUnit);
            this.Controls.Add(this.cmbMaterialType);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEditMaterialForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление материала";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cmbMaterialType;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label lblMinStock;
        private System.Windows.Forms.TextBox txtMinStock;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}