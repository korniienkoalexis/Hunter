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
            
            Random random = new Random();
 
            while (true)
            {
                Console.Clear();
                int x = random.Next(1, 50);
                int y = random.Next(1, 50);
                Rabbit myrabbit = new Rabbit(x, y,'@');
                Hunter myhunter = new Hunter();
                myrabbit.RabbitMoved += myhunter.Scream;
                myrabbit.Draw();
                //HunterHendler evt = myhunter.Scream;
                //evt.Invoke(x,y);
                System.Threading.Thread.Sleep(1000); 
            }
            
            
        }
    }
    
}
