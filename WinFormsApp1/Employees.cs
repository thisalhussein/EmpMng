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
    public partial class Employees : Form
    {
        Functions Con;
        public Employees()
        {
            InitializeComponent();
            Con = new Functions();
            ShowEmp();
        }
        private void ShowEmp()
        {
            string Query = "Select * from EmployeeTbl";
            EmployeeList.DataSource = Con.GetData(Query);
        }
        private void Employees_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
