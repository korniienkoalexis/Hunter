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
            //private int x;
            //private int y;
           // private char sym;
            

            /*public Rabbit(int _x, int _y, char _sym)
            {
                x = _x;
                y = _y;
                sym = _sym;
                
            }*/

            public void Draw (out int x, out int y)
            {
                Random random = new Random();
                x = random.Next(1, 50);
                y = random.Next(1, 50);
                //sym = '@';
                //Console.SetCursorPosition(x, y);
                //Console.Write(sym);
                
                if (RabbitMoved != null)
                {
                    RabbitMoved(x,y);
                }
                //return x , y;
            }
        }
}
