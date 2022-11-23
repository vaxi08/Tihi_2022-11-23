using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tihi_2022_11_23
{
    class Program
    {
        static void Main(string[] args)
        {

            Turtle tihi = new Turtle(400, 500);

            Food[] étel = new Food[3];

            étel[0] = new Crab(15);
            étel[1] = new Crab(5);
            étel[2] = new Salad();


            for (int i = 0; i < étel.Length; i++)
            { 
                tihi.Eat(étel[i]);
            }


            Console.WriteLine();
            Console.WriteLine("A teknős értékei:");
            tihi.Ertek();
            Console.ReadKey();

        } 
    }
}
