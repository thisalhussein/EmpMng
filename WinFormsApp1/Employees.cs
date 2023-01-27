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
            ShowDepartments();
        }
        private void ShowDepartments()
        {
            string Query = "Select * from DepartmentTbl";
            DepList.DataSource = Con.GetData(Query);
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
