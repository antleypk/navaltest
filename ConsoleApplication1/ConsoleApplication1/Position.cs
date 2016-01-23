using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Position

    {
        string type;
        Point head = new Point();
        Point reference = new Point();
        Point tail = new Point();
        int length;

        

        public Position(){}
        public Position(int centerX, int centerY, int headX, int headY, string Type)
       {


        }

        public void orientCraft(int centerX, int centerY, int headX, int headY, string Type)
        {
            type = Type;
            reference.setX(centerX);
            reference.setY(centerY);
            head.setX(headX);
            head.setY(headY);
            length = calcLength(Type);


        }
        public int calcLength(string typ)
        {
            int cruiserLength = 2;
            int submarineLength = 3;
            int destroyerLength = 4;
            int battleShipLength = 5;
            int aircraftCarrierLength = 5;

            int tempLength=99999;
            if (typ == "cruiser")
            {
                tempLength = cruiserLength;
            }
            if (typ == "submarine")
            {
                tempLength = submarineLength;
            }
            if (typ == "destroyer")
            {
                tempLength = destroyerLength;
            }
            if (typ == "battleShip")
            {
                tempLength = battleShipLength;
            }
            if (typ == "aircraftCarrier")
            {
                tempLength= aircraftCarrierLength;
            }


            return tempLength;
        }


    }
}
