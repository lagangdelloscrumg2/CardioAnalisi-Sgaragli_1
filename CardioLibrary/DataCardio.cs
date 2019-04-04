using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardioLibrary
{
    public class DataCardio
    {
        public static int Battiti(int età)
        {
            
            int frequenza = 220;
            int battito = frequenza - età;

            return battito;
        }
    }
}
