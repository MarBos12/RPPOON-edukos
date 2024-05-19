using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOON1
{
    class User : Person, IBankovniRačun
    {
        public int IBAN {  get; set; }
        public decimal Balance {  get; set; }

        public void Info()
        {
            Console.WriteLine($"Owner:{Name} {Surname}, IBAN:{IBAN}, Balance: {Balance} ");
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            Balance -= amount;
        }
    }
    class Bank
    {
        private List<User> users;

        public Banks(List<User> users)
        {
            this.users = users;
        }

        public User FindUserWithIBAN(int IBAN)
        {
            return users = users.Find(k => k.IBAN == IBAN);
        }

    }

}

