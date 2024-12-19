using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7._4._1
{
    public class ParkingSystem
    {
        private int[] parkingSpaces;
      

        public ParkingSystem(int big, int medium, int small)
        {
            parkingSpaces = new int[3];

            parkingSpaces[0] = big;
            parkingSpaces[1] = medium;
            parkingSpaces[2] = small;
        }
        
        public bool AddCarToLot(int carSize)
        {
            if(carSize < 1 ||  carSize > 3 || parkingSpaces[carSize - 1] <= 0 ) //checks for parking space
            {
                return false;
            }
            parkingSpaces[carSize - 1]--;
            return true;
        }


    }
}
