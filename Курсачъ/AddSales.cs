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

namespace Курсачъ
{
    public partial class AddSales : Form
    {
        public AddSales()
        {
            InitializeComponent();
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                    "Уверены, что хотите выйти? Все внесенные данные не будут сохранены!",
                    "Предупреждение",
                    MessageBoxButtons.YesNo
            );
            if (result == DialogResult.Yes)
                Close();
        }

        private void SaveRows_Click(object sender, EventArgs e)
        {
            List<Product> products = new List<Product>();
            using (MyDBContext context = new MyDBContext())
            {
                string StringConnection = @"Server=(localdb)\mssqllocaldb;Database=Electronic_GYM;Trusted_Connection=True;";
                string query = $"select * from Products where Id = {Convert.ToInt32(textBox1.Text)}";
                using (SqlConnection connection = new SqlConnection(StringConnection))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        products.Add(new Product(reader.GetInt32(0), reader.GetString(1), 
                            reader.GetString(2), reader.GetString(3), reader.GetDecimal(4), 
                            reader.GetString(5), reader.GetString(6), reader.GetDateTime(7), reader.GetInt32(8)));
                    }
                    reader.Close();
                    decimal cost = 0;
                    foreach (Product product in products)
                        cost = product.Price * Convert.ToInt32(textBox3.Text);
                    if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
                    {
                        context.Sales.Add(new Sale(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToDateTime(textBox4.Text), cost));
                        context.SaveChanges();
                        query = $"update Sales set Product_Id1 = Product_Id where Product_Id = {textBox1.Text}";
                        cmd.CommandText = query;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Запись добавлена!");
                        Close();
                    }
                    else
                        MessageBox.Show("Не все данные были внесены!");
                    connection.Close();
                }
            }
        }
    }
}
