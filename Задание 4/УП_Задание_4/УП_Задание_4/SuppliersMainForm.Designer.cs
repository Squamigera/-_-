namespace УП_Задание_4
{
    partial class SuppliersMainForm
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageRequests = new System.Windows.Forms.TabPage();
            this.dgvMyRequests = new System.Windows.Forms.DataGridView();
            this.panelRequests = new System.Windows.Forms.Panel();
            this.btnRefreshRequests = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.tabPageCatalogs = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panelMaterials = new System.Windows.Forms.Panel();
            this.dgvMaterials = new System.Windows.Forms.DataGridView();
            this.btnRefreshMaterials = new System.Windows.Forms.Button();
            this.panelMaterialTypes = new System.Windows.Forms.Panel();
            this.dgvMaterialTypes = new System.Windows.Forms.DataGridView();
            this.btnRefreshMaterialTypes = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageRequests.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyRequests)).BeginInit();
            this.panelRequests.SuspendLayout();
            this.tabPageCatalogs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panelMaterials.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterials)).BeginInit();
            this.panelMaterialTypes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterialTypes)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageRequests);
            this.tabControl1.Controls.Add(this.tabPageCatalogs);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(984, 561);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageRequests
            // 
            this.tabPageRequests.Controls.Add(this.dgvMyRequests);
            this.tabPageRequests.Controls.Add(this.panelRequests);
            this.tabPageRequests.Location = new System.Drawing.Point(4, 22);
            this.tabPageRequests.Name = "tabPageRequests";
            this.tabPageRequests.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRequests.Size = new System.Drawing.Size(976, 535);
            this.tabPageRequests.TabIndex = 0;
            this.tabPageRequests.Text = "Мои заявки на поставку";
            // 
            // dgvMyRequests
            // 
            this.dgvMyRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMyRequests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMyRequests.Location = new System.Drawing.Point(3, 43);
            this.dgvMyRequests.Name = "dgvMyRequests";
            this.dgvMyRequests.ReadOnly = true;
            this.dgvMyRequests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMyRequests.Size = new System.Drawing.Size(970, 489);
            this.dgvMyRequests.TabIndex = 1;
            // 
            // panelRequests
            // 
            this.panelRequests.Controls.Add(this.btnRefreshRequests);
            this.panelRequests.Controls.Add(this.btnExit);
            this.panelRequests.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRequests.Location = new System.Drawing.Point(3, 3);
            this.panelRequests.Name = "panelRequests";
            this.panelRequests.Size = new System.Drawing.Size(970, 40);
            this.panelRequests.TabIndex = 0;
            // 
            // btnRefreshRequests
            // 
            this.btnRefreshRequests.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(128)))));
            this.btnRefreshRequests.Location = new System.Drawing.Point(10, 8);
            this.btnRefreshRequests.Name = "btnRefreshRequests";
            this.btnRefreshRequests.Size = new System.Drawing.Size(100, 25);
            this.btnRefreshRequests.TabIndex = 0;
            this.btnRefreshRequests.Text = "Обновить";
            this.btnRefreshRequests.UseVisualStyleBackColor = false;
            this.btnRefreshRequests.Click += new System.EventHandler(this.btnRefreshRequests_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(128)))));
            this.btnExit.Location = new System.Drawing.Point(870, 8);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 25);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tabPageCatalogs
            // 
            this.tabPageCatalogs.Controls.Add(this.splitContainer1);
            this.tabPageCatalogs.Location = new System.Drawing.Point(4, 22);
            this.tabPageCatalogs.Name = "tabPageCatalogs";
            this.tabPageCatalogs.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCatalogs.Size = new System.Drawing.Size(976, 535);
            this.tabPageCatalogs.TabIndex = 1;
            this.tabPageCatalogs.Text = "Справочники";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panelMaterials);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panelMaterialTypes);
            this.splitContainer1.Size = new System.Drawing.Size(970, 529);
            this.splitContainer1.SplitterDistance = 260;
            this.splitContainer1.TabIndex = 0;
            // 
            // panelMaterials
            // 
            this.panelMaterials.Controls.Add(this.dgvMaterials);
            this.panelMaterials.Controls.Add(this.btnRefreshMaterials);
            this.panelMaterials.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMaterials.Location = new System.Drawing.Point(0, 0);
            this.panelMaterials.Name = "panelMaterials";
            this.panelMaterials.Size = new System.Drawing.Size(970, 260);
            this.panelMaterials.TabIndex = 0;
            // 
            // dgvMaterials
            // 
            this.dgvMaterials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterials.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMaterials.Location = new System.Drawing.Point(0, 30);
            this.dgvMaterials.Name = "dgvMaterials";
            this.dgvMaterials.ReadOnly = true;
            this.dgvMaterials.Size = new System.Drawing.Size(970, 230);
            this.dgvMaterials.TabIndex = 1;
            // 
            // btnRefreshMaterials
            // 
            this.btnRefreshMaterials.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(128)))));
            this.btnRefreshMaterials.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRefreshMaterials.Location = new System.Drawing.Point(0, 0);
            this.btnRefreshMaterials.Name = "btnRefreshMaterials";
            this.btnRefreshMaterials.Size = new System.Drawing.Size(970, 30);
            this.btnRefreshMaterials.TabIndex = 0;
            this.btnRefreshMaterials.Text = "Обновить материалы";
            this.btnRefreshMaterials.UseVisualStyleBackColor = false;
            this.btnRefreshMaterials.Click += new System.EventHandler(this.btnRefreshMaterials_Click);
            // 
            // panelMaterialTypes
            // 
            this.panelMaterialTypes.Controls.Add(this.dgvMaterialTypes);
            this.panelMaterialTypes.Controls.Add(this.btnRefreshMaterialTypes);
            this.panelMaterialTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMaterialTypes.Location = new System.Drawing.Point(0, 0);
            this.panelMaterialTypes.Name = "panelMaterialTypes";
            this.panelMaterialTypes.Size = new System.Drawing.Size(970, 265);
            this.panelMaterialTypes.TabIndex = 0;
            // 
            // dgvMaterialTypes
            // 
            this.dgvMaterialTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterialTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMaterialTypes.Location = new System.Drawing.Point(0, 30);
            this.dgvMaterialTypes.Name = "dgvMaterialTypes";
            this.dgvMaterialTypes.ReadOnly = true;
            this.dgvMaterialTypes.Size = new System.Drawing.Size(970, 235);
            this.dgvMaterialTypes.TabIndex = 1;
            // 
            // btnRefreshMaterialTypes
            // 
            this.btnRefreshMaterialTypes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(128)))));
            this.btnRefreshMaterialTypes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRefreshMaterialTypes.Location = new System.Drawing.Point(0, 0);
            this.btnRefreshMaterialTypes.Name = "btnRefreshMaterialTypes";
            this.btnRefreshMaterialTypes.Size = new System.Drawing.Size(970, 30);
            this.btnRefreshMaterialTypes.TabIndex = 0;
            this.btnRefreshMaterialTypes.Text = "Обновить типы материалов";
            this.btnRefreshMaterialTypes.UseVisualStyleBackColor = false;
            this.btnRefreshMaterialTypes.Click += new System.EventHandler(this.btnRefreshMaterialTypes_Click);
            // 
            // SuppliersMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.tabControl1);
            this.Name = "SuppliersMainForm";
            this.Text = "Личный кабинет поставщика";
            this.tabControl1.ResumeLayout(false);
            this.tabPageRequests.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyRequests)).EndInit();
            this.panelRequests.ResumeLayout(false);
            this.tabPageCatalogs.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panelMaterials.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterials)).EndInit();
            this.panelMaterialTypes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterialTypes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageRequests;
        private System.Windows.Forms.DataGridView dgvMyRequests;
        private System.Windows.Forms.Panel panelRequests;
        private System.Windows.Forms.Button btnRefreshRequests;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TabPage tabPageCatalogs;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panelMaterials;
        private System.Windows.Forms.DataGridView dgvMaterials;
        private System.Windows.Forms.Button btnRefreshMaterials;
        private System.Windows.Forms.Panel panelMaterialTypes;
        private System.Windows.Forms.DataGridView dgvMaterialTypes;
        private System.Windows.Forms.Button btnRefreshMaterialTypes;
    }
}