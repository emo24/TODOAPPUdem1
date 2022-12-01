using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TODOAPPUdem1.Datos;

namespace TODOAPPUdem1
{
    public partial class Agregar : Form
    {
        public Notas notas { get; private set; }
        public Agregar()
        {
            InitializeComponent();
           


        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void eButton2_Click(object sender, EventArgs e)
        {
            int codigo = 1;
            int max = 100;
           

            Random rnd = new Random();

            notas = new Notas(rnd.Next(codigo,max +1),textBox1.Text);

            NotaRepository.añadirnota(notas);

            Index inicio = new Index();

            inicio.Show();
            this.Close();
        }

    

        private void txttitle_Leave_1(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {
                textBox1.Text = "Crear Titulo";
                textBox1.ForeColor = Color.DimGray;
            }
        }

        private void txttitle_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text== "Crear Titulo")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.DimGray;
            }
        }

        private void eButton3_Click(object sender, EventArgs e)
        {

            Index index = new Index();
            index.Show();
            this.Close();

        }

        private void txttitle_Load(object sender, EventArgs e)
        {

        }

   

  

        private void textBox1_Enter(object sender, EventArgs e)
        {

            if (textBox1.Text == "Crear Titulo")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.DimGray;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Crear Titulo";
                textBox1.ForeColor = Color.DimGray;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
