using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOON1
{
    interface IBankovniRačun
    {
        void Deposit(decimal amount);
        void Withdraw(decimal amount);
        void Info();
    }
    interface ITransakcija
    {
        void ExecuteTransaction();
    }
}

