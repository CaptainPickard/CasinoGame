using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoGame
{
    public class Spin
    {
        public void spin()
        {

            Random randNum = new Random();

            Wallet wallet = new Wallet();


            wallet.fillWallet();

            int WalletValue = 1000;

            ConsoleKeyInfo begin = Console.ReadKey(true);
            Console.WriteLine("Press Enter to roll");
            Console.ReadLine();


            if (begin.Key == ConsoleKey.Enter)
            {
                while (WalletValue > 0)
                {
                    int Value1 = randNum.Next(0, 9);
                    int Value2 = randNum.Next(0, 9);
                    int Value3 = randNum.Next(0, 9);
                    int Value = Convert.ToInt32("" + Value1 + Value2 + Value3);
                    Console.WriteLine(Value);
                    Console.ReadLine();
                    if (Value == 111)
                    {
                        Console.WriteLine("you rolled a " + Value + "!");
                        Console.ReadLine();
                        WalletValue = WalletValue + 100;
                        Console.WriteLine("You now have " + WalletValue + " in your wallet");
                        Console.ReadLine();
                    }
                    else if (Value == 222)
                    {
                        Console.WriteLine("you rolled a " + Value + "!");
                        Console.ReadLine();
                        WalletValue = WalletValue * 2;
                        Console.WriteLine("You now have " + WalletValue + " in your wallet");
                        Console.ReadLine();
                    }
                    else if (Value == 333)
                    {
                        Console.WriteLine("you rolled a " + Value + "!");
                        Console.ReadLine();
                        WalletValue = WalletValue * 3;
                        Console.WriteLine("You now have " + WalletValue + " in your wallet");
                        Console.ReadLine();
                    }
                    else if (Value == 444)
                    {
                        Console.WriteLine("you rolled a " + Value + "!");
                        Console.ReadLine();
                        WalletValue = WalletValue * 4;
                        Console.WriteLine("You now have " + WalletValue + " in your wallet");
                        Console.ReadLine();
                    }
                    else if (Value == 555)
                    {
                        Console.WriteLine("you rolled a " + Value + "!");
                        Console.ReadLine();
                        WalletValue = WalletValue * 5;
                        Console.WriteLine("You now have " + WalletValue + " in your wallet");
                        Console.ReadLine();
                    }
                    else if (Value == 666)
                    {
                        Console.WriteLine("you rolled a " + Value + "!");
                        Console.ReadLine();
                        WalletValue = WalletValue * 6;
                        Console.WriteLine("You now have " + WalletValue + " in your wallet");
                        Console.ReadLine();
                    }
                    else if (Value == 777)
                    {
                        Console.WriteLine("you rolled a " + Value + "!");
                        Console.ReadLine();
                        WalletValue = WalletValue * 7;
                        Console.WriteLine("You now have " + WalletValue + " in your wallet");
                        Console.ReadLine();
                    }
                    else if (Value == 888)
                    {
                        Console.WriteLine("you rolled a " + Value + "!");
                        Console.ReadLine();
                        WalletValue = WalletValue * 8;
                        Console.WriteLine("You now have " + WalletValue + " in your wallet");
                        Console.ReadLine();
                    }
                    else if (Value == 999)
                    {
                        Console.WriteLine("you rolled a " + Value + "!");
                        Console.ReadLine();
                        WalletValue = WalletValue * 9;
                        Console.WriteLine("You now have " + WalletValue + " in your wallet");
                        Console.ReadLine();
                    }
                    else if (Value == 000)
                    {
                        Console.WriteLine("you rolled all $$$!");
                        Console.ReadLine();
                        WalletValue = WalletValue * 10;
                        Console.WriteLine("You now have " + WalletValue + " in your wallet");
                        Console.ReadLine();
                    }
                    else
                    {
                        WalletValue = WalletValue - 10;
                        Console.WriteLine("you didnt hit a multi roll - 20");
                        Console.ReadLine();
                        Console.WriteLine("You now have " + WalletValue + " in your wallet");
                        Console.ReadLine();
                    }
                }
                Console.WriteLine("You have run out of money");
                Console.ReadLine();
            }
        }
    }
}