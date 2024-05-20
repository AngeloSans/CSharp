/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Poo
{
    class AbstractClass
    {
    }
    abstract class Account { 
        private int _id;
        private string _name;
        private string _email;

        public Account(int id, string name, string email)
        {
            this._id = id;
            this._name = name;
            this._email = email;
        }
        public override string ToString()
        {
            return $"O id da conta é: {_id} o nome da conta é : {_name} o email é: {_email}";
        }

    }

    class BussinesAccount : Account
    {
        public BussinesAccount(int id, string name, string email) : base(id, name, email)
        {
        }
    }

    class SavingAccount : Account
    {
        public SavingAccount(int id, string name, string email) : base(id, name, email)
        {
        }
    }

}
*/