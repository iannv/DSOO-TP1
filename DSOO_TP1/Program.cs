using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DSOO_TP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///// Crear clubDeportivo (crea listaSocios)
            ClubDeportivo clubDeportivo = new ClubDeportivo();

            //// Crear actividades
            clubDeportivo.crearActividad(1, "spinning", 3);
            clubDeportivo.crearActividad(2, "crossfit", 3);
            clubDeportivo.crearActividad(3, "yoga", 3);
            clubDeportivo.crearActividad(4, "pilates", 3);


            //// Alta socios
            clubDeportivo.ListaSocios.altaSocio(1, "Julián", 1111);
            clubDeportivo.ListaSocios.altaSocio(2, "Guillermo", 1112);
            clubDeportivo.ListaSocios.altaSocio(3, "Lucia", 1113);

            //// Socios que ya están registrados
            clubDeportivo.ListaSocios.altaSocio(4, "Lucia", 1113);
            clubDeportivo.ListaSocios.altaSocio(5, "Guillermo", 1112);

            //// Nuevo socio
            clubDeportivo.ListaSocios.altaSocio(6, "Marcos", 1116);

            //// Inscribir socios en actividades
            Console.WriteLine(clubDeportivo.inscribirActividad("spinning", 1113));
            Console.WriteLine(clubDeportivo.inscribirActividad("spinning", 1112));
            Console.WriteLine(clubDeportivo.inscribirActividad("spinning", 1116));

            //// Cantidad de cupos alcanzados
            Console.WriteLine(clubDeportivo.inscribirActividad("spinning", 1111));

            Console.WriteLine(clubDeportivo.inscribirActividad("crossfit", 1116));
            Console.WriteLine(clubDeportivo.inscribirActividad("yoga", 1116));
            /// TOPE DE ACTIVIDADES ALCANZADO
            Console.WriteLine(clubDeportivo.inscribirActividad("pilates", 1116));

            /// Socio inexistente
            Console.WriteLine(clubDeportivo.inscribirActividad("pilates", 1118));

            /// Actividad inexistente
            Console.WriteLine(clubDeportivo.inscribirActividad("fghjdfj", 1116));

            Console.ReadKey();
        }
    }
}
