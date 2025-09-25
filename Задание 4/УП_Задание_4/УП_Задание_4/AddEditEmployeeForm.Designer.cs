using System.Windows.Forms;

namespace УП_Задание_4
{
    partial class AddEditEmployeeForm
    {
        private void InitializeComponent()
        {
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.lblPassport = new System.Windows.Forms.Label();
            this.txtPassport = new System.Windows.Forms.TextBox();
            this.lblBank = new System.Windows.Forms.Label();
            this.txtBank = new System.Windows.Forms.TextBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFullName
            // 
            this.lblFullName.Location = new System.Drawing.Point(12, 20);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(100, 23);
            this.lblFullName.TabIndex = 0;
            this.lblFullName.Text = "ФИО:";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(140, 17);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(250, 20);
            this.txtFullName.TabIndex = 1;
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.Location = new System.Drawing.Point(12, 50);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(100, 23);
            this.lblBirthDate.TabIndex = 2;
            this.lblBirthDate.Text = "Дата рождения:";
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthDate.Location = new System.Drawing.Point(140, 47);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(200, 20);
            this.dtpBirthDate.TabIndex = 3;
            // 
            // lblPassport
            // 
            this.lblPassport.Location = new System.Drawing.Point(12, 80);
            this.lblPassport.Name = "lblPassport";
            this.lblPassport.Size = new System.Drawing.Size(122, 23);
            this.lblPassport.TabIndex = 4;
            this.lblPassport.Text = "Паспортные данные:";
            // 
            // txtPassport
            // 
            this.txtPassport.Location = new System.Drawing.Point(140, 77);
            this.txtPassport.Name = "txtPassport";
            this.txtPassport.Size = new System.Drawing.Size(250, 20);
            this.txtPassport.TabIndex = 5;
            // 
            // lblBank
            // 
            this.lblBank.Location = new System.Drawing.Point(12, 110);
            this.lblBank.Name = "lblBank";
            this.lblBank.Size = new System.Drawing.Size(100, 23);
            this.lblBank.TabIndex = 6;
            this.lblBank.Text = "Банк. реквизиты:";
            // 
            // txtBank
            // 
            this.txtBank.Location = new System.Drawing.Point(140, 107);
            this.txtBank.Name = "txtBank";
            this.txtBank.Size = new System.Drawing.Size(250, 20);
            this.txtBank.TabIndex = 7;
            // 
            // lblPosition
            // 
            this.lblPosition.Location = new System.Drawing.Point(12, 140);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(100, 23);
            this.lblPosition.TabIndex = 8;
            this.lblPosition.Text = "Должность:";
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(140, 137);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(250, 20);
            this.txtPosition.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(140, 180);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 30);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Сохранить";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(300, 180);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 30);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Отмена";
            // 
            // AddEditEmployeeForm
            // 
            this.ClientSize = new System.Drawing.Size(410, 220);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.lblBirthDate);
            this.Controls.Add(this.dtpBirthDate);
            this.Controls.Add(this.lblPassport);
            this.Controls.Add(this.txtPassport);
            this.Controls.Add(this.lblBank);
            this.Controls.Add(this.txtBank);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEditEmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление сотрудника";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Label lblFullName;
        private TextBox txtFullName;
        private Label lblBirthDate;
        private DateTimePicker dtpBirthDate;
        private Label lblPassport;
        private TextBox txtPassport;
        private Label lblBank;
        private TextBox txtBank;
        private Label lblPosition;
        private TextBox txtPosition;
        private Button btnSave;
        private Button btnCancel;
    }
}