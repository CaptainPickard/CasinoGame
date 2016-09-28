using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoGame
{
    class Spin
    {
        public void spin()
        {

            Random randNum = new Random();
            Wallet wallet = new Wallet();


            wallet.fillWallet();

            ConsoleKeyInfo begin = Console.ReadKey(true);
            Console.WriteLine("Press Enter to roll");
            Console.ReadLine();

            if (begin.Key == ConsoleKey.Enter)
            {
                Console.WriteLine("You rolled a ...");
                
            }
        }
    }
}