using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobrecargA
{
    class Program
    {
        static void Main(string[] args)
        {   //mandar a llamar a los metodos y clases y mostrar sus resultados
            Operaciones Op = new Operaciones();
            //instanciar
            var res1 = Op.Multiplicacion(2, 3, 4);
            var res2 = Op.Multiplicacion(2,4);
            var res3 = Op.Multiplicacion(2);
            Console.ReadKey();
            Datos d = new Datos();
            d.obtenerDatos();
            Console.ReadKey();




        }
    }
}
