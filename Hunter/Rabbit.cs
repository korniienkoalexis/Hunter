using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hunter
{
    
        public delegate void HunterHendler(int x, int y);
        class Rabbit
        {
            public event HunterHendler RabbitMoved;
            public int x;
            public int y;
            public char sym;
            
            public Rabbit(int _x, int _y, char _sym)
            {
                x = _x;
                y = _y;
                sym = _sym;
            }

            public void Draw()
            {
                Console.SetCursorPosition(x, y);
                Console.Write(sym);
                if (RabbitMoved != null)
                {
                    RabbitMoved(x,y);
                }
            }
        }
}
