using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobrecargA
{
    class Datos
    {   //metodo para obtener los datos y imprimir(realiza operacion)
        public void obtenerDatos()
        {
            Operaciones Op = new Operaciones();
            Console.WriteLine("hola");
            Console.WriteLine(" ingrese datos 3 datos");
            Console.WriteLine("datos 1: ");
            double cool1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("datos 2: ");
            double cool2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("datos 3: ");
            double cool3 = Convert.ToDouble(Console.ReadLine());

            //realiza la multiplicacion de los datos de la sobrecarga
            double res = Op.Multiplicacion(cool1 * cool2 * cool3);
            Console.WriteLine("el resultado es: " + res);

            double res2 = Op.Multiplicacion(cool1 * cool2);
            Console.WriteLine("el resultado es: " + res2);
            
            double res3 = Op.Multiplicacion(cool1 );
            Console.WriteLine("el resultado es: " + res3);
        }
    }
}
