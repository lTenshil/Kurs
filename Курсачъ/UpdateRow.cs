
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Курсачъ
{
    public partial class UpdateRow : Form
    {
        public UpdateRow()
        {
            InitializeComponent();
        }

       

        private void UpdateRow_Load(object sender, System.EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "electronic_GYMDataSet.Products". При необходимости она может быть перемещена или удалена.
            this.productsTableAdapter.Fill(this.electronic_GYMDataSet.Products);

        }

        private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            
            var ComboId = comboBox1.SelectedText;
            using (MyDBContext context = new MyDBContext())
            {
                string StringConnection = @"Server=(localdb)\mssqllocaldb;Database=Electronic_GYM;Trusted_Connection=True;"; 
                List<Product> products = new List<Product>();
                string query = "select Name, Category, SubCategory, Price, Parameter, Manufacturer, DateOfManufacturer, Guarantee_period from Products";
                using (SqlConnection connection = new SqlConnection(StringConnection))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        products.Add(new Product(reader.GetString(0), reader.GetString(1),
                                    reader.GetString(2), reader.GetDecimal(3),
                                    reader.GetString(4), reader.GetString(5),
                                    reader.GetDateTime(6), reader.GetInt32(7)));
                    }
                    reader.Close();
                    connection.Close();
                }
                
                for (int i=0; i<products.Count; i++)
                {
                    var index = 0;
                    if (i == comboBox1.SelectedIndex)
                    {
                        textBox2.Text = products[i].Name;
                        textBox3.Text = products[i].Category;
                        textBox4.Text = products[i].SubCategory;
                        textBox5.Text = Convert.ToString(products[i].Price);
                        textBox6.Text = products[i].Parameter;
                        textBox7.Text = products[i].Manufacturer;
                        textBox8.Text=Convert.ToString(products[i].DateOfManufacturer);
                        textBox9.Text=Convert.ToString(products[i].Guarantee_period);
                        index = i;
                        break;
                    }
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
             
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.ReadOnly)
                MessageBox.Show("Не редачит");
            else
                MessageBox.Show("Редачит");
        }
    }
}
