using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Курсачъ
{
    public partial class Form1 : Form
    {
        public static string ButtonClick;
        public Form1()
        {
            InitializeComponent();
        }

        private void CatalogButton_Click(object sender, EventArgs e)
        {
            Catalog dlg = new Catalog();
            dlg.Show(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "electronic_GYMDataSet1.Products". При необходимости она может быть перемещена или удалена.
            this.productsTableAdapter.Fill(this.electronic_GYMDataSet1.Products);
            dataGridView1.Columns[1].HeaderText = "Название";
            dataGridView1.Columns[2].HeaderText = "Категория";
            dataGridView1.Columns[3].HeaderText = "Подкатегория";
            dataGridView1.Columns[4].HeaderText = "Цена";
            dataGridView1.Columns[5].HeaderText = "Параметр";
            dataGridView1.Columns[6].HeaderText = "Производитель";
            dataGridView1.Columns[7].HeaderText = "Дата производства";
            dataGridView1.Columns[8].HeaderText = "Гарантийный период";

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            CatalogButton.Visible = true;
            EmployeeButton.Visible = true;
            SaleButton.Visible = true;
            SearchButton.Visible = true;
            Search_Category.Visible = false;
            Search_Id.Visible = false;
            Search_Name.Visible = false;
            Search_price.Visible = false;
            Search_Subcategory.Visible = false;
            Search_Manufacturer.Visible = false;
            dataGridView1.Visible = false;
            BackButton.Visible = false;
            Search_find.Visible = false;
            textBox1.Visible = false;
            More_ThenPrice.Visible = false;
            Low_ThenPrice.Visible = false;
        }

        private void Search_find_Click(object sender, EventArgs e)
        {
            
            using (MyDBContext context = new MyDBContext())
            {
                var Text = textBox1.Text;
                if (textBox1.Text == "")
                    MessageBox.Show(
                        "Данные не были внесены, введите данные и продолжите поиск!", "Ошибка!",  MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    List<Product> products_search = new List<Product>();
                    string StringConnection = @"Server=(localdb)\mssqllocaldb;Database=Electronic_GYM;Trusted_Connection=True;";
                    string query = $"select [Id],[Name],[Category],[SubCategory],[Price],[Parameter],[Manufacturer],[DateOfManufacturer],[Guarantee_period]" +
                        $"FROM [Electronic_GYM].[dbo].[Products] where [{ButtonClick}] like N'%{Text}%'";
                    using (SqlConnection connection = new SqlConnection(StringConnection))
                    {
                        SqlCommand command = new SqlCommand(query, connection);
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            products_search.Add(new Product(reader.GetInt32(0), reader.GetString(1),
                                        reader.GetString(2), reader.GetString(3),
                                        reader.GetDecimal(4), reader.GetString(5),
                                        reader.GetString(6), reader.GetDateTime(7), reader.GetInt32(8)));
                        }
                        reader.Close();
                        connection.Close();
                    }
                    dataGridView1.DataSource = products_search;
                    dataGridView1.Visible = true;
                }
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            
            BackButton.Visible = true;
            CatalogButton.Visible = false;
            EmployeeButton.Visible = false;
            SaleButton.Visible = false;
            SearchButton.Visible = false;
            dataGridView1.Visible = false;
            Search_Id.Visible = true;
            Search_Name.Visible = true;
            Search_price.Visible = true;
            Search_Manufacturer.Visible = true;
            Search_Category.Visible = true;
            Search_Subcategory.Visible = true;
        }
        private void Search_Id_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            textBox1.Text = "";
            textBox1.Visible = true;
            Search_find.Visible = true;
            ButtonClick = "Id";
            Low_ThenPrice.Visible = false;
            More_ThenPrice.Visible = false;
        }
        private void Search_Name_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible=false;
            textBox1.Text = "";
            textBox1.Visible = true;
            Search_find.Visible = true;
            ButtonClick = "Name";
            Low_ThenPrice.Visible = false;
            More_ThenPrice.Visible = false;
        }

        private void Search_price_Click(object sender, EventArgs e)
        {
            Search_find.Visible=false;
            dataGridView1.Visible = false;
            textBox1.Text = "";
            textBox1.Visible = true;
            Low_ThenPrice.Visible = true;
            More_ThenPrice.Visible = true;
            ButtonClick = "Price";
        }

        private void Search_Manufacturer_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            textBox1.Text = "";
            textBox1.Visible = true;
            Search_find.Visible = true;
            ButtonClick = "Manufacturer";
            Low_ThenPrice.Visible = false;
            More_ThenPrice.Visible = false;
        }

        private void Search_Category_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            textBox1.Text = "";
            textBox1.Visible = true;
            Search_find.Visible = true;
            ButtonClick = "Category";
            Low_ThenPrice.Visible = false;
            More_ThenPrice.Visible = false;
        }

        private void Search_Subcategory_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            textBox1.Text = "";
            textBox1.Visible = true;
            Search_find.Visible = true;
            ButtonClick = "SubCategory";
            Low_ThenPrice.Visible = false;
            More_ThenPrice.Visible = false;
        }

        private void Low_ThenPrice_Click(object sender, EventArgs e)
        {
            using (MyDBContext context = new MyDBContext())
            {
                var Text = textBox1.Text;
                if (textBox1.Text == "")
                    MessageBox.Show(
                        "Данные не были внесены, введите данные и продолжите поиск!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    List<Product> products_search = new List<Product>();
                    string StringConnection = @"Server=(localdb)\mssqllocaldb;Database=Electronic_GYM;Trusted_Connection=True;";
                    string query = $"select [Id],[Name],[Category],[SubCategory],[Price],[Parameter],[Manufacturer],[DateOfManufacturer],[Guarantee_period]" +
                        $"FROM [Electronic_GYM].[dbo].[Products] where [{ButtonClick}] <= {Text}";
                    using (SqlConnection connection = new SqlConnection(StringConnection))
                    {
                        SqlCommand command = new SqlCommand(query, connection);
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            products_search.Add(new Product(reader.GetInt32(0), reader.GetString(1),
                                        reader.GetString(2), reader.GetString(3),
                                        reader.GetDecimal(4), reader.GetString(5),
                                        reader.GetString(6), reader.GetDateTime(7), reader.GetInt32(8)));
                        }
                        reader.Close();
                        connection.Close();
                    }
                    dataGridView1.DataSource = products_search;
                    dataGridView1.Visible = true;
                    Low_ThenPrice.Visible = false;
                    More_ThenPrice.Visible = false;
                }
            }
        }

        private void More_ThenPrice_Click(object sender, EventArgs e)
        {
            using (MyDBContext context = new MyDBContext())
            {
                var Text = textBox1.Text;
                if (textBox1.Text == "")
                    MessageBox.Show(
                        "Данные не были внесены, введите данные и продолжите поиск!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    List<Product> products_search = new List<Product>();
                    string StringConnection = @"Server=(localdb)\mssqllocaldb;Database=Electronic_GYM;Trusted_Connection=True;";
                    string query = $"select [Id],[Name],[Category],[SubCategory],[Price],[Parameter],[Manufacturer],[DateOfManufacturer],[Guarantee_period]" +
                        $"FROM [Electronic_GYM].[dbo].[Products] where [{ButtonClick}] >= {Text}";
                    using (SqlConnection connection = new SqlConnection(StringConnection))
                    {
                        SqlCommand command = new SqlCommand(query, connection);
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            products_search.Add(new Product(reader.GetInt32(0), reader.GetString(1),
                                        reader.GetString(2), reader.GetString(3),
                                        reader.GetDecimal(4), reader.GetString(5),
                                        reader.GetString(6), reader.GetDateTime(7), reader.GetInt32(8)));
                        }
                        reader.Close();
                        connection.Close();
                    }
                    dataGridView1.DataSource = products_search;
                    Low_ThenPrice.Visible = false;
                    More_ThenPrice.Visible = false;
                    dataGridView1.Visible = true;
                }
            }
        }

        private void EmployeeButton_Click(object sender, EventArgs e)
        {
            EmployeesForm employeesForm = new EmployeesForm();
            employeesForm.Show(this);
        }

        private void SaleButton_Click(object sender, EventArgs e)
        {
            SalesForm sales = new SalesForm();
            sales.Show(this);
        }
    }
}