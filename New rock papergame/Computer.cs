using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_rock_papergame
{
    class Computer : Player
    {
        int choice;
        public void GetChoice()
        {
        Random RandomNumber = new Random();
        int x = RandomNumber.Next(0, 5);
            choice = x;
           
        }
    }
}
