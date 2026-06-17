using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
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
            while (numar > 0)
            {
                int uc = numar % 10;

                suma = suma + uc;


            }
            return suma;

        }
        //todo functie ce returneaza numarul de aparitii a unei cifre in numar
        //ex: 12223 2 => 3 ori

        public static int ContorAparitiiCifraNumar(int numar, int cifra)
        {
            int contor = 0;
            while (numar > 0)
            {
                int uc = numar % 10;
                if (uc == cifra)
                {
                    contor++;
                }

                numar = numar / 10;


            }

            return contor;
        }
        // 1 ex PDF
        public static int NumarCifre(int n)
        {
            int totalCifre = 0;
            while (n > 0)
            {


                totalCifre++;
                n = n / 10;
            }
            return totalCifre;

        }

        //2
        public static int UltimaCifra(int n)
        {
            int uc = n % 10;

            return uc;
        }

        //3.
        public static int ProdusCifre(int n)
        {
            int produs = 1;
            while (n > 0)
            {
                int cifra = n % 10;
                produs = produs * cifra;
                n = n / 10;

            }

            return produs;
        }

        //4
        public static int NumarCifrePare(int n)
        {
            int cifrePare = 0;
            while (n > 0)
            {
                int cifra = n % 10;
                if (cifra % 2 == 0)
                {
                    cifrePare++;
                }

                n = n / 10;

            }

            return cifrePare;
        }
        //5
        public static int NumarCifreImpare(int n)
        {
            int cifreImpare = 0;
            while (n > 0)
            {
                int cifra = n % 10;
                if (cifra % 2 != 0)
                {
                    cifreImpare++;
                }
                n = n / 10;
            }
            return cifreImpare;
        }

        //6

        public static int SumaCifrelorPare(int n)
        {
            int suma = 0;
            while (n > 0)
            {
                int cifra = n % 10;
                if (cifra % 2 == 0)
                suma = suma + cifra ;
                n = n / 10;
            }

            return suma;

        }
      
    }
}
