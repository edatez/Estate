using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    class Car:Belongings
    {
        public enum CarColor
        {
            Red, Yellow, Blue, Black
        }

        public CarColor Color = CarColor.Black;
        public int DoorCount=0;
    }
}
