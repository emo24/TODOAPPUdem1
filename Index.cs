using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TODOAPPUdem1.Datos;

namespace TODOAPPUdem1
{
    public partial class Index : Form
    {
        NotaRepository Notarepository = new NotaRepository();
        public Index()
        {
            InitializeComponent();
        }
        public void listTitle()
        {

            string path = @"C:\Users\gabri\Desktop\TODOAPPUdem1\Datos\Notas.json";
            using (StreamReader jsonstream = File.OpenText(path))
            {
                var json = jsonstream.ReadToEnd();
                List<Notas> notas = JsonConvert.DeserializeObject<List<Notas>>(json);

                //List<Notas> listanotas = NotaRepository.notas;
                UserControl1[] Lista = new UserControl1[notas.Count];

                flowLayoutPanel1.Controls.Clear();

                for (int i = 0; i < Lista.Length; i++)
                {

                    Lista[i] = new UserControl1();
                    Lista[i].Code = notas[i].ID.ToString();
                    Lista[i].Title = notas[i].TitleN;
                    //userControl2s[i].dateTime ="12:12";

                    flowLayoutPanel1.Controls.Add(Lista[i]);

                }


            }



        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
         this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

            Agregar agg = new Agregar();
            agg.Show();
            this.Close();

        }

        private void Index_Load(object sender, EventArgs e)
        {
            listTitle();
        }

      
    }
}
