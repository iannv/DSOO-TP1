using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DSOO_TP1
{
    internal class ClubDeportivo
    {
        private List<Actividad> actividades;
        private ListaSocios listaSocios;
        public ClubDeportivo() 
        {
            this.actividades = new List<Actividad>();
            this.listaSocios = new ListaSocios();
        }

        public ListaSocios ListaSocios { get => listaSocios; }


        private Actividad buscarActividad(string nombre)
        {
            Actividad actividadBuscada = null;
            int i = 0;
            while (i < actividades.Count && !actividades[i].Nombre_actividad.Equals(nombre))
                i++;
            if (i != actividades.Count)
                actividadBuscada = actividades[i];
            return actividadBuscada;
        }
        public void crearActividad(int idActividad, string nombreActividad, int cupoActividad)
        {
            bool resultado = false;
            Actividad actividad = buscarActividad(nombreActividad);
            if (actividad == null)
            {
                actividad = new Actividad(idActividad, nombreActividad, cupoActividad);
                actividades.Add(actividad);
                resultado = true;
            }
            if (resultado)
            {
                Console.WriteLine($"SE REGISTRÓ LA ACTIVIDAD: {nombreActividad}");
            }
            else Console.WriteLine("La actividad ya existe");
        } 

        public string inscribirActividad(string nombreActividad, int dniSocio) 
        {
            bool resultado = false;
            Actividad actividad = buscarActividad(nombreActividad);
            Socio socio = listaSocios.buscarSocio(dniSocio);

            if (actividad == null) return "ACTIVIDAD INEXISTENTE";
            else if (actividad.Cupo_actividad == 0) return "TOPE DE CUPOS ALCANZADO";
            else if (socio == null) return "SOCIO INEXISTENTE";
            else if (socio.Cantidad_actividades_socio == 3) return "TOPE DE ACTIVIDADES ALCANZADO";
            else
            {
                socio.Cantidad_actividades_socio += 1;
                actividad.Cupo_actividad -= 1;
                return "INSCRIPCION EXITOSA";
            }
        }
    }
}
