using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleton_CS
{
    internal class Bank
    {
        const string fileName = @"C:\Users\User\source\repos\cs\files_2_CS\bank.txt";
        public Bank(string bankCode, string bankName, string branchCode, string branchAddress, string city, string telephone)
        {
            BANK_CODE = bankCode;
            BankCode = BANK_CODE;
            BankName = bankName;
            BranchCode = branchCode;
            BranchAddress = branchAddress;
            City = city;
            Telephone = telephone;
        }

        public readonly string BANK_CODE;

        public string BankCode { get; set; }

        public string BankName { get; set; }


        public string BranchCode { get; set; }

        public string BranchAddress { get; set; }

        public string City { get; set; }

        public string Telephone { get; set; }
    }
}
