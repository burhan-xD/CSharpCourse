using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Customer
    {

        // get-set ile tanımlanmış değişkenler property'dir
        // aşağıdaki gibi get- set olmadan düz değişken gibi tanımlanmış olanlara field denir.
        // public string Name;
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

    }
}
