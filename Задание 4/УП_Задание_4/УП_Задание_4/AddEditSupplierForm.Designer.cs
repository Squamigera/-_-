namespace УП_Задание_4
{
    partial class AddEditSupplierForm
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblINN = new System.Windows.Forms.Label();
            this.txtINN = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.lblContacts = new System.Windows.Forms.Label();
            this.txtContacts = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 20);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(83, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Наименование:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(130, 17);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(220, 23);
            this.txtName.TabIndex = 1;
            // 
            // lblINN
            // 
            this.lblINN.AutoSize = true;
            this.lblINN.Location = new System.Drawing.Point(12, 50);
            this.lblINN.Name = "lblINN";
            this.lblINN.Size = new System.Drawing.Size(34, 15);
            this.lblINN.TabIndex = 2;
            this.lblINN.Text = "ИНН:";
            // 
            // txtINN
            // 
            this.txtINN.Location = new System.Drawing.Point(130, 47);
            this.txtINN.Name = "txtINN";
            this.txtINN.Size = new System.Drawing.Size(220, 23);
            this.txtINN.TabIndex = 3;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(12, 80);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(103, 15);
            this.lblType.TabIndex = 4;
            this.lblType.Text = "Тип поставщика:";
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(130, 77);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(220, 23);
            this.txtType.TabIndex = 5;
            // 
            // lblContacts
            // 
            this.lblContacts.AutoSize = true;
            this.lblContacts.Location = new System.Drawing.Point(12, 110);
            this.lblContacts.Name = "lblContacts";
            this.lblContacts.Size = new System.Drawing.Size(115, 15);
            this.lblContacts.TabIndex = 6;
            this.lblContacts.Text = "Контактные данные:";
            // 
            // txtContacts
            // 
            this.txtContacts.Location = new System.Drawing.Point(130, 107);
            this.txtContacts.Multiline = true;
            this.txtContacts.Name = "txtContacts";
            this.txtContacts.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtContacts.Size = new System.Drawing.Size(220, 60);
            this.txtContacts.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(130, 180);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 30);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(260, 180);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 30);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddEditSupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 225);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtContacts);
            this.Controls.Add(this.lblContacts);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.txtINN);
            this.Controls.Add(this.lblINN);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEditSupplierForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление поставщика";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblINN;
        private System.Windows.Forms.TextBox txtINN;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label lblContacts;
        private System.Windows.Forms.TextBox txtContacts;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}