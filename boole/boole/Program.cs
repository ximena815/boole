using System;

namespace boole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("b: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("blancos: ");
            int blancos = int.Parse(Console.ReadLine());

            Console.WriteLine("anulados: ");
            int anulados = int.Parse(Console.ReadLine());

            Console.WriteLine("n: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("p: ");
            double p = double.Parse(Console.ReadLine());


            int ab = a + b;
            int votoT = a + b + blancos + anulados;
            Console.WriteLine("votos totales: " + votoT);
            int may = (int)(n *  p/100);
            Console.WriteLine("poblacion mayor de edad: " + may);
            int abstencion = may - votoT;
            Console.WriteLine("abstencion: " + abstencion);

            bool con1 = anulados < ab * 0.3;
            bool con2 = blancos < ab;
            bool con3 = abstencion < votoT;
            bool con4 = blancos > ab;

            if ((con1 || con2) && (con3))
            {
                Console.WriteLine("las votaciones fueron exitosas ;3 ");
                if (a > b)
                {
                    Console.WriteLine("felicidades señor a es el ganador ;)");
                }
                if (b > a)
                {
                    Console.WriteLine("felicidades señor b es el ganador ;)");
                }


            }
            else 
            {
                Console.WriteLine("las elecciones deben ser realizadas nuevamente :O");
            }

        }
    }
}
