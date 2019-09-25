using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobrecargA
{
    class Operaciones
    {


      //creacion de metodos para sobrecarga

        
        //metodos donde se realiza las operacion 
        public  double Multiplicacion(double a, double b, double c) 
        {
            double res;

            res = a * b * c;
           //retorna el valor res
            return res;
 
        }
       
        public  double Multiplicacion(double a, double b)
        {
            double res;
            res = a * b;
            return res;

        }

        public  double Multiplicacion(double a)
        {
            double res;
            res = a * 5;
            return res;

        }


    }
}
