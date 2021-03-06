using System;
using System.Windows.Forms;

namespace Курсачъ
{
    public partial class DeleteRow : Form
    {
        
        public DeleteRow()
        {
            InitializeComponent();
        }

        
        private void DeleteRow_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "electronic_GYMDataSet3.Products". При необходимости она может быть перемещена или удалена.
            this.productsTableAdapter.Fill(this.electronic_GYMDataSet3.Products);

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            using (MyDBContext context = new MyDBContext())
            {
                if (textBox1.Text != "")
                {
                    var ID = Convert.ToInt32(textBox1.Text);
                    Product product = context.Products.Find(ID);
                    if (product != null)
                    {
                        context.Products.Remove(product);
                        context.SaveChanges();
                        MessageBox.Show("Строка удалена!");
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Строки с таким Id не найдено! Введите Id заново.");
                        textBox1.Text = "";
                    }
                }
                else
                    MessageBox.Show("Введите Id для удаления!");
            }
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
