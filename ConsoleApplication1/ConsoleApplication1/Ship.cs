using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Ship
    {
        Position position;
        string type;
        int health;
        public Ship()
        {

            
        }
        public Ship(int centerX, int centerY, int headX, int headY, string Type)
        {
            type = Type;

        }
        
    }
}
