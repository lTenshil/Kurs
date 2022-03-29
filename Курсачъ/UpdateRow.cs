using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Курсачъ
{
    public partial class UpdateRow : Form
    {

        public static List<Product> products = new List<Product>();
        public static Product product = new Product();
        public UpdateRow()
        {
            InitializeComponent();
        }

        private void UpdateRow_Load(object sender, System.EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "electronic_GYMDataSet.Products". При необходимости она может быть перемещена или удалена.
            this.productsTableAdapter.Fill(this.electronic_GYMDataSet.Products);

        }



        private void SaveChangesButton_Click(object sender, EventArgs e)
        {
            using (MyDBContext context = new MyDBContext())
            {
                var TextId = Convert.ToInt32(textBox1.Text);
                product.Id = TextId;
                product.Name = textBox2.Text;
                product.Category = textBox3.Text;
                product.SubCategory = textBox4.Text;
                product.Price = Convert.ToDecimal(textBox5.Text);
                product.Parameter = textBox6.Text;
                product.Manufacturer = textBox7.Text;
                product.DateOfManufacturer = Convert.ToDateTime(textBox8.Text);
                product.Guarantee_period = Convert.ToInt32(textBox9.Text);
                var ProductDb = context.Products.Find(TextId);
                context.Products.Remove(ProductDb);
                context.Products.Add(product);
                context.SaveChanges();
                MessageBox.Show("Данные обновлены!");
                Close();
            }
        }

        private void GiveDataButton_Click(object sender, EventArgs e)
        {
            string StringConnection = @"Server=(localdb)\mssqllocaldb;Database=Electronic_GYM;Trusted_Connection=True;";
            string query = "select * from Products";
            using (SqlConnection connection = new SqlConnection(StringConnection))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    products.Add(new Product(reader.GetInt32(0), reader.GetString(1),
                                reader.GetString(2), reader.GetString(3),
                                reader.GetDecimal(4), reader.GetString(5),
                                reader.GetString(6), reader.GetDateTime(7), reader.GetInt32(8)));
                }
                reader.Close();
                connection.Close();
            }
           
            using (MyDBContext context = new MyDBContext())
            {
                var TextId = Convert.ToInt32(textBox1.Text);
                product = context.Products.Find(TextId);
                if (product == null)
                {
                    MessageBox.Show("Строки с таким Id не найдено! Введите Id заново!");
                    textBox1.ReadOnly = false;
                }
                else
                {
                    textBox2.Text = product.Name;
                    textBox3.Text = product.Category;
                    textBox4.Text = product.SubCategory;
                    textBox5.Text = Convert.ToString(product.Price);
                    textBox6.Text = product.Parameter;
                    textBox7.Text = product.Manufacturer;
                    textBox8.Text = Convert.ToString(product.DateOfManufacturer);
                    textBox9.Text = Convert.ToString(product.Guarantee_period);
                    textBox1.ReadOnly = true;
                }
                
            }
        }

        private void CancelBut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                    "Уверены, что хотите выйти? Все внесенные данные не будут сохранены!",
                    "Предупреждение",
                    MessageBoxButtons.YesNo
            );
            if (result == DialogResult.Yes)
                Close();
        }
    }
} 