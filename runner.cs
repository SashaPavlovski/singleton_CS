using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//@"C:\Users\User\source\repos\cs\files_2_CS\bank.txt"

namespace singleton_CS
{
    internal class runner
    {
        public runner(string afileName)
        {
            fileName = afileName;
        }
        private readonly string fileName;
        private StreamReader sr;
        public int CountLines()
        {
            sr= new StreamReader(fileName);
            int countLines = 0;
            while (sr.ReadLine() is string str)
            {
                countLines++;
            }
            sr.Close();
            return countLines;
        }

        public void Run(Bank[]arrBank)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            StreamReader sr = new StreamReader(fileName);

            sr = new StreamReader(fileName);
            int index = 0;
            sr.ReadLine();
            while (sr.ReadLine() is string str)
            {
                string[] bankDetails = str.Split(',');

                arrBank[index] = new Bank(bankDetails[0], bankDetails[1], bankDetails[2], bankDetails[4], bankDetails[5], bankDetails[8]);
                index++;
            }

            sr.Close();
            for (int i = 0; i < arrBank.Length-1; i++)
            {
                Console.WriteLine("Bank Code:{0}, Bank Name:{1}, Branch Code:{2}, Branch Address:{3}, City:{4}, Telephone:{5}", arrBank[i].BankCode, arrBank[i].BankName, arrBank[i].BranchCode, arrBank[i].BranchAddress, arrBank[i].City, arrBank[i].Telephone);
            }
        }
        
    }
}