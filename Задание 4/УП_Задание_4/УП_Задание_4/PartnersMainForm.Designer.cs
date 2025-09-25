using System.Drawing;
using System.Windows.Forms;
using System;

namespace УП_Задание_4
{
    partial class PartnersMainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageRequests = new System.Windows.Forms.TabPage();
            this.dgvMyRequests = new System.Windows.Forms.DataGridView();
            this.panelRequests = new System.Windows.Forms.Panel();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.btnRefreshRequests = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.tabPageCatalogs = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panelProducts = new System.Windows.Forms.Panel();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.btnRefreshProducts = new System.Windows.Forms.Button();
            this.panelProductTypes = new System.Windows.Forms.Panel();
            this.dgvProductTypes = new System.Windows.Forms.DataGridView();
            this.btnRefreshProductTypes = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageRequests.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyRequests)).BeginInit();
            this.panelRequests.SuspendLayout();
            this.tabPageCatalogs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panelProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.panelProductTypes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductTypes)).BeginInit();
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
            this.tabPageRequests.Text = "Мои заявки на покупку";
            this.tabPageRequests.UseVisualStyleBackColor = true;
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
            this.panelRequests.Controls.Add(this.lblDiscount);
            this.panelRequests.Controls.Add(this.btnRefreshRequests);
            this.panelRequests.Controls.Add(this.btnExit);
            this.panelRequests.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRequests.Location = new System.Drawing.Point(3, 3);
            this.panelRequests.Name = "panelRequests";
            this.panelRequests.Size = new System.Drawing.Size(970, 40);
            this.panelRequests.TabIndex = 0;
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(385, 14);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(59, 13);
            this.lblDiscount.TabIndex = 1;
            this.lblDiscount.Text = "lblDiscount";
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
            this.tabPageCatalogs.UseVisualStyleBackColor = true;
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
            this.splitContainer1.Panel1.Controls.Add(this.panelProducts);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panelProductTypes);
            this.splitContainer1.Size = new System.Drawing.Size(970, 529);
            this.splitContainer1.SplitterDistance = 260;
            this.splitContainer1.TabIndex = 0;
            // 
            // panelProducts
            // 
            this.panelProducts.Controls.Add(this.dgvProducts);
            this.panelProducts.Controls.Add(this.btnRefreshProducts);
            this.panelProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProducts.Location = new System.Drawing.Point(0, 0);
            this.panelProducts.Name = "panelProducts";
            this.panelProducts.Size = new System.Drawing.Size(970, 260);
            this.panelProducts.TabIndex = 0;
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProducts.Location = new System.Drawing.Point(0, 30);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.Size = new System.Drawing.Size(970, 230);
            this.dgvProducts.TabIndex = 1;
            // 
            // btnRefreshProducts
            // 
            this.btnRefreshProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(128)))));
            this.btnRefreshProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRefreshProducts.Location = new System.Drawing.Point(0, 0);
            this.btnRefreshProducts.Name = "btnRefreshProducts";
            this.btnRefreshProducts.Size = new System.Drawing.Size(970, 30);
            this.btnRefreshProducts.TabIndex = 0;
            this.btnRefreshProducts.Text = "Обновить продукцию";
            this.btnRefreshProducts.UseVisualStyleBackColor = false;
            this.btnRefreshProducts.Click += new System.EventHandler(this.btnRefreshProducts_Click);
            // 
            // panelProductTypes
            // 
            this.panelProductTypes.Controls.Add(this.dgvProductTypes);
            this.panelProductTypes.Controls.Add(this.btnRefreshProductTypes);
            this.panelProductTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProductTypes.Location = new System.Drawing.Point(0, 0);
            this.panelProductTypes.Name = "panelProductTypes";
            this.panelProductTypes.Size = new System.Drawing.Size(970, 265);
            this.panelProductTypes.TabIndex = 0;
            // 
            // dgvProductTypes
            // 
            this.dgvProductTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProductTypes.Location = new System.Drawing.Point(0, 30);
            this.dgvProductTypes.Name = "dgvProductTypes";
            this.dgvProductTypes.ReadOnly = true;
            this.dgvProductTypes.Size = new System.Drawing.Size(970, 235);
            this.dgvProductTypes.TabIndex = 1;
            // 
            // btnRefreshProductTypes
            // 
            this.btnRefreshProductTypes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(128)))));
            this.btnRefreshProductTypes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRefreshProductTypes.Location = new System.Drawing.Point(0, 0);
            this.btnRefreshProductTypes.Name = "btnRefreshProductTypes";
            this.btnRefreshProductTypes.Size = new System.Drawing.Size(970, 30);
            this.btnRefreshProductTypes.TabIndex = 0;
            this.btnRefreshProductTypes.Text = "Обновить типы продукции";
            this.btnRefreshProductTypes.UseVisualStyleBackColor = false;
            this.btnRefreshProductTypes.Click += new System.EventHandler(this.btnRefreshProductTypes_Click);
            // 
            // PartnersMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.tabControl1);
            this.Name = "PartnersMainForm";
            this.Text = "Личный кабинет партнёра";
            this.tabControl1.ResumeLayout(false);
            this.tabPageRequests.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyRequests)).EndInit();
            this.panelRequests.ResumeLayout(false);
            this.panelRequests.PerformLayout();
            this.tabPageCatalogs.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panelProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.panelProductTypes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductTypes)).EndInit();
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
        private System.Windows.Forms.Panel panelProducts;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Button btnRefreshProducts;
        private System.Windows.Forms.Panel panelProductTypes;
        private System.Windows.Forms.DataGridView dgvProductTypes;
        private System.Windows.Forms.Button btnRefreshProductTypes;
        private Label lblDiscount;
    }
}