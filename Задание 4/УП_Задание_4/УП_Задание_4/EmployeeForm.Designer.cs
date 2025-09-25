using System.Drawing;
using System.Windows.Forms;
using System;

namespace УП_Задание_4
{
    partial class EmployeeForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();

            // dgvEmployees
            dgvEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmployees.MultiSelect = false;
            this.dgvEmployees.AllowUserToAddRows = false;
            this.dgvEmployees.AllowUserToDeleteRows = false;
            this.dgvEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Location = new System.Drawing.Point(12, 60);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.ReadOnly = true;
            this.dgvEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployees.Size = new System.Drawing.Size(760, 380);

            // panelTop
            this.panelTop.Controls.Add(this.btnExit);
            this.panelTop.Controls.Add(this.btnRefresh);
            this.panelTop.Controls.Add(this.btnDelete);
            this.panelTop.Controls.Add(this.btnEdit);
            this.panelTop.Controls.Add(this.btnAdd);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(784, 50);

            // Кнопки
            this.btnAdd.Location = new System.Drawing.Point(12, 12);
            this.btnAdd.Text = "Добавить";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            this.btnEdit.Location = new System.Drawing.Point(92, 12);
            this.btnEdit.Text = "Редактировать";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);

            this.btnDelete.Location = new System.Drawing.Point(172, 12);
            this.btnDelete.Text = "Удалить";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            this.btnRefresh.Location = new System.Drawing.Point(252, 12);
            this.btnRefresh.Text = "Обновить";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            this.btnExit.Location = new System.Drawing.Point(690, 12);
            this.btnExit.Text = "Закрыть";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);

            // EmployeeForm
            this.ClientSize = new System.Drawing.Size(784, 450);
            this.Controls.Add(this.dgvEmployees);
            this.Controls.Add(this.panelTop);
            this.Text = "Сотрудники";

            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvEmployees;
        private Panel panelTop;
        private Button btnRefresh;
        private Button btnExit;
        internal System.Windows.Forms.Button btnAdd;
        internal System.Windows.Forms.Button btnEdit;
        internal System.Windows.Forms.Button btnDelete;
    }
}