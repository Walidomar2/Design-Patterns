using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    internal interface IMachine_Better
    {
        void Print();
        void Scan();
    }

    internal interface INewMachine : IMachine_Better
    {
        void Fax();
    }
}
