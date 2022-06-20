using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sorvete
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            rdbsundae.TabStop = false;
            rdbnormal.TabStop = false;
            rdbchocolate.TabStop = false;
        }

        private void btncontinuar_Click(object sender, EventArgs e)
        {
            if (rdbnormal.Checked == true)
            {
                Class1.casca = 1;
                Class1.preco += 3;
            }

            if (rdbchocolate.Checked == true)
            {
                Class1.casca = 2;
                Class1.preco += 5;
            }

            if (rdbsundae.Checked == true)
            {
                Class1.casca = 3;
                Class1.preco += 7;
            }

            Form form3 = new Form3();
            form3.Show();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            Form form1 = new Form1();
            form1.Show();
        }
    }
}
