using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TODOAPPUdem1.Datos;

namespace TODOAPPUdem1
{
    public partial class UserControl1 : UserControl
    {

        Index index = new Index();
       
        public UserControl1()
        {
            InitializeComponent();
        
        }

        private string _code;
        private string _title;
        //private string _Estado;
        //private DateTime _dateTime;

        [Category("Custom Prop")]
        public string Code
        {
            get { return _code; }
            set { _code = value; label2.Text = value; }
        }
        [Category("Custom Prop")]

        public string Title
        {
            get { return _title; }
            set { _title = value; label1.Text = value; }
        }

        //[Category("Custom Prop")]
        //public string dateTime
        //{
        //    get { return _dateTime; }
        //    set { _dateTime = value; label3.Text = value; }
        //}


        //public string Estado
        //{
        //    get { return _Estado; }
        //    set { _Estado = value; checkBox1.Checked = false; }
        //}

        
       
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

            Editar edite = new Editar();
            edite.codigo = Convert.ToInt16(Code.ToString());
            edite.textBox1.Text = Title.ToString();

            edite.Show();
           
            //MessageBox.Show(Code, Title);






        }

        public void cargarjson()
        {

            string path = @"C:\Users\gabri\source\repos\TODOAPPUdem1\Datos\Notas.json";
            using (StreamReader jsonstream = File.OpenText(path))
            {
                var json = jsonstream.ReadToEnd();
                List<Notas> notas = JsonConvert.DeserializeObject<List<Notas>>(json);

                


            }
        }
        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Code);

            string codigo = Code;
            NotaRepository.eliminarnota(Convert.ToInt32(codigo));


        }
    }
}
