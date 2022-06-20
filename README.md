# restaurantecsharp

// tela inicial
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncontinuar_Click(object sender, EventArgs e)
        {
            Class1.nome = Convert.ToString(txtnome.Text);

            Form form2 = new Form2();
            form2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

//primeira tela
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
                Class1.casca = " Casquinha normal";
                Class1.preco += 3;
            }

            if (rdbchocolate.Checked == true)
            {
                Class1.casca = "Casquinha com Chocolate";
                Class1.preco += 5;
            }

            if (rdbsundae.Checked == true)
            {
                Class1.casca = "Sundae";
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

//segunda
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
                           Class1.sabor2 = " e baunilha";
                        }

                        if (cbxmorango.Checked && Class1.sabor != "morango")
                        {
                            Class1.sabor2 = "e morango";
                        }
                        if (cbxflocos.Checked && Class1.sabor != "flocos")
                        {
                            Class1.sabor2 = "e flocos";
                        }
                        if (cbxchocolate.Checked && Class1.sabor != "chocolate")
                        {
                            Class1.sabor2 = "e chocolate";
                        }
                    }
                }

               
            }

            Form form4 = new Form4();
            form4.Show();
        }
    }
}

//terceira
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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();

            rdbchocolate.TabStop = false;
            rdbcaramelo.TabStop = false;
            rdbmorango.TabStop = false;
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            Form form3 = new Form3();
            form3.Show();
        }

        private void btncontinuar_Click(object sender, EventArgs e)
        {
            if (rdbchocolate.Checked == true)
            {
                Class1.cobertura = "Chocolate";
            }

            if (rdbcaramelo.Checked == true)
            {
                Class1.cobertura = "Caramelo";
            }

            if (rdbmorango.Checked == true)
            {
                Class1.cobertura = "Morango";
            }

            if (rdbsem.Checked == true)
            {
                Class1.cobertura = "Sem cobertura";
            }

            Form form5 = new Form5();
            form5.Show();

        }
    }
}


//quarta
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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            Form form4 = new Form4();
            form4.Show();
        }

        private void btncontinuar_Click(object sender, EventArgs e)
        {
            int contador = 0;

            if (ckbcanudo.Checked) contador++;
            if (ckbgranulado.Checked) contador++;
            if (ckbfarinha.Checked) contador++;
            if (ckbmem.Checked) contador++;


            if (contador > 2)
            {
                MessageBox.Show("Você pode apenas selecionar até 2 acompanhamentos.");
            }
            else
            {
                if (contador >= 1)
                {

                    if (ckbcanudo.Checked) Class1.acomp = "Canudo Waffer";
                    if (ckbgranulado.Checked) Class1.acomp = "Granulado";
                    if (ckbfarinha.Checked) Class1.acomp = "Farinha Doce";
                    if (ckbmem.Checked) Class1.acomp = "MeM";

                    if (contador == 2)
                    {
                        if (ckbcanudo.Checked && Class1.acomp != "Canudo Waffer")
                        {
                            Class1.acomp2 = "Canudo Waffer";
                        }

                        if (ckbgranulado.Checked && Class1.acomp != "Granulado")
                        {
                            Class1.acomp2 = "Granulado";
                        }
                        if (ckbfarinha.Checked && Class1.acomp != "Farinha Doce")
                        {
                            Class1.acomp2 = "Farinha Doce";
                        }
                        if (ckbmem.Checked && Class1.acomp != "MeM")
                        {
                            Class1.acomp2 = "MeM";
                        }
                    }
                }


            }



            Form form6 = new Form6();
            form6.Show();
        }
    }
}


//finalização
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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btncontinuar_Click(object sender, EventArgs e)
        {


            MessageBox.Show($"Olá, {Class1.nome}! " +
                $"\n Seu pedido foi:" +
                $"\n {Class1.casca}; " +
                $"\n Com massa sabor {Class1.sabor} {Class1.sabor2}; " +
                $"\n Cobertura: {Class1.cobertura} " +
                $"\n Acompanhamento: {Class1.acomp} {Class1.acomp2}." +
                $"\n \n" +
                $"O total foi de {Class1.preco}.", "Pedido");
        }
    }
}

