
namespace TEST
{
    partial class Main
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
            this.grpBox_Departmens = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lb_SumSalary = new System.Windows.Forms.Label();
            this.chckBx_AllDepartmens = new System.Windows.Forms.CheckBox();
            this.comboBx_Departmens = new System.Windows.Forms.ComboBox();
            this.DgvMain = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_Employee = new System.Windows.Forms.Label();
            this.lb_Salary = new System.Windows.Forms.Label();
            this.lb_Chief = new System.Windows.Forms.Label();
            this.lb_Department = new System.Windows.Forms.Label();
            this.chckBx_Salary_Chief = new System.Windows.Forms.CheckBox();
            this.btn_LoadDB = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.grpBox_Departmens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMain)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBox_Departmens
            // 
            this.grpBox_Departmens.Controls.Add(this.checkBox1);
            this.grpBox_Departmens.Controls.Add(this.lb_SumSalary);
            this.grpBox_Departmens.Controls.Add(this.chckBx_AllDepartmens);
            this.grpBox_Departmens.Controls.Add(this.comboBx_Departmens);
            this.grpBox_Departmens.Location = new System.Drawing.Point(554, 12);
            this.grpBox_Departmens.Name = "grpBox_Departmens";
            this.grpBox_Departmens.Size = new System.Drawing.Size(319, 128);
            this.grpBox_Departmens.TabIndex = 1;
            this.grpBox_Departmens.TabStop = false;
            this.grpBox_Departmens.Text = "Департаменты";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 102);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(124, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Без руководителей";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // lb_SumSalary
            // 
            this.lb_SumSalary.AutoSize = true;
            this.lb_SumSalary.Location = new System.Drawing.Point(4, 81);
            this.lb_SumSalary.Name = "lb_SumSalary";
            this.lb_SumSalary.Size = new System.Drawing.Size(115, 13);
            this.lb_SumSalary.TabIndex = 2;
            this.lb_SumSalary.Text = "Суммарная зарплата";
            // 
            // chckBx_AllDepartmens
            // 
            this.chckBx_AllDepartmens.AutoSize = true;
            this.chckBx_AllDepartmens.Checked = true;
            this.chckBx_AllDepartmens.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chckBx_AllDepartmens.Location = new System.Drawing.Point(7, 20);
            this.chckBx_AllDepartmens.Name = "chckBx_AllDepartmens";
            this.chckBx_AllDepartmens.Size = new System.Drawing.Size(45, 17);
            this.chckBx_AllDepartmens.TabIndex = 1;
            this.chckBx_AllDepartmens.Text = "Все";
            this.chckBx_AllDepartmens.UseVisualStyleBackColor = true;
            this.chckBx_AllDepartmens.CheckedChanged += new System.EventHandler(this.chckBx_AllDepartmens_CheckedChanged);
            // 
            // comboBx_Departmens
            // 
            this.comboBx_Departmens.FormattingEnabled = true;
            this.comboBx_Departmens.Location = new System.Drawing.Point(6, 43);
            this.comboBx_Departmens.Name = "comboBx_Departmens";
            this.comboBx_Departmens.Size = new System.Drawing.Size(307, 21);
            this.comboBx_Departmens.TabIndex = 0;
            this.comboBx_Departmens.DropDownClosed += new System.EventHandler(this.comboBx_Departmens_DropDownClosed);
            // 
            // DgvMain
            // 
            this.DgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMain.Location = new System.Drawing.Point(12, 12);
            this.DgvMain.Name = "DgvMain";
            this.DgvMain.Size = new System.Drawing.Size(521, 288);
            this.DgvMain.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_Employee);
            this.groupBox1.Controls.Add(this.lb_Salary);
            this.groupBox1.Controls.Add(this.lb_Chief);
            this.groupBox1.Controls.Add(this.lb_Department);
            this.groupBox1.Location = new System.Drawing.Point(554, 146);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 131);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Максимальная зарплата";
            // 
            // lb_Employee
            // 
            this.lb_Employee.AutoSize = true;
            this.lb_Employee.Location = new System.Drawing.Point(6, 97);
            this.lb_Employee.Name = "lb_Employee";
            this.lb_Employee.Size = new System.Drawing.Size(60, 13);
            this.lb_Employee.TabIndex = 4;
            this.lb_Employee.Text = "Сотрудник";
            // 
            // lb_Salary
            // 
            this.lb_Salary.AutoSize = true;
            this.lb_Salary.Location = new System.Drawing.Point(6, 71);
            this.lb_Salary.Name = "lb_Salary";
            this.lb_Salary.Size = new System.Drawing.Size(55, 13);
            this.lb_Salary.TabIndex = 3;
            this.lb_Salary.Text = "Зарплата";
            // 
            // lb_Chief
            // 
            this.lb_Chief.AutoSize = true;
            this.lb_Chief.Location = new System.Drawing.Point(6, 46);
            this.lb_Chief.Name = "lb_Chief";
            this.lb_Chief.Size = new System.Drawing.Size(65, 13);
            this.lb_Chief.TabIndex = 2;
            this.lb_Chief.Text = "Должность";
            // 
            // lb_Department
            // 
            this.lb_Department.AutoSize = true;
            this.lb_Department.Location = new System.Drawing.Point(6, 22);
            this.lb_Department.Name = "lb_Department";
            this.lb_Department.Size = new System.Drawing.Size(76, 13);
            this.lb_Department.TabIndex = 1;
            this.lb_Department.Text = "Департамент";
            // 
            // chckBx_Salary_Chief
            // 
            this.chckBx_Salary_Chief.AutoSize = true;
            this.chckBx_Salary_Chief.Location = new System.Drawing.Point(554, 283);
            this.chckBx_Salary_Chief.Name = "chckBx_Salary_Chief";
            this.chckBx_Salary_Chief.Size = new System.Drawing.Size(205, 17);
            this.chckBx_Salary_Chief.TabIndex = 4;
            this.chckBx_Salary_Chief.Text = "Зарплата директоров по убыванию";
            this.chckBx_Salary_Chief.UseVisualStyleBackColor = true;
            this.chckBx_Salary_Chief.CheckedChanged += new System.EventHandler(this.chckBx_Salary_Chief_CheckedChanged);
            // 
            // btn_LoadDB
            // 
            this.btn_LoadDB.Location = new System.Drawing.Point(12, 323);
            this.btn_LoadDB.Name = "btn_LoadDB";
            this.btn_LoadDB.Size = new System.Drawing.Size(88, 31);
            this.btn_LoadDB.TabIndex = 5;
            this.btn_LoadDB.Text = "Загрузить БД";
            this.btn_LoadDB.UseVisualStyleBackColor = true;
            this.btn_LoadDB.Click += new System.EventHandler(this.btn_LoadDB_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(140, 329);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(727, 20);
            this.textBox1.TabIndex = 6;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 377);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_LoadDB);
            this.Controls.Add(this.chckBx_Salary_Chief);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DgvMain);
            this.Controls.Add(this.grpBox_Departmens);
            this.Name = "Main";
            this.Text = "TEST";            
            this.grpBox_Departmens.ResumeLayout(false);
            this.grpBox_Departmens.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMain)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grpBox_Departmens;
        private System.Windows.Forms.ComboBox comboBx_Departmens;
        private System.Windows.Forms.CheckBox chckBx_AllDepartmens;
        private System.Windows.Forms.DataGridView DgvMain;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_Department;
        private System.Windows.Forms.Label lb_Salary;
        private System.Windows.Forms.Label lb_Chief;
        private System.Windows.Forms.Label lb_Employee;
        private System.Windows.Forms.CheckBox chckBx_Salary_Chief;
        private System.Windows.Forms.Label lb_SumSalary;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btn_LoadDB;
        private System.Windows.Forms.TextBox textBox1;
    }
}

