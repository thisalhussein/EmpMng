using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{

    public partial class Salary : Form
    {
        Functions Con;
        public Salary()
        {
            InitializeComponent();
            Con = new Functions();
            ShowSalary();
            GetEmployee()
        }
        private void ShowSalary()
        {

            try
            {
                string Query = "Select * from EmployeeTbl";
                EmployeeList.DataSource = Con.GetData(Query);
            }
            catch (Exception)
            {
                throw;
            }

        }
        private void SalaryList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
