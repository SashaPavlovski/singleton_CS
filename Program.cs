using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleton_CS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            manager.INSTANCE.loadFromFile(@"C:\Users\User\source\repos\cs\files_2_CS\bank.txt");
            Bank curr = manager.INSTANCE.GetSnif(Console.ReadLine(), Console.ReadLine());
            Console.WriteLine(curr.BankName);
        }
    }
}
