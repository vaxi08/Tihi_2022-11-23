using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tihi_2022_11_23
{
    class Crab: Food
    {
        int size;
        public Crab(int size)
        {
            this.size = size;
        }

        public override int Value()
        {
            return size * base.Value();
        }
    }
}
