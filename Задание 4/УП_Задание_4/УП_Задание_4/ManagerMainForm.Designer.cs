namespace УП_Задание_4
{
    partial class ManagerMainForm
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
            this.btnProductTypes = new System.Windows.Forms.Button();
            this.btnMaterialTypes = new System.Windows.Forms.Button();
            this.btnMaterials = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnSuppliers = new System.Windows.Forms.Button();
            this.btnPartners = new System.Windows.Forms.Button();
            this.tabPageSales = new System.Windows.Forms.TabPage();
            this.dgvSalesRequests = new System.Windows.Forms.DataGridView();
            this.panelSales = new System.Windows.Forms.Panel();
            this.btnRefreshSales = new System.Windows.Forms.Button();
            this.btnCreateSales = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageSupply = new System.Windows.Forms.TabPage();
            this.dgvSupplyRequests = new System.Windows.Forms.DataGridView();
            this.panelSupply = new System.Windows.Forms.Panel();
            this.btnRefreshSupply = new System.Windows.Forms.Button();
            this.btnCreateSupply = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnShowDiscounts = new System.Windows.Forms.Button();
            this.tabPageSales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesRequests)).BeginInit();
            this.panelSales.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageSupply.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplyRequests)).BeginInit();
            this.panelSupply.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnProductTypes
            // 
            this.btnProductTypes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(128)))));
            this.btnProductTypes.Location = new System.Drawing.Point(622, 298);
            this.btnProductTypes.Name = "btnProductTypes";
            this.btnProductTypes.Size = new System.Drawing.Size(150, 60);
            this.btnProductTypes.TabIndex = 6;
            this.btnProductTypes.Text = "Типы продукции";
            this.btnProductTypes.UseVisualStyleBackColor = false;
            this.btnProductTypes.Click += new System.EventHandler(this.btnProductTypes_Click);
            // 
            // btnMaterialTypes
            // 
            this.btnMaterialTypes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(128)))));
            this.btnMaterialTypes.Location = new System.Drawing.Point(622, 232);
            this.btnMaterialTypes.Name = "btnMaterialTypes";
            this.btnMaterialTypes.Size = new System.Drawing.Size(150, 60);
            this.btnMaterialTypes.TabIndex = 5;
            this.btnMaterialTypes.Text = "Типы материалов";
            this.btnMaterialTypes.UseVisualStyleBackColor = false;
            this.btnMaterialTypes.Click += new System.EventHandler(this.btnMaterialTypes_Click);
            // 
            // btnMaterials
            // 
            this.btnMaterials.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(128)))));
            this.btnMaterials.Location = new System.Drawing.Point(622, 166);
            this.btnMaterials.Name = "btnMaterials";
            this.btnMaterials.Size = new System.Drawing.Size(150, 60);
            this.btnMaterials.TabIndex = 4;
            this.btnMaterials.Text = "Материалы";
            this.btnMaterials.UseVisualStyleBackColor = false;
            this.btnMaterials.Click += new System.EventHandler(this.btnMaterials_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(128)))));
            this.btnProduct.Location = new System.Drawing.Point(622, 365);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(150, 60);
            this.btnProduct.TabIndex = 3;
            this.btnProduct.Text = "Продукция";
            this.btnProduct.UseVisualStyleBackColor = false;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnSuppliers
            // 
            this.btnSuppliers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(128)))));
            this.btnSuppliers.Location = new System.Drawing.Point(622, 100);
            this.btnSuppliers.Name = "btnSuppliers";
            this.btnSuppliers.Size = new System.Drawing.Size(150, 60);
            this.btnSuppliers.TabIndex = 2;
            this.btnSuppliers.Text = "Поставщики";
            this.btnSuppliers.UseVisualStyleBackColor = false;
            this.btnSuppliers.Click += new System.EventHandler(this.btnSuppliers_Click);
            // 
            // btnPartners
            // 
            this.btnPartners.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(128)))));
            this.btnPartners.Location = new System.Drawing.Point(622, 34);
            this.btnPartners.Name = "btnPartners";
            this.btnPartners.Size = new System.Drawing.Size(150, 60);
            this.btnPartners.TabIndex = 1;
            this.btnPartners.Text = "Партнеры";
            this.btnPartners.UseVisualStyleBackColor = false;
            this.btnPartners.Click += new System.EventHandler(this.btnPartners_Click);
            // 
            // tabPageSales
            // 
            this.tabPageSales.Controls.Add(this.dgvSalesRequests);
            this.tabPageSales.Controls.Add(this.panelSales);
            this.tabPageSales.Location = new System.Drawing.Point(4, 22);
            this.tabPageSales.Name = "tabPageSales";
            this.tabPageSales.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSales.Size = new System.Drawing.Size(590, 415);
            this.tabPageSales.TabIndex = 1;
            this.tabPageSales.Text = "Заявки на продажу";
            this.tabPageSales.UseVisualStyleBackColor = true;
            // 
            // dgvSalesRequests
            // 
            this.dgvSalesRequests.AllowUserToAddRows = false;
            this.dgvSalesRequests.AllowUserToDeleteRows = false;
            this.dgvSalesRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalesRequests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSalesRequests.Location = new System.Drawing.Point(3, 40);
            this.dgvSalesRequests.Name = "dgvSalesRequests";
            this.dgvSalesRequests.ReadOnly = true;
            this.dgvSalesRequests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSalesRequests.Size = new System.Drawing.Size(584, 372);
            this.dgvSalesRequests.TabIndex = 2;
            // 
            // panelSales
            // 
            this.panelSales.Controls.Add(this.btnRefreshSales);
            this.panelSales.Controls.Add(this.btnCreateSales);
            this.panelSales.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSales.Location = new System.Drawing.Point(3, 3);
            this.panelSales.Name = "panelSales";
            this.panelSales.Size = new System.Drawing.Size(584, 37);
            this.panelSales.TabIndex = 1;
            // 
            // btnRefreshSales
            // 
            this.btnRefreshSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(128)))));
            this.btnRefreshSales.Location = new System.Drawing.Point(10, 7);
            this.btnRefreshSales.Name = "btnRefreshSales";
            this.btnRefreshSales.Size = new System.Drawing.Size(100, 25);
            this.btnRefreshSales.TabIndex = 1;
            this.btnRefreshSales.Text = "Обновить";
            this.btnRefreshSales.UseVisualStyleBackColor = false;
            this.btnRefreshSales.Click += new System.EventHandler(this.btnRefreshSales_Click);
            // 
            // btnCreateSales
            // 
            this.btnCreateSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(128)))));
            this.btnCreateSales.Location = new System.Drawing.Point(120, 7);
            this.btnCreateSales.Name = "btnCreateSales";
            this.btnCreateSales.Size = new System.Drawing.Size(120, 25);
            this.btnCreateSales.TabIndex = 2;
            this.btnCreateSales.Text = "Создать заявку";
            this.btnCreateSales.UseVisualStyleBackColor = false;
            this.btnCreateSales.Click += new System.EventHandler(this.btnCreateSales_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageSupply);
            this.tabControl1.Controls.Add(this.tabPageSales);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(598, 441);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageSupply
            // 
            this.tabPageSupply.Controls.Add(this.dgvSupplyRequests);
            this.tabPageSupply.Controls.Add(this.panelSupply);
            this.tabPageSupply.Location = new System.Drawing.Point(4, 22);
            this.tabPageSupply.Name = "tabPageSupply";
            this.tabPageSupply.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSupply.Size = new System.Drawing.Size(590, 415);
            this.tabPageSupply.TabIndex = 0;
            this.tabPageSupply.Text = "Заявки на поставку";
            this.tabPageSupply.UseVisualStyleBackColor = true;
            // 
            // dgvSupplyRequests
            // 
            this.dgvSupplyRequests.AllowUserToAddRows = false;
            this.dgvSupplyRequests.AllowUserToDeleteRows = false;
            this.dgvSupplyRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSupplyRequests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSupplyRequests.Location = new System.Drawing.Point(3, 40);
            this.dgvSupplyRequests.Name = "dgvSupplyRequests";
            this.dgvSupplyRequests.ReadOnly = true;
            this.dgvSupplyRequests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSupplyRequests.Size = new System.Drawing.Size(584, 372);
            this.dgvSupplyRequests.TabIndex = 1;
            // 
            // panelSupply
            // 
            this.panelSupply.Controls.Add(this.btnRefreshSupply);
            this.panelSupply.Controls.Add(this.btnCreateSupply);
            this.panelSupply.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSupply.Location = new System.Drawing.Point(3, 3);
            this.panelSupply.Name = "panelSupply";
            this.panelSupply.Size = new System.Drawing.Size(584, 37);
            this.panelSupply.TabIndex = 0;
            // 
            // btnRefreshSupply
            // 
            this.btnRefreshSupply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(128)))));
            this.btnRefreshSupply.Location = new System.Drawing.Point(10, 7);
            this.btnRefreshSupply.Name = "btnRefreshSupply";
            this.btnRefreshSupply.Size = new System.Drawing.Size(100, 25);
            this.btnRefreshSupply.TabIndex = 0;
            this.btnRefreshSupply.Text = "Обновить";
            this.btnRefreshSupply.UseVisualStyleBackColor = false;
            this.btnRefreshSupply.Click += new System.EventHandler(this.btnRefreshSupply_Click);
            // 
            // btnCreateSupply
            // 
            this.btnCreateSupply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(128)))));
            this.btnCreateSupply.Location = new System.Drawing.Point(120, 7);
            this.btnCreateSupply.Name = "btnCreateSupply";
            this.btnCreateSupply.Size = new System.Drawing.Size(120, 25);
            this.btnCreateSupply.TabIndex = 1;
            this.btnCreateSupply.Text = "Создать заявку";
            this.btnCreateSupply.UseVisualStyleBackColor = false;
            this.btnCreateSupply.Click += new System.EventHandler(this.btnCreateSupply_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(128)))));
            this.btnExit.Location = new System.Drawing.Point(692, 431);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 25);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnShowDiscounts
            // 
            this.btnShowDiscounts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(128)))));
            this.btnShowDiscounts.Location = new System.Drawing.Point(692, 3);
            this.btnShowDiscounts.Name = "btnShowDiscounts";
            this.btnShowDiscounts.Size = new System.Drawing.Size(80, 25);
            this.btnShowDiscounts.TabIndex = 12;
            this.btnShowDiscounts.Text = "Скидки";
            this.btnShowDiscounts.UseVisualStyleBackColor = false;
            this.btnShowDiscounts.Click += new System.EventHandler(this.btnShowDiscounts_Click);
            // 
            // ManagerMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 465);
            this.Controls.Add(this.btnShowDiscounts);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSuppliers);
            this.Controls.Add(this.btnProductTypes);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnMaterialTypes);
            this.Controls.Add(this.btnMaterials);
            this.Controls.Add(this.btnPartners);
            this.Controls.Add(this.btnProduct);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "ManagerMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Панель менеджера";
            this.tabPageSales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesRequests)).EndInit();
            this.panelSales.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPageSupply.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplyRequests)).EndInit();
            this.panelSupply.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnPartners;
        private System.Windows.Forms.Button btnSuppliers;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnMaterials;
        private System.Windows.Forms.Button btnMaterialTypes;
        private System.Windows.Forms.Button btnProductTypes;
        private System.Windows.Forms.TabPage tabPageSales;
        private System.Windows.Forms.Panel panelSales;
        private System.Windows.Forms.Button btnRefreshSales;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageSupply;
        private System.Windows.Forms.DataGridView dgvSupplyRequests;
        private System.Windows.Forms.Panel panelSupply;
        private System.Windows.Forms.Button btnRefreshSupply;
        private System.Windows.Forms.DataGridView dgvSalesRequests;
        private System.Windows.Forms.Button btnCreateSupply;
        private System.Windows.Forms.Button btnCreateSales;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnShowDiscounts;
    }
}