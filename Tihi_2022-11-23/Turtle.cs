using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tihi_2022_11_23
{
    class Turtle
    {
        int happiness;
        int fedLevel;

        public Turtle(int happiness, int fedLevel)
        {
            this.happiness = happiness;
            this.fedLevel = fedLevel;
        }

        public void Ertek()
        {
            Console.WriteLine("Boldogság : " + this.happiness);
            Console.WriteLine("Jóllakottság : " + this.fedLevel);

        }

        public void Eat(Food food)
        {

            if (fedLevel < 500)
            {
                fedLevel += food.Value();
                happiness += food.Value() * 2;
            }
            else if (fedLevel > 500)
            {
                fedLevel += food.Value();
                happiness -= food.Value() * 2;
            }
            else if (fedLevel == 500)
                fedLevel += food.Value();
        }
    }
}
