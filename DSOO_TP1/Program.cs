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
            //// Registramos los socios
            //Socio socio = new Socio(1, "Julián");
            //socio.altaSocio(socio);
            //Socio s2 = new Socio(2, "Guillermo");
            //socio.altaSocio(s2);
            //Socio s3 = new Socio(3, "Lucia");
            //socio.altaSocio(s3);

            //// Socios que ya están registrados
            //Socio s4 = new Socio(4, "Lucia");
            //socio.altaSocio(s4);
            //Socio s5 = new Socio(5, "Guillermo");
            //socio.altaSocio(s5);

            //// Nuevo socio
            //Socio s6 = new Socio(6, "Marcos");
            //socio.altaSocio(s6);
            ListaSocios listaSocios = new ListaSocios();

            listaSocios.altaSocio(1, "Julián", 1111);
            listaSocios.altaSocio(2, "Guillermo", 1112);
            listaSocios.altaSocio(3, "Lucia", 1113);

            //// Socios que ya están registrados
            listaSocios.altaSocio(4, "Lucia", 1113);
            listaSocios.altaSocio(5, "Guillermo", 1112);

            //// Nuevo socio
            listaSocios.altaSocio(6, "Marcos", 1116);


            Console.ReadKey();
        }
    }
}
