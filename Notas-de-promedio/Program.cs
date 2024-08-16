using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Notas-de-promedio
{
    public class Program
    {
      public static void Main(string[] args)
      {
        int ap = 0;
        float nota, Aprobadas, Reprobadas = 0;
        for (int x = 0; x < 40; x++)
        {
            Console.WriteLine("Favor Ingresar Nota");
            nota = float.Parse(Console.ReadLine());
            if (nota >= 3)
            {
                Aprobadas = Aprobadas + nota;
            }
            else { 
            Reprobadas = Reprobadas + nota;
            }
            Console.WriteLine("El promedio de las notas Aprobadas es: " + Aprobadas / ap);
            Console.WriteLine("El promedio de las notas Reprobadas es: " + Reprobadas / (40 - ap));
        }
      }
    }
}