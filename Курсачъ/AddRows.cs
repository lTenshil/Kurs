using System;
using System.Windows.Forms;

namespace Курсачъ
{
    public partial class AddRow : Form
    {
        public AddRow()
        {
            InitializeComponent();
        }


        private void SaveRows_Click(object sender, EventArgs e)
        {
            using (MyDBContext context = new MyDBContext())
            {
                if (textBox1.Text != "" && comboBox1.Text != "" && comboBox2.Text != "" && textBox4.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "" && textBox9.Text != "")
                {
                    context.Products.Add(new Product(textBox1.Text, comboBox1.Text, comboBox2.Text, Convert.ToDecimal(textBox4.Text), textBox6.Text, textBox7.Text, Convert.ToDateTime(textBox8.Text), Convert.ToInt32(textBox9.Text)));
                    context.SaveChanges();
                    MessageBox.Show("Запись добавлена!");
                    Close();
                }
                else
                {
                    MessageBox.Show("Не все данные внесены! Внесите данные заново и сохраните изменения.");
                }
                
            }
            
        }

        private void AddRow_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "electronic_GYMDataSet4.Products". При необходимости она может быть перемещена или удалена.
            this.productsTableAdapter.Fill(this.electronic_GYMDataSet4.Products);

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
    }
}
