using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace TpModul5_2211104016
{
    class HaloGeneric
    {
        public void SapaUser(string user)
        {
            Console.WriteLine("Halo Bro {0}", user); 
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            HaloGeneric halo = new HaloGeneric();
            halo.SapaUser("Muhammad Idham"); 
        }
    }
}