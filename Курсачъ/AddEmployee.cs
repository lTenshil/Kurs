using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсачъ
{
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void SaveRows_Click(object sender, EventArgs e)
        {
            using (MyDBContext context = new MyDBContext())
            {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
                {
                    context.Employees.Add(new Employee(textBox1.Text,
                        Convert.ToInt32(textBox2.Text), Convert.ToDecimal(textBox3.Text)));
                    context.SaveChanges();
                    MessageBox.Show("Запись добавлена!");
                    Close();
                }
                else
                    MessageBox.Show("Не все данные были внесены!");
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
