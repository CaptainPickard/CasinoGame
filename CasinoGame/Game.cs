using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoGame
{
    class Game
    {
        public void playGame()
        {
            Spin pullLever = new Spin();
            pullLever.spin();
            Console.WriteLine();
        }
    }
}
