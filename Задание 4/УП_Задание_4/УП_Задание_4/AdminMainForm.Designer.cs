using System.Windows.Forms;
using System;

namespace УП_Задание_4
{
    partial class AdminMainForm
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
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnShowDiscounts = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnPartners = new System.Windows.Forms.Button();
            this.btnSuppliers = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnMaterials = new System.Windows.Forms.Button();
            this.btnMaterialTypes = new System.Windows.Forms.Button();
            this.btnProductTypes = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(5, 51);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(594, 488);
            this.dgvUsers.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnShowDiscounts);
            this.panel1.Controls.Add(this.btnDeleteUser);
            this.panel1.Controls.Add(this.btnEditUser);
            this.panel1.Controls.Add(this.btnAddUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 45);
            this.panel1.TabIndex = 2;
            // 
            // btnShowDiscounts
            // 
            this.btnShowDiscounts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(128)))));
            this.btnShowDiscounts.Location = new System.Drawing.Point(692, 10);
            this.btnShowDiscounts.Name = "btnShowDiscounts";
            this.btnShowDiscounts.Size = new System.Drawing.Size(80, 25);
            this.btnShowDiscounts.TabIndex = 11;
            this.btnShowDiscounts.Text = "Скидки";
            this.btnShowDiscounts.UseVisualStyleBackColor = false;
            this.btnShowDiscounts.Click += new System.EventHandler(this.btnShowDiscounts_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(128)))));
            this.btnDeleteUser.Location = new System.Drawing.Point(215, 10);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(100, 25);
            this.btnDeleteUser.TabIndex = 2;
            this.btnDeleteUser.Text = "Удалить";
            this.btnDeleteUser.UseVisualStyleBackColor = false;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnEditUser
            // 
            this.btnEditUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(128)))));
            this.btnEditUser.Location = new System.Drawing.Point(110, 10);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(100, 25);
            this.btnEditUser.TabIndex = 1;
            this.btnEditUser.Text = "Редактировать";
            this.btnEditUser.UseVisualStyleBackColor = false;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(128)))));
            this.btnAddUser.Location = new System.Drawing.Point(5, 10);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(100, 25);
            this.btnAddUser.TabIndex = 0;
            this.btnAddUser.Text = "Добавить";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(128)))));
            this.btnEmployees.Location = new System.Drawing.Point(622, 51);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(150, 60);
            this.btnEmployees.TabIndex = 4;
            this.btnEmployees.Text = "Таблица Сотрудники";
            this.btnEmployees.UseVisualStyleBackColor = false;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // btnPartners
            // 
            this.btnPartners.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(128)))));
            this.btnPartners.Location = new System.Drawing.Point(622, 117);
            this.btnPartners.Name = "btnPartners";
            this.btnPartners.Size = new System.Drawing.Size(150, 60);
            this.btnPartners.TabIndex = 5;
            this.btnPartners.Text = "Таблица Партнеры";
            this.btnPartners.UseVisualStyleBackColor = false;
            this.btnPartners.Click += new System.EventHandler(this.btnPartners_Click);
            // 
            // btnSuppliers
            // 
            this.btnSuppliers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(128)))));
            this.btnSuppliers.Location = new System.Drawing.Point(622, 183);
            this.btnSuppliers.Name = "btnSuppliers";
            this.btnSuppliers.Size = new System.Drawing.Size(150, 60);
            this.btnSuppliers.TabIndex = 6;
            this.btnSuppliers.Text = "Таблица Поставщики";
            this.btnSuppliers.UseVisualStyleBackColor = false;
            this.btnSuppliers.Click += new System.EventHandler(this.btnSuppliers_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(128)))));
            this.btnProduct.Location = new System.Drawing.Point(622, 249);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(150, 60);
            this.btnProduct.TabIndex = 7;
            this.btnProduct.Text = "Таблица Продукция";
            this.btnProduct.UseVisualStyleBackColor = false;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnMaterials
            // 
            this.btnMaterials.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(128)))));
            this.btnMaterials.Location = new System.Drawing.Point(622, 381);
            this.btnMaterials.Name = "btnMaterials";
            this.btnMaterials.Size = new System.Drawing.Size(150, 60);
            this.btnMaterials.TabIndex = 8;
            this.btnMaterials.Text = "Таблица Материалы";
            this.btnMaterials.UseVisualStyleBackColor = false;
            this.btnMaterials.Click += new System.EventHandler(this.btnMaterials_Click);
            // 
            // btnMaterialTypes
            // 
            this.btnMaterialTypes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(128)))));
            this.btnMaterialTypes.Location = new System.Drawing.Point(622, 447);
            this.btnMaterialTypes.Name = "btnMaterialTypes";
            this.btnMaterialTypes.Size = new System.Drawing.Size(150, 60);
            this.btnMaterialTypes.TabIndex = 9;
            this.btnMaterialTypes.Text = "Таблица ТипыМатериалов";
            this.btnMaterialTypes.UseVisualStyleBackColor = false;
            this.btnMaterialTypes.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnProductTypes
            // 
            this.btnProductTypes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(128)))));
            this.btnProductTypes.Location = new System.Drawing.Point(622, 315);
            this.btnProductTypes.Name = "btnProductTypes";
            this.btnProductTypes.Size = new System.Drawing.Size(150, 60);
            this.btnProductTypes.TabIndex = 10;
            this.btnProductTypes.Text = "Таблица ТипыПродукции";
            this.btnProductTypes.UseVisualStyleBackColor = false;
            this.btnProductTypes.Click += new System.EventHandler(this.btnProductTypes_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(128)))));
            this.btnExit.Location = new System.Drawing.Point(692, 513);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 25);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // AdminMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 547);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnProductTypes);
            this.Controls.Add(this.btnMaterialTypes);
            this.Controls.Add(this.btnMaterials);
            this.Controls.Add(this.btnProduct);
            this.Controls.Add(this.btnSuppliers);
            this.Controls.Add(this.btnPartners);
            this.Controls.Add(this.btnEmployees);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "AdminMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Панель администратора";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.Button btnDeleteUser;
        private Button btnEmployees;
        private Button btnPartners;
        private Button btnSuppliers;
        private Button btnProduct;
        private Button btnMaterials;
        private Button btnMaterialTypes;
        private Button btnProductTypes;
        private System.Windows.Forms.Button btnExit;
        private Button btnShowDiscounts;
    }
}