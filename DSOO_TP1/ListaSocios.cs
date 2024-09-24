using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSOO_TP1
{
    internal class ListaSocios
    {
        private List<Socio> socios;

        public ListaSocios()
        {
            this.socios = new List<Socio>();
        }

        private Socio buscarSocio(int dni_socio)
        {
            Socio socioBuscado = null;
            int i = 0;
            while (i < socios.Count && !socios[i].getSocio().Equals(dni_socio)) 
                i++;
            if (i != socios.Count) 
                socioBuscado = socios[i];
            return socioBuscado;
        }

        public void altaSocio(int id,string nombre, int dni)
        {
            bool resultado = false;
            Socio socio = buscarSocio(dni);
            if(socio == null)
            {
                socio = new Socio(id, nombre, dni);
                socios.Add(socio);
                resultado = true;
            }
            if (resultado)
            {
                Console.WriteLine($"SE REGISTRÓ AL SOCIO {socio.Nombre_socio}, DNI: {socio.Dni_socio}");
                Console.WriteLine("--------LISTADO DE SOCIOS REGISTRADOS--------");
                foreach (var s in socios)
                {
                    Console.WriteLine($"NOMBRE: {s.Nombre_socio}, DNI: {s.Dni_socio}");
                }
                Console.WriteLine("\n");
            }
            else Console.WriteLine("El socio ya se encuentra registrado");
        }
    }
}
