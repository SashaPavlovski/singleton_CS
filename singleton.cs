using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleton_CS
{
    internal class manager
    {
        private manager() { }
        private readonly static manager _INSTANCE = new manager();
        public static manager INSTANCE
        {
            get { return _INSTANCE; }
        }

        private Bank[] arr { get; set; }
        public void loadFromFile(string fileName)
        {
           runner rn = new runner(fileName);
           arr = new Bank [rn.CountLines()];
           rn.Run(arr);
        }
        public Bank GetSnif(string bankCode, string snifNum) { 
        
            for(int i = 0; i< arr.Length-1; ++i) {

                if ((arr[i].BankCode.Equals(bankCode)) && (arr[i].BranchCode.Equals(snifNum))) {
                    return arr[i];
                }
            }
            return null;
        }
    }
}
