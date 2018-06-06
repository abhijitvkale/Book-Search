using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cpsm2
{
    class InpFile:AbstractInpFile,IGetDetails
    {
        public override string getInpFile()
        {
            Console.WriteLine("enter InputFile name");
            return Console.ReadLine();
        }
    }
}
