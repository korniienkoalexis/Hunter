using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hunter
{
    class Program
    {
   
        static void Main(string[] args)
        {
            int x, y;
            Rabbit myrabbit = new Rabbit();
            Hunter myhunter = new Hunter();
            Console.SetWindowSize(100, 51);
            while (true)
            {
                Console.Clear();
                myrabbit.RabbitMoved += myhunter.Scream;
                myrabbit.Draw(out x, out y);
                Console.SetCursorPosition(x,y);
                Console.Write('@');
                System.Threading.Thread.Sleep(1000); 
            }
            
            
        }
    }
    
}
