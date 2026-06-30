using System.Diagnostics.CodeAnalysis;
using System.Runtime.ExceptionServices;

namespace initiere;


internal class ExercitiiNoi
{
    //W1
    //Suma numerelor pare de la 1 la n Citește (din cod) un int n și afișează suma numerelor pare
    //de la 1 la n.Exemplu(n = 10): Suma parelor = 30(2 + 4 + 6 + 8 + 10).
    public static int SumaParelor(int n)
    {
        int suma = 0;
        int contor = 0;

        while (n >= contor)
        {
            if (contor % 2 == 0)
            {
                suma = suma + contor;

            }
            contor++; 

        }
        return suma;

        //verificare

        //contor % 2 == 0   n >= contor ,n = 10    suma = suma + contor
        //0 % 2 == 0 - da   10 >= 0 ,da            suma = 0 + 0 => 0
        //1 % 2 == 1 - nu   10 >= 1,da             suma = 0 + 2 => 2
        //2 % 2 == 0 - da   10 >= 2 ,da...         suma = 0 + 4 => 4...
        //3 % 2 == 1 - nu                               
        //4 % 2 == 0 - da
        //5 % 2 == 1 - nu
        //6 % 2 == 0 - da
        //7 % 2 == 1 - nu
        //8 % 2 == 0 - da
        //9 % 2 == 1 - nu
        //10 % 2 == 0 - da

    }

    //W2
    //Numărarea multiplilor Pentru un int n dat, afișează câți multipli de 3 există între
    //1 și n. Exemplu (n = 20): 6 multiplii (3,6,9,12,15,18).

    public static int NumarareMultiplii(int n)
    {
        int multiplii = 0;
        int contor = 1;

        while (n >= contor)
        {
            if (contor % 3 == 0)
            {
                multiplii++; //numararea multiplilor
            }
            contor++;

        }
        return multiplii;

    }

    //???????????????????????????

    //W3.Puterea lui 2 Afișează toate puterile lui 2 mai mici sau egale cu un int n dat: 1, 2, 4, 8, 16, …
    //Exemplu(n = 20) : 1 2 4 8 16.
    public static int Puteri2(int n)
    {
        int putere = 1;
        int contor = 0;
       
        
        while (putere <= n)
        {
            contor++;
            putere = putere * 2;
        }

        return contor;
    }



    //w4
    //Suma până depăste pragul Adună 1 + 2 + 3 + … până când suma depă.e.te un prag dat.
    //Afi.ează la ce număr te - ai oprit.Exemplu(prag = 100):(suma = 105).Ne-am oprit la 14

    public static int SumaDepasestePrag(int n)
    {
        int suma = 0;
        int numar = 1;
        int prag = 0;

        while (suma < prag)
        {
            suma = suma + numar;
            numar++;

        }
        return numar;


    }

    
    //W5. Câte cifre sunt pare Pentru un int numar pozitiv, afișează câte dintre cifrele lui sunt pare.
    //Exemplu(numar = 12345) : 2 cifre pare(2 și 4).

    public static int NumarCifrePare (int n)
    {
        int numar = 0;
        int cifra = 0;
        int contor = 0;

        while (numar > 0 )
        {
            cifra = numar % 10; // u cifra

            if (cifra % 2 == 0)  //verific daca e para
            {
                contor++;
            }

            numar = numar / 10; // elimin ultima cifra
            return contor; 
        }

      
    }

    //W6. Cea mai mare cifră Pentru un int numar pozitiv, găsește și afișează cea mai mare cifră a lui.
    //Exemplu(numar = 2971) : Cifra maxima = 9.

    public static int CeaMaiMareCifra(int n)
    {
        int maximNumar = 0;
        int cifra = 0;
        int numar = 0;

        while(maximNumar > 0)
        {
            int cifra = maximNumar % 10;  // ultima cifra

            if (cifra > maximNumar)


        }


    }


















}