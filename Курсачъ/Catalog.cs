using System;
using System.Windows.Forms;

namespace Курсачъ
{
    public partial class Catalog : Form
    {

        public Catalog()
        {
            InitializeComponent();
        }

        private void Catalog_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "electronic_GYMDataSet2.Products". При необходимости она может быть перемещена или удалена.
            this.productsTableAdapter.Fill(this.electronic_GYMDataSet2.Products);
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Columns[1].HeaderText = "Название";
            dataGridView1.Columns[2].HeaderText = "Категория";
            dataGridView1.Columns[3].HeaderText = "Подкатегория";
            dataGridView1.Columns[4].HeaderText = "Цена";
            dataGridView1.Columns[5].HeaderText = "Параметр";
            dataGridView1.Columns[6].HeaderText = "Производитель";
            dataGridView1.Columns[7].HeaderText = "Дата производства";
            dataGridView1.Columns[8].HeaderText = "Гарантийный период";
        }

        private void AddRows_Click(object sender, EventArgs e)
        {
            AddRow dlg = new AddRow();
            dlg.Show(this);
        }

        private void DeleteRow_Click(object sender, EventArgs e)
        {
            DeleteRow deleteRow = new DeleteRow();
            deleteRow.Show(this);
        }

        private void UpdateRows_Click(object sender, EventArgs e)
        {
            UpdateRow row = new UpdateRow();
            row.Show(this);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            this.productsTableAdapter.Fill(this.electronic_GYMDataSet2.Products);
        }
        private void Refresh_Click(object sender, EventArgs e)
        {
            MainForm_Activated(sender, e);
        }
    }
}
