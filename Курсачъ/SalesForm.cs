using System;
using System.Windows.Forms;

namespace Курсачъ
{
    public partial class SalesForm : Form
    {
        public SalesForm()
        {
            InitializeComponent();
            dataGridView1.Columns[0].HeaderText = "Id";
            dataGridView1.Columns[1].HeaderText = "Id товара";
            dataGridView1.Columns[2].HeaderText = "Id сотрудника";
            dataGridView1.Columns[3].HeaderText = "Количество";
            dataGridView1.Columns[4].HeaderText = "Дата заказа";
            dataGridView1.Columns[5].HeaderText = "Стоимость";

        }

        private void SalesForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "electronic_GYMDataSet5.Sales". При необходимости она может быть перемещена или удалена.
            this.salesTableAdapter2.Fill(this.electronic_GYMDataSet5.Sales);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "electronic_GYMDataSet4.Sales". При необходимости она может быть перемещена или удалена.
            this.salesTableAdapter1.Fill(this.electronic_GYMDataSet4.Sales);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "electronic_GYMDataSet3.Sales". При необходимости она может быть перемещена или удалена.
            this.salesTableAdapter.Fill(this.electronic_GYMDataSet3.Sales);

        }

        private void AddRows_Click(object sender, EventArgs e)
        {
            using (MyDBContext context = new MyDBContext())
            {
                AddSales addSales = new AddSales();
                addSales.Show(this);
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            SalesForm_Load(sender, e);
        }

        private void DeleteProduct_Click(object sender, EventArgs e)
        {
            DeleteSale deleteSale = new DeleteSale();
            deleteSale.Show(this);
        }
    }
}
