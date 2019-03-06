using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquazioniLibrary
{
    public static class CalcoliCombinatori
    {
        public static  long  IsFattoriale(int num)
        {

            long fattoriale = num;

            for(int i = 1; i<num; i++)
            {
                
                fattoriale = fattoriale * i;
            }
            if (num == 0)
            {
                fattoriale = 1;
            }
            return fattoriale;
        }

    }
}
