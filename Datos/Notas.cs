using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TODOAPPUdem1.Datos
{
    public class Notas
    {

        public int ID { get; set; }
        public string TitleN { get; set; }
        //public string Estado { get; set; }
        //public DateTime  Fecha { get; set; }



        public Notas(int id, string title/*,string estado , DateTime fecha*/)
        {

            this.ID = Convert.ToInt32(id);
            this.TitleN = title;
            //this.Estado = Estado;
            //this.Fecha = fecha.Date;
        }

    }
}
