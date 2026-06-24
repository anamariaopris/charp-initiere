using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
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
                numar = numar / 10;

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
                {
                    suma = suma + cifra;
                }
                n = n / 10;
            }

            return suma;

        }

        //7
        public static int SumaCifrelorImpare(int n)
        {
            int suma = 0;

            while (n > 0)
            {
                int cifra = n % 10;
                if (cifra % 2 != 0)
                {
                    suma = suma + cifra;
                }
                n = n / 10;
            }
            return suma;


        }

        //8
        public static int CifraMaxima(int n)
        {
            int maxim = 0;

            while (n > 0)
            {
                int cifra = n % 10;

                if (cifra > maxim)


                    n = n / 10;
            }
            return maxim;

        }

        //9
        public static int CifraMinima(int n)
        {
            int minim = 9;

            while (n > 0)
            {
                int cifra = n % 10;

                if (cifra < minim)
                    minim = cifra;

                n = n / 10;
            }

            return minim;
        }

        //10
        public static int AparitiiCifra(int n, int c)
        {
            int aparitiiCifra = 0;

            while (n > 0)
            {
                int cifra = n % 10;

                if (cifra == c)
                    aparitiiCifra++;

                n = n / 10;
            }

            return aparitiiCifra;
        }

        //B.Verificari-returneaza bool
        //11

        public static bool EstePar(int n)
        {

            return n % 2 == 0;
        }

        //12 
        public static bool EsteDivizibilCu(int n, int k)
        {

            return n % k == 0;

        }

        //13
        public static bool ContineCifra(int n, int c)
        {
            while (n > 0)
            {
                int cifra = n % 10;

                if (cifra == c)
                {
                    return true;
                }

                n = n / 10;

            }

            return false;
        }

        //14
        public static bool ArePatruCifre(int n)
        {

            int contor = 0;

            while (n > 0)
            {
                int cifra = n % 10;
                contor++;
                n = n / 10;
            }

            return contor == 4;

        }

        //C. sume si numarari - recap while simplu
        //15

        public static int SumaDeLa1LaN(int n)
        {
            
            int ct = 1;
            int suma = 0;

            while (ct <= n)
            {
                suma = suma + ct;
                ct++;
            }
            return suma;
        }

        //16.
        public static int SumaParelorePanalaN(int n)
        {
            int suma = 0;
            int ct = 0;

            while(ct <= n)                    
            {
               if( ct % 2 == 0)
                {
                   
                    suma = suma + ct;
                   
                }
                ct++;

            }
            return suma;

        }

        //17 
        public static int CatiMultipliDe3(int n)
        {
          
            int ct = 1;
            int contorMultipli = 0;

            while (ct <= n)
            {
                if (ct % 3 == 0)
                {
                    contorMultipli++;
                }
                ct++;
               
            }
            return contorMultipli;


        }
        //18
        public static int Factorial(int n)
        {
            int produs = 1;
            int ct = 1;

            while(ct <=n)
            {

                produs = produs * ct;
                ct++;
            }
            return produs;
        }

    }

}
