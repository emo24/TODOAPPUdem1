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
    public partial class Editar : Form
    {
        
        public int codigo;
        public Editar()
        {
            InitializeComponent();
        }

        private void bunifuTextbox1_OnTextChange(object sender, EventArgs e)
        {

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
            Notas notas = new Notas(codigo, textBox1.Text)
            {



            };


            if (codigo != 0)
            {

                NotaRepository.actualizarnota(codigo, notas);

                Index index = new Index();
                index.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Valor incorrecto en el id");
            }
        }

        private void eButton3_Click(object sender, EventArgs e)
        {
            Index index = new Index();
            index.Show();
            this.Close();
        }
    }
}
