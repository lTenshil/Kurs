using System;
using System.Windows.Forms;

namespace Курсачъ
{
    public partial class EmployeesForm : Form
    {
        public EmployeesForm()
        {
            InitializeComponent();
        }

        private void EmployeesForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "electronic_GYMDataSet2.Employees". При необходимости она может быть перемещена или удалена.
            this.employeesTableAdapter.Fill(this.electronic_GYMDataSet2.Employees);

        }

        private void AddRows_Click(object sender, EventArgs e)
        {
            AddEmployee addEmployee = new AddEmployee();
            addEmployee.Show(this);
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            EmployeesForm_Load(sender, e);
        }

        private void DeleteProduct_Click(object sender, EventArgs e)
        {
            DeleteEmployee deleteEmployee = new DeleteEmployee();
            deleteEmployee.Show(this);
        }
    }
}
