namespace УП_Задание_4
{
    partial class AddEditProductForm
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
            this.lblArticle = new System.Windows.Forms.Label();
            this.txtArticle = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblMaterial = new System.Windows.Forms.Label();
            this.cmbMaterial = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.lblMinPrice = new System.Windows.Forms.Label();
            this.txtMinPrice = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblArticle
            // 
            this.lblArticle.AutoSize = true;
            this.lblArticle.Location = new System.Drawing.Point(12, 20);
            this.lblArticle.Name = "lblArticle";
            this.lblArticle.Size = new System.Drawing.Size(55, 15);
            this.lblArticle.TabIndex = 0;
            this.lblArticle.Text = "Артикул:";
            // 
            // txtArticle
            // 
            this.txtArticle.Location = new System.Drawing.Point(120, 17);
            this.txtArticle.Name = "txtArticle";
            this.txtArticle.Size = new System.Drawing.Size(200, 23);
            this.txtArticle.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 50);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(83, 15);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Наименование:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(120, 47);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 23);
            this.txtName.TabIndex = 3;
            // 
            // lblMaterial
            // 
            this.lblMaterial.AutoSize = true;
            this.lblMaterial.Location = new System.Drawing.Point(12, 80);
            this.lblMaterial.Name = "lblMaterial";
            this.lblMaterial.Size = new System.Drawing.Size(66, 15);
            this.lblMaterial.TabIndex = 4;
            this.lblMaterial.Text = "Материал:";
            // 
            // cmbMaterial
            // 
            this.cmbMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaterial.FormattingEnabled = true;
            this.cmbMaterial.Location = new System.Drawing.Point(120, 77);
            this.cmbMaterial.Name = "cmbMaterial";
            this.cmbMaterial.Size = new System.Drawing.Size(200, 23);
            this.cmbMaterial.TabIndex = 5;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(12, 110);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(91, 15);
            this.lblType.TabIndex = 6;
            this.lblType.Text = "Тип продукции:";
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(120, 107);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(200, 23);
            this.cmbType.TabIndex = 7;
            // 
            // lblMinPrice
            // 
            this.lblMinPrice.AutoSize = true;
            this.lblMinPrice.Location = new System.Drawing.Point(12, 140);
            this.lblMinPrice.Name = "lblMinPrice";
            this.lblMinPrice.Size = new System.Drawing.Size(99, 15);
            this.lblMinPrice.TabIndex = 8;
            this.lblMinPrice.Text = "Мин. цена (руб):";
            // 
            // txtMinPrice
            // 
            this.txtMinPrice.Location = new System.Drawing.Point(120, 137);
            this.txtMinPrice.Name = "txtMinPrice";
            this.txtMinPrice.Size = new System.Drawing.Size(200, 23);
            this.txtMinPrice.TabIndex = 9;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(12, 170);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(132, 15);
            this.lblTime.TabIndex = 10;
            this.lblTime.Text = "Время изготовления (ч):";
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(120, 167);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(200, 23);
            this.txtTime.TabIndex = 11;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(12, 200);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(88, 15);
            this.lblCost.TabIndex = 12;
            this.lblCost.Text = "Себестоимость:";
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(120, 197);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(200, 23);
            this.txtCost.TabIndex = 13;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(12, 230);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(112, 15);
            this.lblStock.TabIndex = 14;
            this.lblStock.Text = "Кол-во на складе:";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(120, 227);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(200, 23);
            this.txtStock.TabIndex = 15;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(120, 270);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 30);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(230, 270);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 30);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddEditProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 320);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.txtMinPrice);
            this.Controls.Add(this.lblMinPrice);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.cmbMaterial);
            this.Controls.Add(this.lblMaterial);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtArticle);
            this.Controls.Add(this.lblArticle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEditProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление продукции";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblArticle;
        private System.Windows.Forms.TextBox txtArticle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblMaterial;
        private System.Windows.Forms.ComboBox cmbMaterial;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label lblMinPrice;
        private System.Windows.Forms.TextBox txtMinPrice;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}