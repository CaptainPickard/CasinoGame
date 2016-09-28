using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotMachineProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Spin pullLever = new Spin();
            pullLever.spin();
            Console.WriteLine();

        }
    }
}
