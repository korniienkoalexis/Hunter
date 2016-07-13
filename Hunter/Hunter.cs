using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hunter
{
    class Hunter
    {
        public void Scream(int x, int y)
        {
            Console.SetCursorPosition(0, 0);
            Console.Write("The rabbit position is x={0} y={1}", x, y);
        }
    }
}
