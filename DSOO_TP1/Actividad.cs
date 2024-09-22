using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSOO_TP1
{
    internal class Actividad
    {
        private int id_actividad;
        private string nombre_actividad;
        private int cupo_actividad;
        public Actividad() { }

        public int Id_actividad { get => id_actividad; set => id_actividad = value; }
        public string Nombre_actividad { get => nombre_actividad; set => nombre_actividad = value; }
        public int Cupo_actividad { get => cupo_actividad; set => cupo_actividad = value; }
    }
}
