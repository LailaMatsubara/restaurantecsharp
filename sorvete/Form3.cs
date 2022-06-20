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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            Form form2 = new Form2();
            form2.Show();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btncontinuar_Click(object sender, EventArgs e)
        {
            int contador = 0;

            if (cbxbaunilha.Checked) contador++;
            if (cbxmorango.Checked) contador++;
            if (cbxflocos.Checked) contador++;
            if (cbxchocolate.Checked) contador++;
            

            if(contador > 2)
            {
                MessageBox.Show("Você pode apenas selecionar até 2 sabores de sorvete.");
            }
            else
            {
                if (contador >= 1)
                {

                    if (cbxbaunilha.Checked) Class1.sabor = "baunilha";
                    if (cbxmorango.Checked) Class1.sabor = "morango";
                    if (cbxflocos.Checked) Class1.sabor = "flocos";
                    if (cbxchocolate.Checked) Class1.sabor = "chocolate";

                    if (contador == 2)
                    {
                        if(cbxbaunilha.Checked && Class1.sabor != "baunilha")
                        {
                           Class1.sabor2 = "baunilha";
                        }

                        if (cbxmorango.Checked && Class1.sabor != "morango")
                        {
                            Class1.sabor2 = "morango";
                        }
                        if (cbxflocos.Checked && Class1.sabor != "flocos")
                        {
                            Class1.sabor2 = "flocos";
                        }
                        if (cbxchocolate.Checked && Class1.sabor != "chocolate")
                        {
                            Class1.sabor2 = "chocolate";
                        }
                    }
                }

               
            }

            Form form4 = new Form4();
            form4.Show();
        }
    }
}
