using System;
using System.Windows.Forms;

namespace Курсачъ
{
    public partial class DeleteEmployee : Form
    {
        public DeleteEmployee()
        {
            InitializeComponent();
        }

        private void DeleteProduct_Click(object sender, EventArgs e)
        {
            using (MyDBContext context = new MyDBContext())
            {
                if (textBox1.Text != "")
                {
                    var ID = Convert.ToInt32(textBox1.Text);
                    Employee employee = context.Employees.Find(ID);
                    if (employee != null)
                    {
                        context.Employees.Remove(employee);
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
