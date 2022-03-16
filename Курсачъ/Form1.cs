using System;
using System.Windows.Forms;

namespace Курсачъ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Catalog dlg = new Catalog();
            dlg.Show(this);
        }
    }
}
