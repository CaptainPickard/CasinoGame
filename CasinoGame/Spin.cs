using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotMachineProject
{
    class Spin
    {
        public void spin()
        {

            Random randNum = new Random();

            Wallet wallet = new Wallet();

            int Value1 = randNum.Next(0, 9);
            int Value2 = randNum.Next(0, 9);
            int Value3 = randNum.Next(0, 9);

            wallet.fillWallet();

            ConsoleKeyInfo begin = Console.ReadKey(true);
            Console.WriteLine("Press Enter to roll");
            Console.ReadLine();

            if (begin.Key == ConsoleKey.Enter)
            {
                Console.WriteLine("You rolled!");
                Console.WriteLine(Value1 + Value2 + Value3);
                Console.ReadLine();
            }
        }
    }
}