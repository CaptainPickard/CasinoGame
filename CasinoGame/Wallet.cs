using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotMachineProject
{
    class Wallet
    {
        public void fillWallet()
        {


            bool isInt = false;
            int result;

            Console.WriteLine("Please input a wallet amount in an increment of 5");

            while (!isInt)
            {

                try
                {

                    string input = Console.ReadLine();
                    result = Int32.Parse(input);

                    if (result % 5 == 0)
                    {
                        isInt = true;
                        Console.WriteLine(" ");
                        Console.WriteLine("You now have $" + result + " in your wallet");

                    }
                    else
                    {
                        isInt = false;
                        Console.WriteLine(" ");
                        Console.WriteLine("Invalid entry. Please enter an int in an increment of 5");
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Invalid entry. Please enter an int in an increment of 5");

                }

            }
        }
    }
}