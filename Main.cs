using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEST
{
    public partial class Main : Form
    {
        private string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=I:\ISMY\PROJECT_S\JOB_Работа\TEST\Departmens.mdf;Integrated Security=True;Connect Timeout=30";
        public Main()
        {
            InitializeComponent();
        }



        private DataTable Departmens(string conn)
        {
            string qMain = $"SELECT* FROM Department ORDER BY Id";

            SqlDataAdapter sdaJ = new SqlDataAdapter(qMain, conn);
            DataTable dtJ = new DataTable();
            sdaJ.Fill(dtJ);
            return dtJ;
        }


        private DataTable Detail(string conn, string qMain)
        {
            SqlDataAdapter sdaJ = new SqlDataAdapter(qMain, conn);
            DataTable dtJ = new DataTable();
            sdaJ.Fill(dtJ);
            return dtJ;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            comboBx_Departmens.DataSource = Departmens(connString);
            comboBx_Departmens.ValueMember = "ID";
            comboBx_Departmens.DisplayMember = "Name";
            Visible_comboBx_Departmens();
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Visible_comboBx_Departmens()
        {
            DataTable dt_;
            DataTable dt__;
            if (chckBx_AllDepartmens.Checked)
            {
                comboBx_Departmens.Visible = false;

                if (checkBox1.Checked)
                {
                    dt__ = Detail(connString, $"SELECT Должность, Департамент, Сотрудник, Зарплата, id FROM Details WHERE NOT Chief_id = 1");
                }
                else
                {
                    dt__ = Detail(connString, $"SELECT Должность, Департамент, Сотрудник, Зарплата, id FROM Details");
                }

                DgvMain.DataSource = dt__;
                dt_ =  Detail(connString, $"SELECT Должность, Департамент, Сотрудник, Зарплата FROM Details  WHERE Зарплата = (SELECT MAX(Зарплата) FROM Details)");
                lb_Department.Text = $"Департамент {dt_.Rows[0][1]}";
                lb_Chief.Text = $"Должность {dt_.Rows[0][0]}";
                lb_Salary.Text = $"Зарплата {dt_.Rows[0][3]}";
                lb_Employee.Text = $"Сотрудник {dt_.Rows[0][2]}";
                SummSalary(dt__);
            }
            else
            {
                comboBx_Departmens.Visible = true;
                var val =  comboBx_Departmens.SelectedValue;
                if (checkBox1.Checked)
                {
                    dt_ = Detail(connString, $"SELECT* FROM Details WHERE DepID = {val} and not Chief_id =1");
                }
                else
                {
                    dt_ = Detail(connString, $"SELECT* FROM Details WHERE DepID = {val}");
                }
                
                DgvMain.DataSource = dt_;
                SummSalary(dt_);
            }
        }

        private void SummSalary(DataTable dataTable)
        {
            lb_SumSalary.Text =  $"Суммарная зарплата { dataTable.Compute("Sum([Зарплата])", "")}";
        }

        private void chckBx_AllDepartmens_CheckedChanged(object sender, EventArgs e)
        {
            Visible_comboBx_Departmens();
        }

        private void comboBx_Departmens_DropDownClosed(object sender, EventArgs e)
        {
            Visible_comboBx_Departmens();
        }

        private void chckBx_Salary_Chief_CheckedChanged(object sender, EventArgs e)
        {
            if (chckBx_Salary_Chief.Checked)
            {
                DgvMain.DataSource = Detail(connString, $"SELECT Должность, Департамент, Сотрудник, Зарплата, id FROM Details WHERE Chief_id = 1 ORDER BY Зарплата DESC");
            }
            else
            {
                Visible_comboBx_Departmens();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Visible_comboBx_Departmens();
        }
    }
}
