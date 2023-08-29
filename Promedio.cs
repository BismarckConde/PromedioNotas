using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromedioNotas
{
    public class Promedi0
    {
        public string nombre { set; get; }
        public int nota1 { set; get; }
        public int nota2 { set; get; }
        public int nota3 { set; get; }
        public int nota4 { set; get; }

        public int NotaBaja()
        {
            int menor = int.MaxValue;
            if (nota1 < nota2) menor = nota1; else menor= nota2;
            if (nota3 < menor) menor = nota3;
            if (nota4 < menor) menor = nota4;
            return menor;
        }

        public double promedio()
        {
            return (nota1 + nota2 + nota3 + nota4 - NotaBaja()) / 3.0;
        }

        public string Condicion(double promedio)
        {
            string condicion;
            if (promedio > 90)
            {
                condicion = " EXCELENTE ";
            }
            else if (promedio > 80 && promedio >= 90)
            {
                condicion= " MUY BUEN ";
            }
            else if (promedio > 70 && promedio >= 80)
            {
                condicion = " BUENO ";
            }
            else if (promedio > 60 && promedio >= 70)
            {
                condicion= " REGULAR ";
            }
            else if (promedio >= 60)
            {
                condicion = " REPROBADO ";
            }
            else
            {
                condicion = " REPROBADO";
            }
            return condicion;

           
        }

    }
}
