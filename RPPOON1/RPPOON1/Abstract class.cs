using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOON1
{
    abstract class Person
    {
        public string Name { get; set; }
        public string Surname {  get; set; }
        public string Address { get; set; }
        public int ID { get; set; }
    }
    abstract class Transaction:ITransakcija
    {
        public int ID { get; set; }
        public DateTime Timestamp { get; set; }

        public abstract void ExecuteTransaction();
    }
}
