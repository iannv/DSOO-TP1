using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSOO_TP1
{
    internal class Socio
    {
        private int id_socio;
        private string nombre_socio;
        private int cantidad_actividades_socio;
        private int dni_socio;
        //private List<Socio> lista_socios;

        public Socio(int id_socio, string nombre_socio, int dni_socio)
        {
            this.id_socio = id_socio;
            this.nombre_socio = nombre_socio;
            this.dni_socio = dni_socio;
            this.cantidad_actividades_socio = 0;
            //this.lista_socios = new List<Socio>();
        }

        public int Id_socio { get => id_socio; set => id_socio = value; }
        public string Nombre_socio { get => nombre_socio; set => nombre_socio = value; }
        public int Dni_socio { get => dni_socio; set => dni_socio = value; }
        public int Cantidad_actividades_socio { get => cantidad_actividades_socio; set => cantidad_actividades_socio = value; }
        //internal List<Socio> Lista_socios { get => lista_socios; set => lista_socios = value; }

        // Alta Socio
        //public void altaSocio(Socio socio)
        //{
        //    bool existeSocio = lista_socios.Any(s => s.Nombre_socio == socio.Nombre_socio);

        //    if (!existeSocio)
        //    {
        //        lista_socios.Add(socio);
        //        Console.WriteLine($"SE REGISTRÓ AL SOCIO {socio.Nombre_socio}");

        //        Console.WriteLine("--------LISTADO DE SOCIOS REGISTRADOS--------");
        //        foreach (var s in lista_socios)
        //        {
        //            Console.WriteLine($"NOMBRE: {s.Nombre_socio}");
        //        }
        //        Console.WriteLine("\n");
        //    }
        //    else
        //    {
        //        Console.WriteLine("El socio ya se encuentra registrado");
        //    }
        //}

        public override string ToString()
        {
            return $"Nombre: {nombre_socio}, DNI: {dni_socio}, cantidad actividades: {cantidad_actividades_socio} ";
        }
    }
}
