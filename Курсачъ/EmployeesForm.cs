using System;
using System.Windows.Forms;

namespace Курсачъ
{
    public partial class EmployeesForm : Form
    {
        public EmployeesForm()
        {
            InitializeComponent();
            dataGridView1.Columns[0].HeaderText = "Id";
            dataGridView1.Columns[1].HeaderText = "Ф.И.О.";
            dataGridView1.Columns[2].HeaderText = "Стаж";
            dataGridView1.Columns[3].HeaderText = "Зарплата";
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
