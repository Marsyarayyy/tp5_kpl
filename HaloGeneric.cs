using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul5kpl_1302213003
{
    internal class HaloGeneric<T>
    {
        public void SapaUser(T X)
        {
            Console.WriteLine("Hallo User, " + X);
        }
    }

}
