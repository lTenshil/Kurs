using System;
using System.Windows.Forms;

namespace Курсачъ
{
    public partial class DeleteRow : Form
    {
        public static int ID;
        public DeleteRow()
        {
            InitializeComponent();
        }

        
        private void DeleteRow_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "electronic_GYMDataSet3.Products". При необходимости она может быть перемещена или удалена.
            this.productsTableAdapter.Fill(this.electronic_GYMDataSet3.Products);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MyDBContext context = new MyDBContext())
            {
                Product product = context.Products.Find(ID);
                context.Products.Remove(product);
                context.SaveChanges();
                MessageBox.Show("Строка удалена!");
                Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ID = Convert.ToInt32(textBox1.Text);
        }
    }
}
