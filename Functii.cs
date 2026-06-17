using System;
using System.Collections.Generic;
using System.Text;

namespace initiere
{
    internal class Functii
    {
        //todo: functie ce calculeaza suma cifrelor unui numar
        //23245
        public static int SumaCifrelor(int numar)
        {
            int suma = 0;
            while(numar > 0)
            {
                int uc = numar % 10;

                suma=suma+uc;

                numar = numar / 10;
            }
            return suma;
                
        }


    }
}
