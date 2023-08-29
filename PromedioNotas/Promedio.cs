using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromedioNotas
{
    public class Promedio
    {
        public string nombre { set; get; }
        public int Nota1 { set; get; }
        public int Nota2 { set; get; }
        public int Nota3 { set; get; }
        public int Nota4 { set; get; }

        public int notaBaja()
        {
            int menor;
            if (Nota1 > Nota2) menor = Nota1; 
            else menor= Nota2;
            if (Nota3 > menor) menor = Nota3;
            if (Nota4 > menor) menor = Nota4;
            return menor;
        }

        public double promedio()
        {
            return (Nota1 + Nota2 + Nota3 + Nota4 - notaBaja()) / 3.0;
        }

        public static string Condicion(double promedio, string condicion)
        {
            string Condicion;
            if (promedio > 90)
            {
                Condicion = " EXCELENTE ";
            }
            else if (promedio > 80 && promedio >= 90)
            {
                Condicion= " MUY BUEN ";
            }
            else if (promedio > 70 && promedio >= 80)
            {
                Condicion = " BUENO ";
            }
            else if (promedio > 60 && promedio >= 70)
            {
                Condicion= " REGULAR ";
            }
            else if (promedio >= 60)
            {
                Condicion = " REPROBADO ";
            }

            return condicion;
            
            
        }

        internal string Condicion()
        {
            
        }
    }
}
